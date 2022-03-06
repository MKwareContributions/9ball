using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _9ball
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.minButton.MouseLeave += new System.EventHandler(this.minButton_MouseLeave);
            this.minButton.MouseEnter += new System.EventHandler(this.minButton_MouseEnter);
            this.title.MouseEnter += new System.EventHandler(this.title_MouseEnter);
            this.title.MouseLeave += new System.EventHandler(this.title_MouseLeave);
            this.shake.MouseEnter += new System.EventHandler(this.shake_MouseEnter);
            this.shake.MouseLeave += new System.EventHandler(this.shake_MouseLeave);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.Image = ((System.Drawing.Image)(Properties.Resources.cross2));
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.Image = ((System.Drawing.Image)(Properties.Resources.cross1));
        }
        private void minButton_MouseEnter(object sender, EventArgs e)
        {
            this.minButton.Image = ((System.Drawing.Image)(Properties.Resources.dash2));
        }
        private void minButton_MouseLeave(object sender, EventArgs e)
        {
            this.minButton.Image = ((System.Drawing.Image)(Properties.Resources.dash1));
        }
        private void title_MouseEnter(object sender, EventArgs e)
        {
            this.title.Text = "eightball";
        }
        private void title_MouseLeave(object sender, EventArgs e)
        {
            this.title.Text = "9ball";
        }
        private void shake_MouseEnter(object sender, EventArgs e)
        {
            this.shake.ForeColor = System.Drawing.Color.Black;
            this.shake.BackColor = System.Drawing.Color.White;
        }
        private void shake_MouseLeave(object sender, EventArgs e)
        {
            this.shake.ForeColor = System.Drawing.Color.White;
            this.shake.BackColor = System.Drawing.Color.Black;
        }

        private void shake_Click(object sender, EventArgs e)
        {
            anim1(e, e);
        }
        private void anim1(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + 10, ball.Location.Y + 10);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X - 20, ball.Location.Y - 20);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X + 20, ball.Location.Y + 20);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X - 16, ball.Location.Y - 16);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X + 14, ball.Location.Y + 14);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X - 10, ball.Location.Y - 10);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X + 6, ball.Location.Y + 6);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X - 2, ball.Location.Y - 2);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X + 2, ball.Location.Y + 2);
            Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X - 4, ball.Location.Y - 4);
        }
    }
}
