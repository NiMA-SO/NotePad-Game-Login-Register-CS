using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_Application_Sohrabi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            Title.BackColor = Color.FromArgb(50, Color.White);
        }

        private void btnNotePad_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Notepad_MouseEnter(object sender, EventArgs e)
        {
            Notepad.BackColor = Color.LightBlue;
        }

        private void Notepad_MouseLeave(object sender, EventArgs e)
        {
            Notepad.BackColor = Color.FromArgb(192,192,255);
        }

        private void Number_MouseEnter(object sender, EventArgs e)
        {
            Number.BackColor = Color.LightBlue;
        }

        private void Number_MouseLeave(object sender, EventArgs e)
        {
            Number.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void neurometer_MouseEnter(object sender, EventArgs e)
        {
            neurometer.BackColor = Color.LightBlue;
        }

        private void neurometer_MouseLeave(object sender, EventArgs e)
        {
            neurometer.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void mines_MouseEnter(object sender, EventArgs e)
        {
            mines.BackColor = Color.LightBlue;
        }

        private void mines_MouseLeave(object sender, EventArgs e)
        {
            mines.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void ship_MouseEnter(object sender, EventArgs e)
        {
            ship.BackColor = Color.LightBlue;
        }

        private void ship_MouseLeave(object sender, EventArgs e)
        {
            ship.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void Notepad_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Numbers form = new Numbers();
            form.ShowDialog();
        }

        private void ship_Click(object sender, EventArgs e)
        {
            Safine form = new Safine();
            form.ShowDialog();
        }

        private void star_MouseEnter(object sender, EventArgs e)
        {
            Image myimage = new Bitmap("star/star-solid.png");
            star.BackgroundImage = myimage;
        }

        private void star_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap("star/star-regular.png");
            star.BackgroundImage = myimage;
        }

        private void star_Click(object sender, EventArgs e)
        {
            score form = new score();
            form.ShowDialog();
        }

        private void mines_Click(object sender, EventArgs e)
        {
            rps form = new rps();
            form.ShowDialog();
        }
    }
}
