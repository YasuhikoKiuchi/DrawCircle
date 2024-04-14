using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetBounds(0, 0, 830, 210);
        }

        private Random random = new Random();

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            for(int i = 0; i < 500; i++)
            {
                int x = random.Next(0, 1200);if (x < 600) x = random.Next(0, 1200);
                int y = random.Next(0, 630);
                int r = random.Next(0, 100);
                Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
                e.Graphics.DrawEllipse(pen, x, y, r, r);
            }
        }
    }
}
