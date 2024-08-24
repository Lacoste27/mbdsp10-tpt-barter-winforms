namespace barter.Windows
{
	partial class Report
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
			label1 = new Label();
			label2 = new Label();
			postReportRadio = new RadioButton();
			userReportRadio = new RadioButton();
			label3 = new Label();
			reasonText = new RichTextBox();
			saveButton = new Button();
			postObject = new CheckedListBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(25, 19);
			label1.Name = "label1";
			label1.Size = new Size(71, 15);
			label1.TabIndex = 0;
			label1.Text = "Post report :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 49);
			label2.Name = "label2";
			label2.Size = new Size(74, 15);
			label2.TabIndex = 1;
			label2.Text = "User Report :";
			// 
			// postReportRadio
			// 
			postReportRadio.AutoSize = true;
			postReportRadio.Checked = true;
			postReportRadio.Location = new Point(122, 21);
			postReportRadio.Name = "postReportRadio";
			postReportRadio.Size = new Size(14, 13);
			postReportRadio.TabIndex = 2;
			postReportRadio.TabStop = true;
			postReportRadio.UseVisualStyleBackColor = true;
			postReportRadio.CheckedChanged += TypeReportRadio_CheckedChanged;
			// 
			// userReportRadio
			// 
			userReportRadio.AutoSize = true;
			userReportRadio.Location = new Point(122, 51);
			userReportRadio.Name = "userReportRadio";
			userReportRadio.Size = new Size(14, 13);
			userReportRadio.TabIndex = 3;
			userReportRadio.UseVisualStyleBackColor = true;
			userReportRadio.CheckedChanged += TypeReportRadio_CheckedChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(25, 88);
			label3.Name = "label3";
			label3.Size = new Size(45, 15);
			label3.TabIndex = 4;
			label3.Text = "Reason";
			// 
			// reasonText
			// 
			reasonText.Location = new Point(25, 119);
			reasonText.Name = "reasonText";
			reasonText.Size = new Size(523, 128);
			reasonText.TabIndex = 5;
			reasonText.Text = "";
			// 
			// saveButton
			// 
			saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			saveButton.Image = Properties.Resources.save;
			saveButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveButton.Location = new Point(483, 253);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 28);
			saveButton.TabIndex = 6;
			saveButton.Text = "Save";
			saveButton.TextAlign = ContentAlignment.MiddleRight;
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// postObject
			// 
			postObject.FormattingEnabled = true;
			postObject.Location = new Point(229, 9);
			postObject.MultiColumn = true;
			postObject.Name = "postObject";
			postObject.Size = new Size(319, 94);
			postObject.TabIndex = 7;
			// 
			// Report
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(569, 289);
			Controls.Add(postObject);
			Controls.Add(saveButton);
			Controls.Add(reasonText);
			Controls.Add(label3);
			Controls.Add(userReportRadio);
			Controls.Add(postReportRadio);
			Controls.Add(label2);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(585, 328);
			MinimumSize = new Size(585, 328);
			Name = "Report";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Report";
			Load += Report_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private RadioButton postReportRadio;
		private RadioButton userReportRadio;
		private Label label3;
		private RichTextBox reasonText;
		private Button saveButton;
		private CheckedListBox postObject;
	}
}