using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace LifeSimulation
{
	public partial class Form1 : Form
	{
		public Graphics graphics; //for creating pixels
		private GameEngine gameEngine;
		//
		public Brush cell_brush_color { get; set; }
		//
		public Color background_color { get; set; }
		//
		Form2 menu;
		//
		//
		public Form1() => InitializeComponent();
		private void Form1_Load(object sender, EventArgs e)
		{
			//standart values
			cell_brush_color = new SolidBrush(Color.Lime);
			background_color = Color.Black;
			//
			menu = new Form2(this);
			menu.ShowDialog();
		}
		//
		// gameplay drawing
		//
		public void StartGame()
		{
			gameEngine = new GameEngine
			(
				rows: pictureBox.Height / menu.resolution,
				cols: pictureBox.Width / menu.resolution,
				density: menu.min_desteny + menu.max_desteny - menu.desteny
			);

			Text = $"Generation: {gameEngine.CurrentGeneration}";
			gameEngine.CellUpdated += GameEngine_CellUpdated;

			pictureBox.Visible = true;
			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
			graphics = Graphics.FromImage(pictureBox.Image);

			timer1.Start();
		}
		public void ResumeGame() => timer1.Start();
		public void PauseGame()
		{
			timer1.Stop();
			menu.Show();
		}
		public void ResetGame()
		{
			Text = $"Generation: 0";
			pictureBox.Visible = false;


		}
		private void GameEngine_CellUpdated(int x, int y, bool state)
		{
			if (!timer1.Enabled)
			{
				Task.Run(() =>
				{
					graphics.FillRectangle(state ? cell_brush_color : new SolidBrush(background_color), x * menu.resolution,
						y * menu.resolution,
						menu.resolution - 1, menu.resolution - 1);
					pictureBox.Refresh();
				}
				);
			}
		}

		private void timer1_Tick(object sender, EventArgs e) 
		{
			DrawNextGeneration();
		}
		public void DrawNextGeneration()
		{
			graphics.Clear(background_color);

			var field = gameEngine.GetCurrentGeneration();
			for (int x = 0; x < field.GetLength(0); x++)
			{
				for (int y = 0; y < field.GetLength(1); y++)
				{
					if (field[x, y])
						graphics.FillRectangle(cell_brush_color, x * menu.resolution, y * menu.resolution, menu.resolution - 1, menu.resolution-1);
				}
			}
			pictureBox.Refresh();
			Text = $"Generation: {gameEngine.CurrentGeneration}";
			gameEngine.NextGeneration();
		}
		//
		// cursor
		//
		private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
		{
			if (!timer1.Enabled)
				return;

			if (e.Button == MouseButtons.Left)
			{
				var x = e.Location.X / menu.resolution;
				var y = e.Location.Y / menu.resolution;

				gameEngine.GameBrushSize = menu.cell_brush_size / 2;
				gameEngine.AddCell(x, y);
			}

			else if (e.Button == MouseButtons.Right)
			{
				var x = e.Location.X / menu.resolution;
				var y = e.Location.Y / menu.resolution;

				gameEngine.GameBrushSize = menu.cell_brush_size / 2;
				gameEngine.RemoveCell(x, y);
			}
		}
		//
		// other
		//
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				PauseGame();
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				var x = e.Location.X / menu.resolution;
				var y = e.Location.Y / menu.resolution;
				gameEngine.GameBrushSize = menu.cell_brush_size / 2;
				gameEngine.AddCell(x, y);
			}
			else if (e.Button == MouseButtons.Right)
			{
				var x = e.Location.X / menu.resolution;
				var y = e.Location.Y / menu.resolution;
				gameEngine.GameBrushSize = menu.cell_brush_size / 2;
				gameEngine.RemoveCell(x, y);
			}
		}
	}
}
