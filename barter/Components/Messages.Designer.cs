namespace barter.Components
{
	partial class Messages
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			splitContainer1 = new SplitContainer();
			messageListView = new MessageListView();
			messageFlowLayout = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1185, 41);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 11);
			label1.Name = "label1";
			label1.Size = new Size(83, 15);
			label1.TabIndex = 0;
			label1.Text = "Mes messages";
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(splitContainer1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 41);
			panel2.Name = "panel2";
			panel2.Size = new Size(1185, 603);
			panel2.TabIndex = 1;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(messageFlowLayout);
			splitContainer1.Panel1MinSize = 334;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(messageListView);
			splitContainer1.Size = new Size(1185, 603);
			splitContainer1.SplitterDistance = 400;
			splitContainer1.TabIndex = 0;
			// 
			// messageListView
			// 
			messageListView.BackColor = Color.White;
			messageListView.Dock = DockStyle.Fill;
			messageListView.Location = new Point(0, 0);
			messageListView.Name = "messageListView";
			messageListView.Size = new Size(781, 603);
			messageListView.TabIndex = 0;
			messageListView.Visible = false;
			// 
			// messageFlowLayout
			// 
			messageFlowLayout.AutoScroll = true;
			messageFlowLayout.Dock = DockStyle.Fill;
			messageFlowLayout.Location = new Point(0, 0);
			messageFlowLayout.Name = "messageFlowLayout";
			messageFlowLayout.Size = new Size(400, 603);
			messageFlowLayout.TabIndex = 0;
			// 
			// Messages
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Messages";
			Size = new Size(1185, 644);
			Load += Messages_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private SplitContainer splitContainer1;
		private MessageListView messageListView;
		private FlowLayoutPanel messageFlowLayout;
	}
}
