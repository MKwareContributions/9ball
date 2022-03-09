using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _9ball
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.Image = ((System.Drawing.Image)(Properties.Resources.cross2));
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.Image = ((System.Drawing.Image)(Properties.Resources.cross1));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.gnu.org/licenses/agpl-3.0.txt");
        }
    }
}
