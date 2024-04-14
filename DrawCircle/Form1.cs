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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);

            Image image = Image.FromFile("image.png");

            for (int i = 0; i < 360; i += 20)
            {
                double theta = i * Math.PI / 180;
                double x = Math.Cos(theta) * 100 + 150;
                double y = Math.Sin(theta) * 100 + 150;
                e.Graphics.DrawImage(image, (float)x, (float)y);
            }
        }
    }
}
