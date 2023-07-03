namespace LifeSimulation
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numResolution = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numDensity = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numMouseSize = new System.Windows.Forms.NumericUpDown();
			this.b_Background = new System.Windows.Forms.Button();
			this.b_Cell_Color = new System.Windows.Forms.Button();
			this.b_Exit = new System.Windows.Forms.Button();
			this.b_Start_Continue = new System.Windows.Forms.Button();
			this.b_Restart = new System.Windows.Forms.Button();
			this.b_Info = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numResolution)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMouseSize)).BeginInit();
			this.SuspendLayout();
			// 
			// numResolution
			// 
			this.numResolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numResolution.ForeColor = System.Drawing.SystemColors.MenuText;
			this.numResolution.Location = new System.Drawing.Point(57, 32);
			this.numResolution.Margin = new System.Windows.Forms.Padding(2);
			this.numResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.numResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numResolution.Name = "numResolution";
			this.numResolution.Size = new System.Drawing.Size(124, 20);
			this.numResolution.TabIndex = 2;
			this.numResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Resolution";
			// 
			// numDensity
			// 
			this.numDensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numDensity.Location = new System.Drawing.Point(57, 75);
			this.numDensity.Margin = new System.Windows.Forms.Padding(2);
			this.numDensity.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numDensity.Name = "numDensity";
			this.numDensity.Size = new System.Drawing.Size(123, 20);
			this.numDensity.TabIndex = 4;
			this.numDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(53, 54);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Desteny";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Brush Size";
			// 
			// numMouseSize
			// 
			this.numMouseSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numMouseSize.Location = new System.Drawing.Point(57, 118);
			this.numMouseSize.Margin = new System.Windows.Forms.Padding(2);
			this.numMouseSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMouseSize.Name = "numMouseSize";
			this.numMouseSize.Size = new System.Drawing.Size(123, 20);
			this.numMouseSize.TabIndex = 9;
			this.numMouseSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numMouseSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// b_Background
			// 
			this.b_Background.BackColor = System.Drawing.Color.MediumPurple;
			this.b_Background.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.b_Background.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Background.Location = new System.Drawing.Point(61, 279);
			this.b_Background.Margin = new System.Windows.Forms.Padding(2);
			this.b_Background.Name = "b_Background";
			this.b_Background.Size = new System.Drawing.Size(123, 33);
			this.b_Background.TabIndex = 15;
			this.b_Background.Text = "Background";
			this.b_Background.UseVisualStyleBackColor = false;
			this.b_Background.Click += new System.EventHandler(this.b_Background_Click);
			// 
			// b_Cell_Color
			// 
			this.b_Cell_Color.BackColor = System.Drawing.Color.LightSkyBlue;
			this.b_Cell_Color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.b_Cell_Color.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Cell_Color.Location = new System.Drawing.Point(61, 242);
			this.b_Cell_Color.Margin = new System.Windows.Forms.Padding(2);
			this.b_Cell_Color.Name = "b_Cell_Color";
			this.b_Cell_Color.Size = new System.Drawing.Size(123, 33);
			this.b_Cell_Color.TabIndex = 14;
			this.b_Cell_Color.Text = "Cells color";
			this.b_Cell_Color.UseVisualStyleBackColor = false;
			this.b_Cell_Color.Click += new System.EventHandler(this.b_Cell_Color_Click);
			// 
			// b_Exit
			// 
			this.b_Exit.BackColor = System.Drawing.Color.Crimson;
			this.b_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.b_Exit.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Exit.Location = new System.Drawing.Point(61, 316);
			this.b_Exit.Margin = new System.Windows.Forms.Padding(2);
			this.b_Exit.Name = "b_Exit";
			this.b_Exit.Size = new System.Drawing.Size(123, 33);
			this.b_Exit.TabIndex = 16;
			this.b_Exit.Text = "Exit";
			this.b_Exit.UseVisualStyleBackColor = false;
			this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
			// 
			// b_Start_Continue
			// 
			this.b_Start_Continue.BackColor = System.Drawing.Color.Lime;
			this.b_Start_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.b_Start_Continue.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Start_Continue.Location = new System.Drawing.Point(61, 205);
			this.b_Start_Continue.Margin = new System.Windows.Forms.Padding(2);
			this.b_Start_Continue.Name = "b_Start_Continue";
			this.b_Start_Continue.Size = new System.Drawing.Size(123, 33);
			this.b_Start_Continue.TabIndex = 17;
			this.b_Start_Continue.Text = "Start";
			this.b_Start_Continue.UseVisualStyleBackColor = false;
			this.b_Start_Continue.Click += new System.EventHandler(this.b_Start_Click);
			// 
			// b_Restart
			// 
			this.b_Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.b_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.b_Restart.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Restart.Location = new System.Drawing.Point(61, 168);
			this.b_Restart.Margin = new System.Windows.Forms.Padding(2);
			this.b_Restart.Name = "b_Restart";
			this.b_Restart.Size = new System.Drawing.Size(123, 33);
			this.b_Restart.TabIndex = 18;
			this.b_Restart.Text = "Reset";
			this.b_Restart.UseVisualStyleBackColor = false;
			this.b_Restart.Visible = false;
			this.b_Restart.Click += new System.EventHandler(this.b_Restart_Click);
			// 
			// b_Info
			// 
			this.b_Info.BackColor = System.Drawing.Color.Transparent;
			this.b_Info.BackgroundImage = global::LifeSimulation.Properties.Resources.free_icon_info_5393011;
			this.b_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.b_Info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.b_Info.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Info.Location = new System.Drawing.Point(206, 4);
			this.b_Info.Margin = new System.Windows.Forms.Padding(2);
			this.b_Info.Name = "b_Info";
			this.b_Info.Size = new System.Drawing.Size(40, 41);
			this.b_Info.TabIndex = 19;
			this.b_Info.UseVisualStyleBackColor = false;
			this.b_Info.Click += new System.EventHandler(this.b_Info_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 362);
			this.Controls.Add(this.b_Info);
			this.Controls.Add(this.b_Restart);
			this.Controls.Add(this.b_Start_Continue);
			this.Controls.Add(this.b_Exit);
			this.Controls.Add(this.b_Background);
			this.Controls.Add(this.b_Cell_Color);
			this.Controls.Add(this.numMouseSize);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numDensity);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numResolution);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.numResolution)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMouseSize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numResolution;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numDensity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numMouseSize;
		private System.Windows.Forms.Button b_Background;
		private System.Windows.Forms.Button b_Cell_Color;
		private System.Windows.Forms.Button b_Exit;
		private System.Windows.Forms.Button b_Start_Continue;
		private System.Windows.Forms.Button b_Restart;
		private System.Windows.Forms.Button b_Info;
	}
}