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
    public partial class rps : Form
    {
        public rps()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            time.Text = i.ToString();
            if (i == 0) 
            {
                i = 10;
                Random rnd = new Random();
                int rndVar = rnd.Next(1,4);
                if (rndVar == 1)
                {
                    picBot.ImageLocation = "hand/hand-back-fist-solid.png";
                }
                else if (rndVar == 2)
                {
                    picBot.ImageLocation = "hand/hand-scissors-solid.png";
                }
                else if (rndVar == 3)
                {
                    picBot.ImageLocation = "hand/hand-solid.png";
                }


                if (picBot.ImageLocation == picUser.ImageLocation) {
                    timer1.Enabled=false;
                    MessageBox.Show("مساوی");
                }
                else if(picUser.ImageLocation == "hand/hand-solid.png" && rndVar == 1)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("بردی");
                }
                else if (picUser.ImageLocation == "hand/hand-solid.png" && rndVar == 2)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("باختی");
                }
                else if (picUser.ImageLocation == "hand/hand-scissors-solid.png" && rndVar == 1)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("باختی");
                }
                else if (picUser.ImageLocation == "hand/hand-scissors-solid.png" && rndVar == 3)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("بردی");
                }
                else if (picUser.ImageLocation == "hand/hand-back-fist-solid.png" && rndVar == 2)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("بردی");
                }
                else if (picUser.ImageLocation == "hand/hand-back-fist-solid.png" && rndVar == 3)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("باختی");
                }
                else
                {
                    timer1.Enabled = false;
                    MessageBox.Show("باختی");
                }
            }
        }

        private void picH3_Click(object sender, EventArgs e)
        {
            picUser.ImageLocation = "hand/hand-back-fist-solid.png";
        }

        private void picH2_Click(object sender, EventArgs e)
        {
            picUser.ImageLocation = "hand/hand-scissors-solid.png";
        }

        private void picH1_Click(object sender, EventArgs e)
        {
            picUser.ImageLocation = "hand/hand-solid.png";
        }
    }
}
