namespace Csharp_Library_Management_System
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
            this.text_User_Name = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBoxYoutube = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxInstageam = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstageam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_User_Name
            // 
            this.text_User_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.text_User_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_User_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_User_Name.ForeColor = System.Drawing.Color.White;
            this.text_User_Name.Location = new System.Drawing.Point(105, 216);
            this.text_User_Name.Name = "text_User_Name";
            this.text_User_Name.Size = new System.Drawing.Size(183, 25);
            this.text_User_Name.TabIndex = 1;
            this.text_User_Name.Text = "User Name";
            this.text_User_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_User_Name_MouseClick_1);
            this.text_User_Name.TextChanged += new System.EventHandler(this.text_User_Name_TextChanged);
            this.text_User_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.text_User_Name_MouseDown);
            this.text_User_Name.MouseEnter += new System.EventHandler(this.text_User_Name_MouseEnter);
            // 
            // text_Password
            // 
            this.text_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.text_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Password.ForeColor = System.Drawing.Color.White;
            this.text_Password.Location = new System.Drawing.Point(105, 263);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(183, 25);
            this.text_Password.TabIndex = 2;
            this.text_Password.Text = "Password";
            this.text_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_Password_MouseClick_1);
            this.text_Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.text_Password.MouseEnter += new System.EventHandler(this.text_Password_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(105, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(105, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 2);
            this.panel2.TabIndex = 6;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(61, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.Cyan;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.Location = new System.Drawing.Point(61, 404);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(227, 40);
            this.buttonSignup.TabIndex = 8;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Silver;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.Red;
            this.button_Close.Location = new System.Drawing.Point(353, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(24, 28);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBoxYoutube
            // 
            this.pictureBoxYoutube.Image = global::Csharp_Library_Management_System.Properties.Resources.download__3__removebg_preview;
            this.pictureBoxYoutube.Location = new System.Drawing.Point(200, 498);
            this.pictureBoxYoutube.Name = "pictureBoxYoutube";
            this.pictureBoxYoutube.Size = new System.Drawing.Size(72, 60);
            this.pictureBoxYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYoutube.TabIndex = 12;
            this.pictureBoxYoutube.TabStop = false;
            this.pictureBoxYoutube.Click += new System.EventHandler(this.pictureBoxYoutube_Click);
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = global::Csharp_Library_Management_System.Properties.Resources.images_removebg_preview;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(130, 498);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(77, 60);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 11;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // pictureBoxInstageam
            // 
            this.pictureBoxInstageam.Image = global::Csharp_Library_Management_System.Properties.Resources.images_removebg_preview__1_;
            this.pictureBoxInstageam.Location = new System.Drawing.Point(72, 510);
            this.pictureBoxInstageam.Name = "pictureBoxInstageam";
            this.pictureBoxInstageam.Size = new System.Drawing.Size(63, 38);
            this.pictureBoxInstageam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInstageam.TabIndex = 10;
            this.pictureBoxInstageam.TabStop = false;
            this.pictureBoxInstageam.Click += new System.EventHandler(this.pictureBoxInstageam_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Csharp_Library_Management_System.Properties.Resources.download__1_;
            this.pictureBox3.Location = new System.Drawing.Point(61, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csharp_Library_Management_System.Properties.Resources.download__2_;
            this.pictureBox2.Location = new System.Drawing.Point(61, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csharp_Library_Management_System.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(123, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(380, 615);
            this.Controls.Add(this.pictureBoxYoutube);
            this.Controls.Add(this.pictureBoxFacebook);
            this.Controls.Add(this.pictureBoxInstageam);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.text_User_Name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstageam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_User_Name;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBoxInstageam;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxYoutube;
    }
}

