namespace QuanLyQuanCafe
{
    partial class fLogIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPassWord = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlUseName = new System.Windows.Forms.Panel();
            this.txbUseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlPassWord.SuspendLayout();
            this.pnlUseName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pnlPassWord);
            this.panel1.Controls.Add(this.pnlUseName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 260);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowDrop = true;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(341, 181);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 41);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(483, 182);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlPassWord
            // 
            this.pnlPassWord.Controls.Add(this.txbPassWord);
            this.pnlPassWord.Controls.Add(this.label3);
            this.pnlPassWord.Location = new System.Drawing.Point(39, 117);
            this.pnlPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPassWord.Name = "pnlPassWord";
            this.pnlPassWord.Size = new System.Drawing.Size(594, 56);
            this.pnlPassWord.TabIndex = 2;
            // 
            // txbPassWord
            // 
            this.txbPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassWord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.ForeColor = System.Drawing.Color.Black;
            this.txbPassWord.Location = new System.Drawing.Point(136, 24);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(433, 23);
            this.txbPassWord.TabIndex = 2;
            this.txbPassWord.UseSystemPasswordChar = true;
            this.txbPassWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlUseName
            // 
            this.pnlUseName.Controls.Add(this.txbUseName);
            this.pnlUseName.Controls.Add(this.label2);
            this.pnlUseName.Location = new System.Drawing.Point(39, 63);
            this.pnlUseName.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUseName.Name = "pnlUseName";
            this.pnlUseName.Size = new System.Drawing.Size(594, 46);
            this.pnlUseName.TabIndex = 1;
            // 
            // txbUseName
            // 
            this.txbUseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbUseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUseName.ForeColor = System.Drawing.Color.Black;
            this.txbUseName.Location = new System.Drawing.Point(136, 18);
            this.txbUseName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUseName.Name = "txbUseName";
            this.txbUseName.Size = new System.Drawing.Size(433, 23);
            this.txbUseName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fLogIn
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(634, 265);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogIn_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPassWord.ResumeLayout(false);
            this.pnlPassWord.PerformLayout();
            this.pnlUseName.ResumeLayout(false);
            this.pnlUseName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUseName;
        private System.Windows.Forms.TextBox txbUseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPassWord;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

