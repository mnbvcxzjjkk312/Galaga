using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point p;
            int a = 0;
            while (a < 10)
            {
                a -= 5;
            }

            if (e.KeyCode == Keys.Right)
            {
                p = new Point(PlayerPB.Location.X + 5, PlayerPB.Location.Y);
                PlayerPB.Location = p;
            }
            else if (e.KeyCode == Keys.Left)
            {
                p = new Point(PlayerPB.Location.X - 5, PlayerPB.Location.Y);
                PlayerPB.Location = p;
            }

            if (e.KeyCode == Keys.Space)
            {
                while (Bullet.Location.Y > 100)
                {
                    Point pb = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                    Bullet.Location = pb;
                }
            }
        }
    }
}