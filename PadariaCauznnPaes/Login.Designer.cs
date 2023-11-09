namespace PadariaCauznnPaes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Login: padaria Cauznn Pães";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(61, 116);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(49, 18);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email";
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(122, 115);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(152, 20);
            this.TxbEmail.TabIndex = 2;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Location = new System.Drawing.Point(122, 154);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.PasswordChar = '•';
            this.TxbSenha.Size = new System.Drawing.Size(152, 20);
            this.TxbSenha.TabIndex = 3;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(61, 154);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(54, 18);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(122, 199);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(152, 38);
            this.BtnEntrar.TabIndex = 5;
            this.BtnEntrar.Text = "ENTRAR";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 266);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button BtnEntrar;
    }
}