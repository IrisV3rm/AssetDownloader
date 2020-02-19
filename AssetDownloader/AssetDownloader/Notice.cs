using AssetDownloader.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetDownloader
{
    public partial class Notice : Form
    {
        private Point LastLocation;
        private bool MouseDown;
        public Notice(string Info, bool YN, bool OK)
        {
            InitializeComponent();
            InfoText.Text = Info;
            if (YN)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }

            if (OK)
            {
                button3.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                Location = new Point(
                    Location.X - LastLocation.X + e.X, Location.Y - LastLocation.Y + e.Y);

                Update();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.MacHover;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.MacClose;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Resources.MacHoverMin;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Resources.MacMin;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
