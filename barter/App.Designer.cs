namespace barter
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
			LabelStatus = new Label();
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
			// LabelStatus
			// 
			LabelStatus.AutoSize = true;
			LabelStatus.Location = new Point(362, 158);
			LabelStatus.Name = "LabelStatus";
			LabelStatus.Size = new Size(39, 15);
			LabelStatus.TabIndex = 1;
			LabelStatus.Text = "Status";
			// 
			// App
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(LabelStatus);
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
		private Label LabelStatus;
	}
}
