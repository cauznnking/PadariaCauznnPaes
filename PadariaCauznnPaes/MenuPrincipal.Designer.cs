namespace PadariaCauznnPaes
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.LblTituloMenu = new System.Windows.Forms.Label();
            this.LblApresentacao = new System.Windows.Forms.Label();
            this.BtnComanda = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloMenu
            // 
            this.LblTituloMenu.AutoSize = true;
            this.LblTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMenu.ForeColor = System.Drawing.Color.Transparent;
            this.LblTituloMenu.Location = new System.Drawing.Point(12, 9);
            this.LblTituloMenu.Name = "LblTituloMenu";
            this.LblTituloMenu.Size = new System.Drawing.Size(461, 31);
            this.LblTituloMenu.TabIndex = 0;
            this.LblTituloMenu.Text = "Bem vindo a Padaria Cauznn pães";
            // 
            // LblApresentacao
            // 
            this.LblApresentacao.AutoSize = true;
            this.LblApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApresentacao.ForeColor = System.Drawing.Color.Transparent;
            this.LblApresentacao.Location = new System.Drawing.Point(65, 54);
            this.LblApresentacao.Name = "LblApresentacao";
            this.LblApresentacao.Size = new System.Drawing.Size(374, 20);
            this.LblApresentacao.TabIndex = 1;
            this.LblApresentacao.Text = "Ola (Nome) ! Por favor escolha alguma opção abaxo";
            // 
            // BtnComanda
            // 
            this.BtnComanda.BackColor = System.Drawing.Color.Black;
            this.BtnComanda.ForeColor = System.Drawing.Color.White;
            this.BtnComanda.Location = new System.Drawing.Point(78, 97);
            this.BtnComanda.Name = "BtnComanda";
            this.BtnComanda.Size = new System.Drawing.Size(172, 56);
            this.BtnComanda.TabIndex = 2;
            this.BtnComanda.Text = "COMANDA";
            this.BtnComanda.UseVisualStyleBackColor = false;
            this.BtnComanda.Click += new System.EventHandler(this.BtnComanda_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnProdutos.ForeColor = System.Drawing.Color.Azure;
            this.BtnProdutos.Location = new System.Drawing.Point(256, 97);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(173, 56);
            this.BtnProdutos.TabIndex = 3;
            this.BtnProdutos.Text = "PRODUTOS";
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCaixa.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCaixa.Location = new System.Drawing.Point(78, 169);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(351, 56);
            this.BtnCaixa.TabIndex = 4;
            this.BtnCaixa.Text = "CAIXA";
            this.BtnCaixa.UseVisualStyleBackColor = false;
            this.BtnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.BtnUsuario.Location = new System.Drawing.Point(78, 231);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(351, 56);
            this.BtnUsuario.TabIndex = 5;
            this.BtnUsuario.Text = "USUÁRIOS";
            this.BtnUsuario.UseVisualStyleBackColor = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(490, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnUsuario);
            this.Controls.Add(this.BtnCaixa);
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.BtnComanda);
            this.Controls.Add(this.LblApresentacao);
            this.Controls.Add(this.LblTituloMenu);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloMenu;
        private System.Windows.Forms.Label LblApresentacao;
        private System.Windows.Forms.Button BtnComanda;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnCaixa;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}