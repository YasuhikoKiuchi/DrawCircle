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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
        }

        private double start = 0;

        private double delta = 0.01;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);

            Image image = Image.FromFile("image.png");

            for (int i = 0; i < 360; i += 20)
            {
                double theta = i * Math.PI / 180 + start;
                double x = Math.Cos(theta) * 100 + 150;
                double y = Math.Sin(theta) * 100 + 150;
                e.Graphics.DrawImage(image, (float)x, (float)y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += delta;
            Refresh();
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            //delta += 0.01;
            delta = -delta;
        }
    }
}
