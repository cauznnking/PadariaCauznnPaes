namespace PadariaCauznnPaes.Views
{
    partial class GerenciamentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoCaixa));
            this.LblNumeroDaComanda = new System.Windows.Forms.Label();
            this.DgvFicha = new System.Windows.Forms.DataGridView();
            this.TxbNumeroDaComanda = new System.Windows.Forms.TextBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.ChbPagamento = new System.Windows.Forms.CheckBox();
            this.BtnEncerrarComada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblCaixa = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumeroDaComanda
            // 
            this.LblNumeroDaComanda.AutoSize = true;
            this.LblNumeroDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroDaComanda.Location = new System.Drawing.Point(171, 39);
            this.LblNumeroDaComanda.Name = "LblNumeroDaComanda";
            this.LblNumeroDaComanda.Size = new System.Drawing.Size(297, 42);
            this.LblNumeroDaComanda.TabIndex = 0;
            this.LblNumeroDaComanda.Text = "N° da Comanda";
            // 
            // DgvFicha
            // 
            this.DgvFicha.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.DgvFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFicha.Location = new System.Drawing.Point(12, 95);
            this.DgvFicha.Name = "DgvFicha";
            this.DgvFicha.Size = new System.Drawing.Size(811, 342);
            this.DgvFicha.TabIndex = 1;
            // 
            // TxbNumeroDaComanda
            // 
            this.TxbNumeroDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNumeroDaComanda.Location = new System.Drawing.Point(488, 36);
            this.TxbNumeroDaComanda.Name = "TxbNumeroDaComanda";
            this.TxbNumeroDaComanda.Size = new System.Drawing.Size(100, 49);
            this.TxbNumeroDaComanda.TabIndex = 2;
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.MediumBlue;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListar.ForeColor = System.Drawing.Color.White;
            this.BtnListar.Location = new System.Drawing.Point(594, 36);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(120, 49);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "LISTAR";
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // ChbPagamento
            // 
            this.ChbPagamento.AutoSize = true;
            this.ChbPagamento.Location = new System.Drawing.Point(668, 525);
            this.ChbPagamento.Name = "ChbPagamento";
            this.ChbPagamento.Size = new System.Drawing.Size(129, 17);
            this.ChbPagamento.TabIndex = 4;
            this.ChbPagamento.Text = "Pagamento Recebido";
            this.ChbPagamento.UseVisualStyleBackColor = true;
            this.ChbPagamento.CheckedChanged += new System.EventHandler(this.ChbPagamento_CheckedChanged);
            // 
            // BtnEncerrarComada
            // 
            this.BtnEncerrarComada.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnEncerrarComada.Enabled = false;
            this.BtnEncerrarComada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncerrarComada.ForeColor = System.Drawing.Color.White;
            this.BtnEncerrarComada.Location = new System.Drawing.Point(657, 548);
            this.BtnEncerrarComada.Name = "BtnEncerrarComada";
            this.BtnEncerrarComada.Size = new System.Drawing.Size(152, 52);
            this.BtnEncerrarComada.TabIndex = 5;
            this.BtnEncerrarComada.Text = "Encerrar Comanda";
            this.BtnEncerrarComada.UseVisualStyleBackColor = false;
            this.BtnEncerrarComada.Click += new System.EventHandler(this.BtnEncerrarComada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(677, 474);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(80, 33);
            this.LblTotal.TabIndex = 7;
            this.LblTotal.Text = "R$ 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(783, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LblCaixa
            // 
            this.LblCaixa.AutoSize = true;
            this.LblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaixa.ForeColor = System.Drawing.Color.Black;
            this.LblCaixa.Location = new System.Drawing.Point(12, 535);
            this.LblCaixa.Name = "LblCaixa";
            this.LblCaixa.Size = new System.Drawing.Size(485, 39);
            this.LblCaixa.TabIndex = 10;
            this.LblCaixa.Text = "CAIXA :: PADARIA CAUZNN";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(513, 516);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // GerenciamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(835, 612);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblCaixa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEncerrarComada);
            this.Controls.Add(this.ChbPagamento);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.TxbNumeroDaComanda);
            this.Controls.Add(this.DgvFicha);
            this.Controls.Add(this.LblNumeroDaComanda);
            this.Name = "GerenciamentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA";
            this.Load += new System.EventHandler(this.GerenciamentoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeroDaComanda;
        private System.Windows.Forms.DataGridView DgvFicha;
        private System.Windows.Forms.TextBox TxbNumeroDaComanda;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.CheckBox ChbPagamento;
        private System.Windows.Forms.Button BtnEncerrarComada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblCaixa;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}