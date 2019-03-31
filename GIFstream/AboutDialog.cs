using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funnyView {

	public partial class AboutDialog : Form {

		public AboutDialog() {
			InitializeComponent();
		}

		private void linkLabelBackground_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://n64s.tumblr.com/");
		}
	}
}