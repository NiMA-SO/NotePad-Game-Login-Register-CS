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
    public partial class bingo : Form
    {
        public bingo()
        {
            InitializeComponent();
        }

        private void lblMain_Click(object sender, EventArgs e)
        {
            Label Num = (Label)sender;
            if (Num.Text == lblCard.Text)
            {
                Num.BackColor = Color.Red;
            }
            else
            {
                Console.Beep(500,200);
            }
        }

        private void bingo_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Label Num in pContainer.Controls)
            {
                int i = rnd.Next(1, 51);
                 Num.Text = i.ToString();
             
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random card = new Random();
            string card2 = card.Next(0, 51).ToString();
            foreach (Label Num in pContainer.Controls) {
                if (card2 == Num.Text) { 
                    lblCard.Text = card2;
                }
            }
        }
        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        private void lbl1_MouseDown(object sender, MouseEventArgs e)
        {
 
            if (lbl1.BackColor == Color.Red && lbl2.BackColor == Color.Red && lbl3.BackColor == Color.Red && lbl4.BackColor == Color.Red && lbl5.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if(MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟","Compelete",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl6.BackColor == Color.Red && lbl7.BackColor == Color.Red && lbl8.BackColor == Color.Red && lbl9.BackColor == Color.Red && lbl10.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl11.BackColor == Color.Red && lbl12.BackColor == Color.Red && lbl13.BackColor == Color.Red && lbl14.BackColor == Color.Red && lbl15.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl16.BackColor == Color.Red && lbl17.BackColor == Color.Red && lbl18.BackColor == Color.Red && lbl19.BackColor == Color.Red && lbl20.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl21.BackColor == Color.Red && lbl22.BackColor == Color.Red && lbl23.BackColor == Color.Red && lbl24.BackColor == Color.Red && lbl25.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }


            else if (lbl26.BackColor == Color.Red && lbl27.BackColor == Color.Red && lbl28.BackColor == Color.Red && lbl29.BackColor == Color.Red && lbl30.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl31.BackColor == Color.Red && lbl32.BackColor == Color.Red && lbl33.BackColor == Color.Red && lbl34.BackColor == Color.Red && lbl35.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl36.BackColor == Color.Red && lbl37.BackColor == Color.Red && lbl38.BackColor == Color.Red && lbl39.BackColor == Color.Red && lbl40.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl41.BackColor == Color.Red && lbl42.BackColor == Color.Red && lbl43.BackColor == Color.Red && lbl44.BackColor == Color.Red && lbl45.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl46.BackColor == Color.Red && lbl47.BackColor == Color.Red && lbl48.BackColor == Color.Red && lbl49.BackColor == Color.Red && lbl50.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }



            else if (lbl51.BackColor == Color.Red && lbl52.BackColor == Color.Red && lbl53.BackColor == Color.Red && lbl54.BackColor == Color.Red && lbl55.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl56.BackColor == Color.Red && lbl57.BackColor == Color.Red && lbl58.BackColor == Color.Red && lbl59.BackColor == Color.Red && lbl60.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl61.BackColor == Color.Red && lbl62.BackColor == Color.Red && lbl63.BackColor == Color.Red && lbl64.BackColor == Color.Red && lbl65.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl66.BackColor == Color.Red && lbl67.BackColor == Color.Red && lbl68.BackColor == Color.Red && lbl69.BackColor == Color.Red && lbl70.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl71.BackColor == Color.Red && lbl72.BackColor == Color.Red && lbl73.BackColor == Color.Red && lbl74.BackColor == Color.Red && lbl75.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }



            else if (lbl76.BackColor == Color.Red && lbl77.BackColor == Color.Red && lbl78.BackColor == Color.Red && lbl79.BackColor == Color.Red && lbl80.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl81.BackColor == Color.Red && lbl82.BackColor == Color.Red && lbl83.BackColor == Color.Red && lbl84.BackColor == Color.Red && lbl85.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl86.BackColor == Color.Red && lbl87.BackColor == Color.Red && lbl88.BackColor == Color.Red && lbl89.BackColor == Color.Red && lbl90.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl91.BackColor == Color.Red && lbl92.BackColor == Color.Red && lbl93.BackColor == Color.Red && lbl94.BackColor == Color.Red && lbl95.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl96.BackColor == Color.Red && lbl97.BackColor == Color.Red && lbl98.BackColor == Color.Red && lbl99.BackColor == Color.Red && lbl100.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }





            else if (lbl101.BackColor == Color.Red && lbl102.BackColor == Color.Red && lbl103.BackColor == Color.Red && lbl104.BackColor == Color.Red && lbl105.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl106.BackColor == Color.Red && lbl107.BackColor == Color.Red && lbl108.BackColor == Color.Red && lbl109.BackColor == Color.Red && lbl110.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl111.BackColor == Color.Red && lbl112.BackColor == Color.Red && lbl113.BackColor == Color.Red && lbl114.BackColor == Color.Red && lbl115.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl116.BackColor == Color.Red && lbl117.BackColor == Color.Red && lbl118.BackColor == Color.Red && lbl119.BackColor == Color.Red && lbl120.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl121.BackColor == Color.Red && lbl122.BackColor == Color.Red && lbl123.BackColor == Color.Red && lbl124.BackColor == Color.Red && lbl125.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }




            else if (lbl126.BackColor == Color.Red && lbl127.BackColor == Color.Red && lbl128.BackColor == Color.Red && lbl129.BackColor == Color.Red && lbl130.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl131.BackColor == Color.Red && lbl132.BackColor == Color.Red && lbl133.BackColor == Color.Red && lbl134.BackColor == Color.Red && lbl135.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl136.BackColor == Color.Red && lbl137.BackColor == Color.Red && lbl138.BackColor == Color.Red && lbl139.BackColor == Color.Red && lbl140.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl141.BackColor == Color.Red && lbl142.BackColor == Color.Red && lbl143.BackColor == Color.Red && lbl144.BackColor == Color.Red && lbl145.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
            else if (lbl146.BackColor == Color.Red && lbl147.BackColor == Color.Red && lbl148.BackColor == Color.Red && lbl149.BackColor == Color.Red && lbl150.BackColor == Color.Red)
            {
                if (e.Button == MouseButtons.Left)
                {
                    playerNumber1.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber1.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer1 += 1;
                        lblScore1.Text = scorePlayer1.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    playerNumber2.BackColor = Color.Blue;
                    Random rnd = new Random();
                    foreach (Label Num in pContainer.Controls)
                    {
                        int i = rnd.Next(1, 51);
                        Num.Text = i.ToString();
                        Num.BackColor = Color.White;
                    }
                    if (MessageBox.Show($"{playerNumber2.Text}برنده شد آیا میخواهید ادامه دهید ؟", "Compelete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        scorePlayer2 += 1;
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                    else
                    {
                        scorePlayer1 = 0;
                        scorePlayer2 = 0;
                        lblScore1.Text = scorePlayer1.ToString();
                        lblScore2.Text = scorePlayer2.ToString();
                    }
                }
            }
        }
    }
}
