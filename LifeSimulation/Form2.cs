using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LifeSimulation
{
	public partial class Form2 : Form
	{
		//public Form2() => InitializeComponent();
		public Form2(Form1 _game)
		{
			game = _game;
			InitializeComponent();
		}
		//
		//Form1 form1;
		private ColorDialog MyDialog;
		//
		public int desteny { get; private set; }
		public int min_desteny { get; private set; }
		public int max_desteny { get; private set; }
		public int resolution { get; private set; }
		public int cell_brush_size { get; private set; }
		public Form1 game { get; set; }
		//
		private void b_Info_Click(object sender, EventArgs e)
		{
			//instruction
			StringBuilder message = new StringBuilder();
			message.AppendLine("1. Click on the cells to make them alive or destroy.");
			message.AppendLine("2. Press Start to begin the simulation.");
			message.AppendLine("3. Press Esc to pause the simulation.");
			message.AppendLine("4. Press Restart to reset the simulation.");
			message.AppendLine();
			message.AppendLine("More info:");
			message.AppendLine("You can change the value of resolution and destiny only before pressing the 'Start' button!");
			message.AppendLine("*Resolution: the larger the value -> the closer the screen.");
			message.AppendLine("*Destiny: the greater the value -> the denser the cells.");
			message.AppendLine();
			message.AppendLine("Enjoy!");
			//
			MessageBox.Show(message.ToString(), "Welcome to the Game of Life!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		//
		private void b_Exit_Click(object sender, EventArgs e) => Application.Exit();
		private void b_Start_Click(object sender, EventArgs e)
		{
			if (b_Start_Continue.Text == "Continue")
			{
				Hide();
				game.ResumeGame();
				cell_brush_size = (int)numMouseSize.Value;
			}
			else
			{
				numResolution.Enabled = false;
				numDensity.Enabled = false;
				//
				desteny = (int)numDensity.Value;
				min_desteny = (int)numDensity.Minimum;
				max_desteny = (int)numDensity.Maximum;
				resolution = (int)numResolution.Value;
				cell_brush_size = (int)numMouseSize.Value;
				//
				b_Start_Continue.Text = "Continue";
				b_Restart.Visible = true;
				//
				Hide();
				game.StartGame();
			}
		}
		private void b_Cell_Color_Click(object sender, EventArgs e)
		{
			MyDialog = new ColorDialog();
			if (MyDialog.ShowDialog() == DialogResult.OK)
				game.cell_brush_color = new SolidBrush(MyDialog.Color);
		}

		private void b_Background_Click(object sender, EventArgs e)
		{
			MyDialog = new ColorDialog();
			if (MyDialog.ShowDialog() == DialogResult.OK)
				game.background_color = MyDialog.Color;

		}

		private void b_Restart_Click(object sender, EventArgs e)
		{
			game.ResetGame();
			//
			numDensity.Enabled = true;
			numResolution.Enabled = true;
			//
			b_Restart.Visible = false;
			b_Start_Continue.Text = "Start";
		}

		
	}
}
