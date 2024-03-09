using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_Application_Sohrabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Login.BackColor = Color.FromArgb(127, Login.BackColor);
        }

        private void tBack_Tick(object sender, EventArgs e)
        {
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.FromArgb(192, 192, 255);
            btnSubmit.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Black;
            btnSubmit.ForeColor = Color.White;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(192, 192, 255);
            btnReset.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Black;
            btnReset.ForeColor = Color.White;
        }
        bool eye = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (eye == true)
            {
                pictureBox1.ImageLocation = "eye-slash-regular.png";
                tbPass.PasswordChar = '\0';
                eye = false;
            }else if (eye == false)
            {
                pictureBox1.ImageLocation = "eye-regular.png";
                tbPass.PasswordChar = '*';
                eye = true;
            }
            
        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode)) {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
               e.SuppressKeyPress = true;
               tbPass.Focus();
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void tbPass_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSubmit.Focus();
            }
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            Login.Visible = false;
            register.Visible = true;
        }

        private void tbPassword_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tbRePass_TextChanged(object sender, EventArgs e)
        {
            string password = tbRePass.Text;
            if (password.Length < 5)
            {
                tbRePass.ForeColor = Color.Red;
                if (eye3 == false)
                {
                    reRegisterImage.ImageLocation = "eye/eye-close-red.png";
                }
                else if (eye3 == true)
                {
                    reRegisterImage.ImageLocation = "eye/eye-red.png";
                }
            }
            else if (password.Length < 8 && password.Length > 5)
            {
                tbRePass.ForeColor = Color.DarkRed;
                if (eye3 == false)
                {
                    reRegisterImage.ImageLocation = "eye/eye-close-red.png";
                }
                else if (eye3 == true)
                {
                    reRegisterImage.ImageLocation = "eye/eye-red.png";
                }
            }
            else if (password.Length > 8)
            {
                tbRePass.ForeColor = Color.LightGreen;
                if (eye3 == false)
                {
                    reRegisterImage.ImageLocation = "eye/eye-close-green.png";
                }
                else if (eye3 == true)
                {
                    reRegisterImage.ImageLocation = "eye/eye-green.png";
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            if (password.Length < 5)
            {
                tbPassword.ForeColor = Color.Red;
                if (eye2 == false) 
                {
                    rgisterImage.ImageLocation = "eye/eye-close-red.png";
                }
                else if (eye2 == true)
                {
                    rgisterImage.ImageLocation = "eye/eye-red.png";
                }
            }
            else if (password.Length < 8 && password.Length > 5)
            {
                tbPassword.ForeColor = Color.DarkRed;
                if (eye2 == false)
                {
                    rgisterImage.ImageLocation = "eye/eye-close-red.png";
                }
                else if (eye2 == true)
                {
                    rgisterImage.ImageLocation = "eye/eye-red.png";
                }
            }
            else if (password.Length > 8)
            {
                tbPassword.ForeColor = Color.LightGreen;
                if (eye2 == false)
                {
                    rgisterImage.ImageLocation = "eye/eye-close-green.png";
                }
                else if (eye2 == true)
                {
                    rgisterImage.ImageLocation = "eye/eye-green.png";
                }
            }
        }
        bool eye2 = true;
        private void rgisterImage_Click(object sender, EventArgs e)
        {
            if (eye2 == true)
            {
                rgisterImage.ImageLocation = "eye-slash-regular.png";
                tbPassword.PasswordChar = '\0';
                eye2 = false;
            }
            else if (eye2 == false)
            {
                rgisterImage.ImageLocation = "eye-regular.png";
                tbPassword.PasswordChar = '*';
                eye2 = true;
            }
        }
        bool eye3 = true;
        private void reRegisterImage_Click(object sender, EventArgs e)
        {
            if (eye3 == true)
            {
                reRegisterImage.ImageLocation = "eye-slash-regular.png";
                tbRePass.PasswordChar = '\0';
                eye3 = false;
            }
            else if (eye3 == false)
            {
                reRegisterImage.ImageLocation = "eye-regular.png";
                tbRePass.PasswordChar = '*';
                eye3 = true;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            string password = tbPass.Text;
            if (password.Length < 5)
            {
                tbPass.ForeColor = Color.Red;
                if (eye == false)
                {
                    pictureBox1.ImageLocation = "eye/eye-close-red.png";
                }
                else if (eye == true)
                {
                    pictureBox1.ImageLocation = "eye/eye-red.png";
                }
            }
            else if (password.Length < 8 && password.Length > 5)
            {
                tbPass.ForeColor = Color.DarkRed;
                if (eye == false)
                {
                    pictureBox1.ImageLocation = "eye/eye-close-red.png";
                }
                else if (eye == true)
                {
                    pictureBox1.ImageLocation = "eye/eye-red.png";
                }
            }
            else if (password.Length > 8)
            {
                tbPass.ForeColor = Color.LightGreen;
                if (eye == false)
                {
                    pictureBox1.ImageLocation = "eye/eye-close-green.png";
                }
                else if (eye == true)
                {
                    pictureBox1.ImageLocation = "eye/eye-green.png";
                }
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbUserNameRegister.Text = "";
            tbPassword.Text = "";
            tbRePass.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbPass.Text = "";
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(192,192,255);
            btnRegister.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.Black;
            btnRegister.ForeColor = Color.White;
        }

        private void btnReset2_MouseEnter(object sender, EventArgs e)
        {
            btnReset2.BackColor = Color.FromArgb(192, 192, 255);
            btnReset2.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void btnReset2_MouseLeave(object sender, EventArgs e)
        {
            btnReset2.BackColor = Color.Black;
            btnReset2.ForeColor = Color.White;
        }

        string[] sqlArray = new string[90];
        int i = 0;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!(tbName.Text == "") && !(tbUserNameRegister.Text == "") && !(tbPassword.Text == "") ) 
            {
                string name = tbName.Text;
                string userName = tbUserNameRegister.Text;
                string pass = tbPassword.Text;
                string repass = tbRePass.Text;


                if (pass.Length > 8 && repass.Length > 8) {
                    if (pass == repass)
                    {
                        sqlArray[i] = name;
                        i++;
                        sqlArray[i] = userName;
                        i++;
                        sqlArray[i] = pass;
                        //label7.Text = name;
                        //label8.Text = userName;
                        //label9.Text = pass;
                        MessageBox.Show("ثبت نام انجام شد", "ERROR", MessageBoxButtons.OK);
                        register.Visible = false;
                        Login.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("رمز عبور باهم برابر نیستند", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("طول رمز عبور باید بزرگ تر از 8 باشه", "ERROR", MessageBoxButtons.OK);
                }


            }
            else
            {
                MessageBox.Show("همه فیلد ها باید پر شوند", "ERROR",MessageBoxButtons.OK);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(tbUserName.Text == "") && !(tbPass.Text == ""))
            {
                int userIndex = Array.IndexOf(sqlArray, tbUserName.Text);

                if (userIndex != -1 && tbPass.Text == sqlArray[userIndex + 1])
                {
                    MessageBox.Show("خوش آمدید آقا/خانم: " + sqlArray[userIndex - 1], "موفقیت", MessageBoxButtons.OK);
                    this.Close();
                    //menu f3 = new menu();
                    //f3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است. لطفاً مجدداً اطلاعات خود را وارد کنید یا ثبت نام کنید.", "خطا", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("همه‌ی فیلدها باید پر شوند.", "خطا", MessageBoxButtons.OK);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.Visible = false;
            Login.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.Visible = true;
            Login.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbRePass_Enter(object sender, EventArgs e)
        {
            tbRePass.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            rgisterImage.Visible = true;
            tbPassword.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void tbUserNameRegister_Enter(object sender, EventArgs e)
        {
            tbUserNameRegister.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void tbRePass_Leave(object sender, EventArgs e)
        {
            if (tbRePass.Text == "") 
            {
                tbRePass.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                tbRePass.BackColor = Color.FromArgb(180, 180, 255);
            }
            
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                tbName.BackColor = Color.FromArgb(180, 180, 255);
            }
        }

        private void tbUserNameRegister_Leave(object sender, EventArgs e)
        {
            if (tbUserNameRegister.Text == "")
            {
                tbUserNameRegister.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                tbUserNameRegister.BackColor = Color.FromArgb(180, 180, 255);
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            rgisterImage.Visible = false;
            if (tbPassword.Text == "")
            {
                tbPassword.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                tbPassword.BackColor = Color.FromArgb(180, 180, 255);
            }
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            tbUserName.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                tbUserName.BackColor = Color.FromArgb(180, 180, 255);
            }
        }
        private void tbPass_Enter(object sender, EventArgs e)
        {
            tbPass.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                tbPass.BackColor = Color.FromArgb(180, 180, 255);
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsLetter((char)e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                //e.Handled = true; 
                e.SuppressKeyPress = true;

                tbUserNameRegister.Focus();
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void tbUserNameRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tbRePass.Focus();
            }
        }

        private void tbRePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegister.Focus();
            }
        }
    }
}
