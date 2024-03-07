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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 f2 = new Form1();
            //f2.ShowDialog();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) 
            {
                if (e.KeyValue == 187) {
                    tbNote.Font = new Font(tbNote.Font.FontFamily, tbNote.Font.Size + 10);
                }
                else if (e.KeyValue == 189)
                {
                    tbNote.Font = new Font(tbNote.Font.FontFamily, tbNote.Font.Size - 10);
                }
            }
        }
        int darsadInt = 100;
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbNote.Font.Size < 88) { 
                tbNote.Font = new Font(tbNote.Font.FontFamily, tbNote.Font.Size + 2, tbNote.Font.Style);
                darsadInt += 10;
                darsad.Text = darsadInt.ToString() + "%";
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbNote.Font.Size > 2) { 
                tbNote.Font = new Font(tbNote.Font.FontFamily, tbNote.Font.Size - 2, tbNote.Font.Style);
                darsadInt -= 10;
                darsad.Text = darsadInt.ToString() + "%";
            }
        }
        int i = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add =  i + "."+tbAdd.Text + "\r\n";
            tbNote.Text += add;
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i > 0) {
                tbNote.Text = string.Join(Environment.NewLine, tbNote.Lines.Take(tbNote.Lines.Length - 1));
                if (i > 1) { 
                    i--;
                }
            }

        }

        private void tbAdd_TextChanged(object sender, EventArgs e)
        {
            string col = tbAdd.Text;
            lblLine.Text = "Ln " + i + " , " + "Col " + col.Length;
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusToolStripMenuItem.Checked == true) { 
                statusToolStripMenuItem.Checked = false;
                statusBar.Visible = false;
            }
            else if (statusToolStripMenuItem.Checked == false)
            {
                statusToolStripMenuItem.Checked = true;
                statusBar.Visible = true;
            }
        }

        private void ltr_Click(object sender, EventArgs e)
        {

            if (ltr.Checked == true)
            {
                tbAdd.RightToLeft = RightToLeft.Yes;
                tbNote.RightToLeft = RightToLeft.Yes;
                ltr.Checked = false;
                rtl.Checked = true;
            }
            if (ltr.Checked == false)
            {
                tbAdd.RightToLeft = RightToLeft.No;
                tbNote.RightToLeft = RightToLeft.No;
                ltr.Checked = true;
                rtl.Checked = false;
            }
        }

        private void rtl_Click(object sender, EventArgs e)
        {
            if (rtl.Checked == true)
            {
                tbAdd.RightToLeft = RightToLeft.No;
                tbNote.RightToLeft = RightToLeft.No;
                rtl.Checked = false;
                ltr.Checked = true;
            }
            if (rtl.Checked == false)
            {
                tbAdd.RightToLeft = RightToLeft.Yes;
                tbNote.RightToLeft = RightToLeft.Yes;
                rtl.Checked = true;
                ltr.Checked = false;
            }
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            tbNote.SelectAll();
        }

        private void find_Click(object sender, EventArgs e)
        {
            string findText = tbAdd.Text;
            int index = tbNote.Text.IndexOf(findText, StringComparison.OrdinalIgnoreCase);

            if (index != -1)
            {
                MessageBox.Show($"در خط {tbNote.GetLineFromCharIndex(index) + 1} متن '{findText}' پیدا شد", "جستجو", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"متن '{findText}' یافت نشد.", "جستجو", MessageBoxButtons.OK);
            }
        }

        private void Date_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            tbAdd.Text = dt1.ToString();
        }

        private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Replace_Click(object sender, EventArgs e)
        {
            string findText = tbAdd.Text;
            string newText = tbNote.Text.Replace(findText, tbReplace.Text);

            if (!(newText == tbNote.Text))
            {
                tbNote.Text = newText;
                MessageBox.Show($"متن '{findText}' با متن جدید جایگزین شد.", "جایگزینی", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"متن '{findText}' یافت نشد.", "جستجو", MessageBoxButtons.OK);
            }
        }

        private void tbReplace_Enter(object sender, EventArgs e)
        {
            tbReplace.Text = "";
        }

        private void tbReplace_Leave(object sender, EventArgs e)
        {
            tbReplace.Text = "Replace ...";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tbNote.Text = "";
            i = 1;
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            tbNote.Cut();
        }

        private void resetZoom_Click(object sender, EventArgs e)
        {
            //    if (darsadInt > 100) { 
            //        tbNote.Font = new Font(tbNote.Font.FontFamily, tbNote.Font.Size / 9);
            //    }
            //    else if (darsadInt < 100) {
            //        tbNote.Font = new Font(tbNote.Font.FontFamily, tbNote.Font.Size + (darsadInt + 100) / 15);
            //    }
            //    darsadInt = 100;
            //    darsad.Text = darsadInt.ToString();

        }

        private void toUper_Click(object sender, EventArgs e)
        {
            string upper = tbAdd.Text.ToUpper();
            tbAdd.Text = upper;
        }

        private void toLower_Click(object sender, EventArgs e)
        {
            string lower = tbAdd.Text.ToLower();
            tbAdd.Text = lower;
        }

        private void trim_Click(object sender, EventArgs e)
        {
            string trim = tbAdd.Text.Trim();
            tbAdd.Text = trim;
        }

        private void hash_Click(object sender, EventArgs e)
        {
            string hash = tbAdd.Text.GetHashCode().ToString();
            tbAdd.Text = hash;
        }

        private void lenght_Click(object sender, EventArgs e)
        {
            string lenght = tbAdd.Text.Length.ToString();
            tbAdd.Text = lenght;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tbNote.Font = fontDialog1.Font;
        }

        private void dark_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            tbNote.BackColor = Color.Black;
            tbAdd.BackColor = Color.DarkGray;
            tbNote.ForeColor = Color.White;
            tbAdd.ForeColor = Color.White;
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;

        }

        private void light_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            tbNote.BackColor = Color.FromArgb(240, 240, 240);
            tbNote.ForeColor = Color.Black;
            tbAdd.ForeColor = Color.Black;
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            tbNote.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            tbAdd.Paste();
        }
    }
}
