namespace TelaLogin
{
    partial class Login
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
            this.loginBut = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrarBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBut
            // 
            this.loginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBut.Location = new System.Drawing.Point(73, 168);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(348, 44);
            this.loginBut.TabIndex = 0;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(40, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(74, 24);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuário";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(44, 51);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(405, 29);
            this.usernameBox.TabIndex = 2;
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(40, 96);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(65, 24);
            this.userPassword.TabIndex = 3;
            this.userPassword.Text = "Senha";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(44, 123);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(405, 29);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não tem Login?";
            // 
            // cadastrarBut
            // 
            this.cadastrarBut.Location = new System.Drawing.Point(248, 226);
            this.cadastrarBut.Name = "cadastrarBut";
            this.cadastrarBut.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBut.TabIndex = 6;
            this.cadastrarBut.Text = "Cadastre-se";
            this.cadastrarBut.UseVisualStyleBackColor = true;
            this.cadastrarBut.Click += new System.EventHandler(this.cadastrarBut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.cadastrarBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.loginBut);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cadastrarBut;
    }
}

