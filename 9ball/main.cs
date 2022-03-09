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
        private readonly Random rand = new Random();
        public int Random(int min, int max)
        {
            return rand.Next(min, max);
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
            int randanim = Random(1, 5);
            int rand = Random(1, 8);
            switch (randanim)
            {
                case (1):
                    anim1(e, e);
                    break;
                case (2):
                    anim2(e, e);
                    break;
                case (3):
                    anim3(e, e);
                    break;
                case (4):
                    anim4(e, e);
                    break;
            }
            switch (rand)
            {
                case (1):
                    this.ball.Image = _9ball.Properties.Resources.yes;
                    break;
                case (2):
                    this.ball.Image = _9ball.Properties.Resources.no;
                    break;
                case (3):
                    this.ball.Image = _9ball.Properties.Resources.nodoubt;
                    break;
                case (4):
                    this.ball.Image = _9ball.Properties.Resources.tryagain;
                    break;
                case (5):
                    this.ball.Image = _9ball.Properties.Resources.hardtotell;
                    break;
                case (6):
                    this.ball.Image = _9ball.Properties.Resources._100no;
                    break;
                case (7):
                    this.ball.Image = _9ball.Properties.Resources._100yes;
                    break;
            }
        }
        private void ball_Click(object sender, EventArgs e)
        {
            this.ball.Image = _9ball.Properties.Resources._9ball;
        }
        private void anim1(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + 10, ball.Location.Y + 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 20, ball.Location.Y - 20);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 20, ball.Location.Y + 20);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 16, ball.Location.Y - 16);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 14, ball.Location.Y + 14);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 10, ball.Location.Y - 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 6, ball.Location.Y + 6);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 2, ball.Location.Y - 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 2, ball.Location.Y + 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 6, ball.Location.Y - 6);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 2, ball.Location.Y + 2);
        }
        private void anim2(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 5);       
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 5);
        }
        private void anim3(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X - 10, ball.Location.Y - 15);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 20, ball.Location.Y + 10);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 17, ball.Location.Y - 8);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 15, ball.Location.Y + 5);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 12, ball.Location.Y - 3);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 9, ball.Location.Y + 1);   
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 3, ball.Location.Y + 10);  
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 1, ball.Location.Y);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 3, ball.Location.Y);  
        }
        private void anim4(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X - 15, ball.Location.Y + 15);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 30, ball.Location.Y);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 17, ball.Location.Y - 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 20, ball.Location.Y - 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 8, ball.Location.Y - 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X + 4, ball.Location.Y - 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 7, ball.Location.Y - 2);
            Thread.Sleep(38);
            ball.Location = new Point(ball.Location.X - 7, ball.Location.Y - 5);
        }

        private void title_Click(object sender, EventArgs e)
        {
            new about().Show();
        }
    }
}
