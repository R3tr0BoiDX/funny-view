namespace funnyView {
	partial class MainForm {
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.timerGIF = new System.Windows.Forms.Timer(this.components);
			this.timerVideo = new System.Windows.Forms.Timer(this.components);
			this.labelOSD = new System.Windows.Forms.Label();
			this.timerImage = new System.Windows.Forms.Timer(this.components);
			this.labelAbout = new System.Windows.Forms.Label();
			this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(800, 450);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// timerGIF
			// 
			this.timerGIF.Tick += new System.EventHandler(this.timerGIF_Tick);
			// 
			// timerVideo
			// 
			this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
			// 
			// labelOSD
			// 
			this.labelOSD.AutoSize = true;
			this.labelOSD.BackColor = System.Drawing.Color.Transparent;
			this.labelOSD.ForeColor = System.Drawing.Color.White;
			this.labelOSD.Location = new System.Drawing.Point(12, 9);
			this.labelOSD.Name = "labelOSD";
			this.labelOSD.Size = new System.Drawing.Size(0, 13);
			this.labelOSD.TabIndex = 2;
			// 
			// timerImage
			// 
			this.timerImage.Interval = 5000;
			this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
			// 
			// labelAbout
			// 
			this.labelAbout.AutoSize = true;
			this.labelAbout.BackColor = System.Drawing.Color.Black;
			this.labelAbout.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelAbout.Font = new System.Drawing.Font("VCR OSD Mono", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAbout.ForeColor = System.Drawing.Color.Gray;
			this.labelAbout.Location = new System.Drawing.Point(685, 0);
			this.labelAbout.Name = "labelAbout";
			this.labelAbout.Size = new System.Drawing.Size(115, 33);
			this.labelAbout.TabIndex = 3;
			this.labelAbout.Text = "ABOUT";
			this.labelAbout.Click += new System.EventHandler(this.labelAbout_Click);
			// 
			// axWindowsMediaPlayer
			// 
			this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axWindowsMediaPlayer.Enabled = true;
			this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
			this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
			this.axWindowsMediaPlayer.Size = new System.Drawing.Size(800, 450);
			this.axWindowsMediaPlayer.TabIndex = 1;
			this.axWindowsMediaPlayer.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelAbout);
			this.Controls.Add(this.labelOSD);
			this.Controls.Add(this.axWindowsMediaPlayer);
			this.Controls.Add(this.pictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "funny-view";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Timer timerGIF;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
		private System.Windows.Forms.Timer timerVideo;
		private System.Windows.Forms.Label labelOSD;
		private System.Windows.Forms.Timer timerImage;
		private System.Windows.Forms.Label labelAbout;
	}
}

