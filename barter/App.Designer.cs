﻿namespace barter
{
	partial class App
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(335, 76);
			label1.Name = "label1";
			label1.Size = new Size(70, 15);
			label1.TabIndex = 0;
			label1.Text = "Hello World";
			label1.Click += label1_Click;
			// 
			// App
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Name = "App";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "App";
			Load += App_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
	}
}
