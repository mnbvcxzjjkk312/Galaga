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
            if (e.KeyCode == Keys.Right)
            {
                Point p = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                pictureBox1.Location = p;
            }
            else if (e.KeyCode == Keys.Left)
            {
                Point p = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                pictureBox1.Location = p;
            }
        }
    }
}