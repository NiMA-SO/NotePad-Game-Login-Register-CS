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
    public partial class Safine : Form
    {
        public Safine()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = true;
        }
        int i = 150;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = i.ToString();
            i--;
            if (i == 0) {
                timer1.Enabled = false;
                timer2.Enabled = false;
                picSafine.Top = 296;
                i = 150;
                MessageBox.Show("بنازم بردی");
            }
        }
        bool isUp = false;
        private void Safine_KeyDown(object sender, KeyEventArgs e)
        {
            isUp = true;
            if (picSafine.Top <= picTop.Height + 20 || picSafine.Top >= (this.Height - picBottom.Height)-50)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("باختی");
                isUp = false;
                Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           

            if (isUp == true)
            {
                picSafine.Top -= 10;
                if (picSafine.Top == 1462)
                {
                    timer2.Enabled = false;
                    timer1.Enabled= false;
                    MessageBox.Show("باختی");
                }
            }
            else if (isUp == false){ 
                picSafine.Top += 10;
              
            }
        }

        private void Safine_KeyUp(object sender, KeyEventArgs e)
        {
            isUp = false;
            //if (picSafine.Top <= picTop.Height|| picSafine.Top >= (this.Height - picBottom.Height) - 100)
            //{
            //    timer2.Enabled = false;
            //    timer1.Enabled = false;
            //    MessageBox.Show("باختی");
            //    isUp = false;
            //    Close();
            //}
        }

        private void Safine_Load(object sender, EventArgs e)
        {
        }
    }
}
