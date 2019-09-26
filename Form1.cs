using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int img = 3;

        private void LoadNextImage()
        {
            if(img==6)
            {
                img = 1;
            }
            int a = img - 2;
            int b = img - 1;
            int c = img + 1;
            int d = img + 2;
            if (a == 0) a = 5;
            else if (a == -1) a = 4;
            if (b == 0)   b = 5;
            if (c == 6) c = 1;
            if (d == 6) d = 1;
            else if (d == 7) d = 2;
            sildePic.ImageLocation = string.Format(@"Image\{0}.jpg",img);
            pic1.ImageLocation = string.Format(@"Image\{0}.jpg", a);
            pic2.ImageLocation = string.Format(@"Image\{0}.jpg", b);
            pic3.ImageLocation = string.Format(@"Image\{0}.jpg", img);
            pic4.ImageLocation = string.Format(@"Image\{0}.jpg", c);
            pic5.ImageLocation = string.Format(@"Image\{0}.jpg", d);
            img ++;
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void sildePic_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void pic5_Click(object sender, EventArgs e)
        {

        }

    }
}
