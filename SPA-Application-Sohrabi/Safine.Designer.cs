namespace SPA_Application_Sohrabi
{
    partial class Safine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Safine));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picSafine = new System.Windows.Forms.PictureBox();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSafine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(2, 1);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(1325, 609);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(429, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start / Stop";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picSafine
            // 
            this.picSafine.BackColor = System.Drawing.Color.Transparent;
            this.picSafine.Image = ((System.Drawing.Image)(resources.GetObject("picSafine.Image")));
            this.picSafine.Location = new System.Drawing.Point(482, 296);
            this.picSafine.Name = "picSafine";
            this.picSafine.Size = new System.Drawing.Size(100, 70);
            this.picSafine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSafine.TabIndex = 2;
            this.picSafine.TabStop = false;
            // 
            // picBottom
            // 
            this.picBottom.Image = ((System.Drawing.Image)(resources.GetObject("picBottom.Image")));
            this.picBottom.Location = new System.Drawing.Point(-34, 443);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(1158, 167);
            this.picBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBottom.TabIndex = 3;
            this.picBottom.TabStop = false;
            // 
            // picTop
            // 
            this.picTop.Image = ((System.Drawing.Image)(resources.GetObject("picTop.Image")));
            this.picTop.Location = new System.Drawing.Point(2, 1);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(1114, 232);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTop.TabIndex = 3;
            this.picTop.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.time.Location = new System.Drawing.Point(114, 7);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(24, 25);
            this.time.TabIndex = 4;
            this.time.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(169, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "زمان :";
            // 
            // Safine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 610);
            this.Controls.Add(this.picSafine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picBottom);
            this.Controls.Add(this.picBack);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Safine";
            this.Text = "Safine";
            this.Load += new System.EventHandler(this.Safine_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Safine_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Safine_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSafine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picSafine;
        private System.Windows.Forms.PictureBox picBottom;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
    }
}