using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace funnyView {

	public partial class MainForm : Form {
		private const int gifLoops = 3;
		private int counter;
		private int loops = 1;
		private int index = 0;
		private AnimatedGIF gif;

		private List<Entry> entries = new List<Entry>();

		public MainForm() {
			InitializeComponent();
			NativeMethods.PreventSleep();

			timerImage.Stop();
			timerGIF.Stop();
			timerVideo.Stop();
		}

		private void pictureBox_Click(object sender, EventArgs e) => LoadFolder(OpenFolder());

		private void labelAbout_Click(object sender, EventArgs e) => new AboutDialog().Show();

		private void Form_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				this.Close();
			}
		}

		private void LoadFolder(string _path) {
			if (_path != string.Empty) {
				entries.Clear();
				try {
					foreach (string gif in Directory.EnumerateFiles(_path, "*.gif")) {
						Entry entry = new Entry(gif, Type.gif);
						entries.Add(entry);
					}

					foreach (string mp4 in Directory.EnumerateFiles(_path, "*.mp4")) {
						Entry entry = new Entry(mp4, Type.mp4);
						entries.Add(entry);
					}

					foreach (string png in Directory.EnumerateFiles(_path, "*.png")) {
						Entry entry = new Entry(png, Type.image);
						entries.Add(entry);
					}

					foreach (string jpg in Directory.EnumerateFiles(_path, "*.jpg")) {
						Entry entry = new Entry(jpg, Type.image);
						entries.Add(entry);
					}
				} catch {
					MessageBox.Show("No files found!");
					return;
				}

				if (entries.Count > 0) {
					entries = ShuffleEntries(entries);

					Cursor.Hide();
					labelAbout.Visible = false;
					pictureBox.Image = null;
					pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
					axWindowsMediaPlayer.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height);
					axWindowsMediaPlayer.settings.volume = 100;
					axWindowsMediaPlayer.uiMode = "none";
					axWindowsMediaPlayer.stretchToFit = true;
					ShowFunnyThings();
				}
			}
		}

		private string OpenFolder() {
			FolderBrowserDialog browserDialog = new FolderBrowserDialog {
				ShowNewFolderButton = false,
				Description = "Select a folder with funny things"
			};

			DialogResult result = browserDialog.ShowDialog();
			if (result == DialogResult.OK) {
				return browserDialog.SelectedPath;
			} else {
				return string.Empty;
			}
		}

		private List<Entry> ShuffleEntries(List<Entry> _entries) {
			Random rnd = new Random();
			Entry tmp;
			int j;

			for (int i = _entries.Count - 1; i >= 0; i -= 1) {
				j = rnd.Next(0, i + 1);

				tmp = _entries[j];
				_entries[j] = _entries[i];
				_entries[i] = tmp;
			}
			return _entries;
		}

		private void ShowFunnyThings() {
			if (entries[index].type == Type.gif) {
				ShowGIF(entries[index].path);
			} else if (entries[index].type == Type.mp4) {
				ShowVideo(entries[index].path);
			} else if (entries[index].type == Type.image) {
				ShowImage(entries[index].path);
			}

			if (index < entries.Count - 1) {
				index++;
			} else {
				index = 0;
			}
		}

		private void ShowImage(string _path) {
			pictureBox.Image = System.Drawing.Image.FromFile(_path);
			pictureBox.Visible = true;
			timerImage.Start();
		}

		private void timerImage_Tick(object sender, EventArgs e) {
			pictureBox.Visible = false;
			pictureBox.Image = null;
			timerImage.Stop();
			ShowFunnyThings();
		}

		private void ShowGIF(string _path) {
			try {
				gif = new AnimatedGIF(_path);
				int frames = gif.Images.Count;

				if (frames < 15) {
					loops = 9;
				} else if (frames > 15 && frames < 75) {
					loops = 3;
				} else {
					loops = 1;
				}

				pictureBox.Visible = true;
				timerGIF.Start();
			} catch {
				labelOSD.Text = _path + " could not be loaded.";
				ShowFunnyThings();
				return;
			}
		}

		private void timerGIF_Tick(object sender, EventArgs e) {
			if (counter < gif.Images.Count * loops) {
				AnimatedGIFFrame frame = gif.GetNextFrame();
				pictureBox.Image = frame.frame;
				if (frame.Duration <= 0) {
					timerGIF.Interval = 10;
				} else {
					timerGIF.Interval = frame.Duration * 10;
				}
				counter++;
			} else {
				pictureBox.Visible = false;
				pictureBox.Image = null;
				counter = 0;
				loops = 1;
				timerGIF.Stop();
				ShowFunnyThings();
			}
		}

		private void ShowVideo(string _path) {
			axWindowsMediaPlayer.URL = _path;
			axWindowsMediaPlayer.Ctlcontrols.play();
			axWindowsMediaPlayer.Visible = true;
			timerVideo.Start();
		}

		private void timerVideo_Tick(object sender, EventArgs e) {
			if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped) {
				timerVideo.Stop();
				axWindowsMediaPlayer.Visible = false;
				ShowFunnyThings();
			}
		}
	}

	internal struct Entry {
		public string path;
		public Type type;

		public Entry(string _path, Type _type) {
			path = _path;
			type = _type;
		}
	}

	internal enum Type {
		image,
		gif,
		mp4
	}
}