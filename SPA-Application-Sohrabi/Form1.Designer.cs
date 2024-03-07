namespace SPA_Application_Sohrabi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Panel();
            this.rgisterImage = new System.Windows.Forms.PictureBox();
            this.reRegisterImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbRePass = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserNameRegister = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgisterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reRegisterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Silver;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbUserName.Location = new System.Drawing.Point(38, 38);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(185, 39);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.Silver;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbPass.Location = new System.Drawing.Point(77, 97);
            this.tbPass.MaxLength = 10;
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(146, 39);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            this.tbPass.Enter += new System.EventHandler(this.tbPass_Enter);
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            this.tbPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPass_MouseDown);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Controls.Add(this.linkLabel1);
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.pictureBox1);
            this.Login.Controls.Add(this.btnReset);
            this.Login.Controls.Add(this.btnSubmit);
            this.Login.Controls.Add(this.lblPass);
            this.Login.Controls.Add(this.tbPass);
            this.Login.Controls.Add(this.lblUserName);
            this.Login.Controls.Add(this.tbUserName);
            this.Login.Location = new System.Drawing.Point(198, 89);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(344, 251);
            this.Login.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(108, 226);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ثبت نام";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "هنوز ثبت نام نکردم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("B Bardiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(48, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 50);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "انصراف";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("B Bardiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(183, 157);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "ورود";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPass.Location = new System.Drawing.Point(229, 106);
            this.lblPass.Name = "lblPass";
            this.lblPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPass.Size = new System.Drawing.Size(66, 24);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "پسوورد :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.Location = new System.Drawing.Point(229, 47);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(86, 24);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "نام کاربری :";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.White;
            this.register.Controls.Add(this.rgisterImage);
            this.register.Controls.Add(this.reRegisterImage);
            this.register.Controls.Add(this.label6);
            this.register.Controls.Add(this.label5);
            this.register.Controls.Add(this.label4);
            this.register.Controls.Add(this.label3);
            this.register.Controls.Add(this.linkLabel2);
            this.register.Controls.Add(this.label2);
            this.register.Controls.Add(this.btnReset2);
            this.register.Controls.Add(this.btnRegister);
            this.register.Controls.Add(this.tbRePass);
            this.register.Controls.Add(this.tbPassword);
            this.register.Controls.Add(this.tbUserNameRegister);
            this.register.Controls.Add(this.tbName);
            this.register.Location = new System.Drawing.Point(186, 47);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(366, 385);
            this.register.TabIndex = 10;
            // 
            // rgisterImage
            // 
            this.rgisterImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rgisterImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rgisterImage.Image = ((System.Drawing.Image)(resources.GetObject("rgisterImage.Image")));
            this.rgisterImage.Location = new System.Drawing.Point(21, 145);
            this.rgisterImage.Name = "rgisterImage";
            this.rgisterImage.Size = new System.Drawing.Size(41, 39);
            this.rgisterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rgisterImage.TabIndex = 18;
            this.rgisterImage.TabStop = false;
            this.rgisterImage.Click += new System.EventHandler(this.rgisterImage_Click);
            // 
            // reRegisterImage
            // 
            this.reRegisterImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reRegisterImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reRegisterImage.Image = ((System.Drawing.Image)(resources.GetObject("reRegisterImage.Image")));
            this.reRegisterImage.Location = new System.Drawing.Point(21, 205);
            this.reRegisterImage.Name = "reRegisterImage";
            this.reRegisterImage.Size = new System.Drawing.Size(41, 39);
            this.reRegisterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reRegisterImage.TabIndex = 10;
            this.reRegisterImage.TabStop = false;
            this.reRegisterImage.Click += new System.EventHandler(this.reRegisterImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(248, 213);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "تکرار پسوورد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(248, 153);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "پسوورد :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(248, 32);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "نام واقعی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(248, 95);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "نام کاربری :";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(124, 353);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ورود";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "قبلا ثبت نام کرده ام";
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.Black;
            this.btnReset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset2.Font = new System.Drawing.Font("B Bardiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReset2.ForeColor = System.Drawing.Color.White;
            this.btnReset2.Location = new System.Drawing.Point(65, 268);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(98, 50);
            this.btnReset2.TabIndex = 15;
            this.btnReset2.Text = "انصراف";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            this.btnReset2.MouseEnter += new System.EventHandler(this.btnReset2_MouseEnter);
            this.btnReset2.MouseLeave += new System.EventHandler(this.btnReset2_MouseLeave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("B Bardiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(200, 268);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 50);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            // 
            // tbRePass
            // 
            this.tbRePass.BackColor = System.Drawing.Color.Silver;
            this.tbRePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbRePass.Location = new System.Drawing.Point(65, 205);
            this.tbRePass.MaxLength = 10;
            this.tbRePass.Multiline = true;
            this.tbRePass.Name = "tbRePass";
            this.tbRePass.PasswordChar = '*';
            this.tbRePass.Size = new System.Drawing.Size(157, 39);
            this.tbRePass.TabIndex = 13;
            this.tbRePass.TextChanged += new System.EventHandler(this.tbRePass_TextChanged);
            this.tbRePass.Enter += new System.EventHandler(this.tbRePass_Enter);
            this.tbRePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRePass_KeyDown);
            this.tbRePass.Leave += new System.EventHandler(this.tbRePass_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Silver;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbPassword.Location = new System.Drawing.Point(65, 145);
            this.tbPassword.MaxLength = 10;
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(157, 39);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            this.tbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseDown);
            // 
            // tbUserNameRegister
            // 
            this.tbUserNameRegister.BackColor = System.Drawing.Color.Silver;
            this.tbUserNameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbUserNameRegister.Location = new System.Drawing.Point(37, 84);
            this.tbUserNameRegister.Multiline = true;
            this.tbUserNameRegister.Name = "tbUserNameRegister";
            this.tbUserNameRegister.Size = new System.Drawing.Size(185, 39);
            this.tbUserNameRegister.TabIndex = 11;
            this.tbUserNameRegister.Enter += new System.EventHandler(this.tbUserNameRegister_Enter);
            this.tbUserNameRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserNameRegister_KeyDown);
            this.tbUserNameRegister.Leave += new System.EventHandler(this.tbUserNameRegister_Leave);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Silver;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbName.Location = new System.Drawing.Point(37, 24);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 39);
            this.tbName.TabIndex = 10;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(675, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(741, 583);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.register);
            this.Controls.Add(this.Login);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hossein Sohrabi";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.register.ResumeLayout(false);
            this.register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgisterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reRegisterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel register;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbRePass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserNameRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox rgisterImage;
        private System.Windows.Forms.PictureBox reRegisterImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

