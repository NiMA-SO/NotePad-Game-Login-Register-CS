using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_Application_Sohrabi
{
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-solid.png";
            pic2.ImageLocation = "star/star-regular.png";
            pic3.ImageLocation = "star/star-regular.png";
            pic4.ImageLocation = "star/star-regular.png";
            pic5.ImageLocation = "star/star-regular.png";
            lblNum.Text = "1";
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-solid.png";
            pic2.ImageLocation = "star/star-solid.png";
            pic3.ImageLocation = "star/star-regular.png";
            pic4.ImageLocation = "star/star-regular.png";
            pic5.ImageLocation = "star/star-regular.png";
            lblNum.Text = "2";
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-solid.png";
            pic2.ImageLocation = "star/star-solid.png";
            pic3.ImageLocation = "star/star-solid.png";
            pic4.ImageLocation = "star/star-regular.png";
            pic5.ImageLocation = "star/star-regular.png";
            lblNum.Text = "3";
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-solid.png";
            pic2.ImageLocation = "star/star-solid.png";
            pic3.ImageLocation = "star/star-solid.png";
            pic4.ImageLocation = "star/star-solid.png";
            pic5.ImageLocation = "star/star-regular.png";
            lblNum.Text = "4";
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-solid.png";
            pic2.ImageLocation = "star/star-solid.png";
            pic3.ImageLocation = "star/star-solid.png";
            pic4.ImageLocation = "star/star-solid.png";
            pic5.ImageLocation = "star/star-solid.png";
            lblNum.Text = "5";
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-regular.png";
            pic2.ImageLocation = "star/star-regular.png";
            pic3.ImageLocation = "star/star-regular.png";
            pic4.ImageLocation = "star/star-regular.png";
            pic5.ImageLocation = "star/star-regular.png";
            lblNum.Text = "0";
        }

        private void picAll_Click(object sender, EventArgs e)
        {
            pic1.ImageLocation = "star/star-solid.png";
            pic2.ImageLocation = "star/star-solid.png";
            pic3.ImageLocation = "star/star-solid.png";
            pic4.ImageLocation = "star/star-solid.png";
            pic5.ImageLocation = "star/star-solid.png";
            lblNum.Text = "5";
        }
    }
}
