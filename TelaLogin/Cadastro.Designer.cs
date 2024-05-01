namespace TelaLogin
{
    partial class Cadastro
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.cadastrarBut = new System.Windows.Forms.Button();
            this.voltarBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(45, 125);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(405, 29);
            this.passwordBox.TabIndex = 9;
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(41, 98);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(65, 24);
            this.userPassword.TabIndex = 8;
            this.userPassword.Text = "Senha";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(45, 53);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(405, 29);
            this.usernameBox.TabIndex = 7;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(41, 26);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(74, 24);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "Usuário";
            // 
            // cadastrarBut
            // 
            this.cadastrarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBut.Location = new System.Drawing.Point(55, 169);
            this.cadastrarBut.Name = "cadastrarBut";
            this.cadastrarBut.Size = new System.Drawing.Size(189, 44);
            this.cadastrarBut.TabIndex = 5;
            this.cadastrarBut.Text = "Cadastrar";
            this.cadastrarBut.UseVisualStyleBackColor = true;
            this.cadastrarBut.Click += new System.EventHandler(this.cadastrarBut_Click);
            // 
            // voltarBut
            // 
            this.voltarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarBut.Location = new System.Drawing.Point(250, 169);
            this.voltarBut.Name = "voltarBut";
            this.voltarBut.Size = new System.Drawing.Size(189, 44);
            this.voltarBut.TabIndex = 10;
            this.voltarBut.Text = "Voltar";
            this.voltarBut.UseVisualStyleBackColor = true;
            this.voltarBut.Click += new System.EventHandler(this.voltarBut_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.voltarBut);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.cadastrarBut);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button cadastrarBut;
        private System.Windows.Forms.Button voltarBut;
    }
}