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
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTime.Text = "59";
            i = 0;
            timer1.Enabled = true;
            Random rnd = new Random();
            char letter = (char)rnd.Next(65, 91);
            lblLetter.Text = letter.ToString();
        }
        int i = 0;
        private void Numbers_KeyDown(object sender, KeyEventArgs e)
        {
            string code = lblLetter.Text;
            string key = e.KeyCode.ToString();
            if (key == code) {
                i++;
                score.Text = i.ToString();
                Console.Beep(500,1000);
                Random rnd = new Random();
                char letter = (char)rnd.Next(65, 91);
                lblLetter.Text = letter.ToString();
            }
            else
            {
                timer1.Enabled = false;
                Console.Beep(500,2000);
                MessageBox.Show("شما بازنده شدید","بازنده",MessageBoxButtons.OK);
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            if (lblTime.Text == "0")
            {
                timer1.Enabled = false;
                if (i >= 30)
                {
                    MessageBox.Show("عالی");
                }
                else if (i >= 25)
                {
                    MessageBox.Show("خیلی خوب");
                }
                else if (i >= 15)
                {
                    MessageBox.Show("خوب");
                }
                else
                {
                    MessageBox.Show("ضعیف");
                }
            }
        }
    }
}
