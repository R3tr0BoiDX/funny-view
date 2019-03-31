namespace funnyView {
	partial class AboutDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.labelAbout = new System.Windows.Forms.Label();
			this.linkLabelBackground = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// labelAbout
			// 
			this.labelAbout.AutoSize = true;
			this.labelAbout.BackColor = System.Drawing.Color.Transparent;
			this.labelAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelAbout.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.labelAbout.ForeColor = System.Drawing.Color.White;
			this.labelAbout.Location = new System.Drawing.Point(9, 9);
			this.labelAbout.Margin = new System.Windows.Forms.Padding(0);
			this.labelAbout.Name = "labelAbout";
			this.labelAbout.Size = new System.Drawing.Size(217, 145);
			this.labelAbout.TabIndex = 0;
			this.labelAbout.Text = resources.GetString("labelAbout.Text");
			this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabelBackground
			// 
			this.linkLabelBackground.AutoSize = true;
			this.linkLabelBackground.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.linkLabelBackground.Location = new System.Drawing.Point(98, 115);
			this.linkLabelBackground.Name = "linkLabelBackground";
			this.linkLabelBackground.Size = new System.Drawing.Size(30, 15);
			this.linkLabelBackground.TabIndex = 1;
			this.linkLabelBackground.TabStop = true;
			this.linkLabelBackground.Text = "here";
			this.linkLabelBackground.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBackground_LinkClicked);
			// 
			// AboutDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::funnyView.Properties.Resources.back;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(233, 164);
			this.Controls.Add(this.linkLabelBackground);
			this.Controls.Add(this.labelAbout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "AboutDialog";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAbout;
		private System.Windows.Forms.LinkLabel linkLabelBackground;
	}
}