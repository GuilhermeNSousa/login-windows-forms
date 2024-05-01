namespace TelaLogin
{
    partial class Painel
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
            this.voltarBut = new System.Windows.Forms.Button();
            this.funcionariosGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // voltarBut
            // 
            this.voltarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarBut.Location = new System.Drawing.Point(86, 200);
            this.voltarBut.Name = "voltarBut";
            this.voltarBut.Size = new System.Drawing.Size(319, 52);
            this.voltarBut.TabIndex = 1;
            this.voltarBut.Text = "Voltar";
            this.voltarBut.UseVisualStyleBackColor = true;
            this.voltarBut.Click += new System.EventHandler(this.voltarBut_Click);
            // 
            // funcionariosGrid
            // 
            this.funcionariosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionariosGrid.Location = new System.Drawing.Point(27, 23);
            this.funcionariosGrid.Name = "funcionariosGrid";
            this.funcionariosGrid.Size = new System.Drawing.Size(446, 150);
            this.funcionariosGrid.TabIndex = 2;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.funcionariosGrid);
            this.Controls.Add(this.voltarBut);
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Painel_FormClosed);
            this.Load += new System.EventHandler(this.Painel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltarBut;
        private System.Windows.Forms.DataGridView funcionariosGrid;
    }
}