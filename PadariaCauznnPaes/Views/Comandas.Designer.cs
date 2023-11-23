namespace PadariaCauznnPaes.Views
{
    partial class Comandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandas));
            this.GrbInformacoes = new System.Windows.Forms.GroupBox();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.TxbProduto = new System.Windows.Forms.TextBox();
            this.LblCodProduto = new System.Windows.Forms.Label();
            this.TxbComanda = new System.Windows.Forms.TextBox();
            this.LblCoamanda = new System.Windows.Forms.Label();
            this.GrbLancamento = new System.Windows.Forms.GroupBox();
            this.BtnLancar = new System.Windows.Forms.Button();
            this.TxbQuantidade = new System.Windows.Forms.TextBox();
            this.LblPodutoLancar = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.TxbProdutoLancar = new System.Windows.Forms.TextBox();
            this.DgvComanda = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblFoto = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GrbInformacoes.SuspendLayout();
            this.GrbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbInformacoes
            // 
            this.GrbInformacoes.Controls.Add(this.BtnContinuar);
            this.GrbInformacoes.Controls.Add(this.TxbProduto);
            this.GrbInformacoes.Controls.Add(this.LblCodProduto);
            this.GrbInformacoes.Controls.Add(this.TxbComanda);
            this.GrbInformacoes.Controls.Add(this.LblCoamanda);
            this.GrbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbInformacoes.ForeColor = System.Drawing.SystemColors.Window;
            this.GrbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.GrbInformacoes.Name = "GrbInformacoes";
            this.GrbInformacoes.Size = new System.Drawing.Size(303, 239);
            this.GrbInformacoes.TabIndex = 0;
            this.GrbInformacoes.TabStop = false;
            this.GrbInformacoes.Text = "Informações";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnContinuar.Location = new System.Drawing.Point(77, 177);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(157, 47);
            this.BtnContinuar.TabIndex = 4;
            this.BtnContinuar.Text = "CONTINUAR";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // TxbProduto
            // 
            this.TxbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbProduto.Location = new System.Drawing.Point(126, 109);
            this.TxbProduto.Name = "TxbProduto";
            this.TxbProduto.Size = new System.Drawing.Size(133, 26);
            this.TxbProduto.TabIndex = 3;
            // 
            // LblCodProduto
            // 
            this.LblCodProduto.AutoSize = true;
            this.LblCodProduto.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProduto.Location = new System.Drawing.Point(20, 113);
            this.LblCodProduto.Name = "LblCodProduto";
            this.LblCodProduto.Size = new System.Drawing.Size(99, 19);
            this.LblCodProduto.TabIndex = 2;
            this.LblCodProduto.Text = "CodProd :";
            // 
            // TxbComanda
            // 
            this.TxbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbComanda.Location = new System.Drawing.Point(126, 49);
            this.TxbComanda.Name = "TxbComanda";
            this.TxbComanda.Size = new System.Drawing.Size(133, 26);
            this.TxbComanda.TabIndex = 1;
            // 
            // LblCoamanda
            // 
            this.LblCoamanda.AutoSize = true;
            this.LblCoamanda.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCoamanda.Location = new System.Drawing.Point(20, 53);
            this.LblCoamanda.Name = "LblCoamanda";
            this.LblCoamanda.Size = new System.Drawing.Size(99, 19);
            this.LblCoamanda.TabIndex = 0;
            this.LblCoamanda.Text = "Comanda :";
            // 
            // GrbLancamento
            // 
            this.GrbLancamento.Controls.Add(this.BtnCancelar);
            this.GrbLancamento.Controls.Add(this.BtnLancar);
            this.GrbLancamento.Controls.Add(this.TxbQuantidade);
            this.GrbLancamento.Controls.Add(this.LblPodutoLancar);
            this.GrbLancamento.Controls.Add(this.LblQuantidade);
            this.GrbLancamento.Controls.Add(this.TxbProdutoLancar);
            this.GrbLancamento.Enabled = false;
            this.GrbLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbLancamento.ForeColor = System.Drawing.SystemColors.Window;
            this.GrbLancamento.Location = new System.Drawing.Point(12, 271);
            this.GrbLancamento.Name = "GrbLancamento";
            this.GrbLancamento.Size = new System.Drawing.Size(303, 239);
            this.GrbLancamento.TabIndex = 1;
            this.GrbLancamento.TabStop = false;
            this.GrbLancamento.Text = "Lançamento";
            // 
            // BtnLancar
            // 
            this.BtnLancar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnLancar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnLancar.Location = new System.Drawing.Point(24, 165);
            this.BtnLancar.Name = "BtnLancar";
            this.BtnLancar.Size = new System.Drawing.Size(115, 54);
            this.BtnLancar.TabIndex = 9;
            this.BtnLancar.Text = "LANÇAR";
            this.BtnLancar.UseVisualStyleBackColor = false;
            this.BtnLancar.Click += new System.EventHandler(this.BtnLancar_Click);
            // 
            // TxbQuantidade
            // 
            this.TxbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbQuantidade.Location = new System.Drawing.Point(126, 101);
            this.TxbQuantidade.Name = "TxbQuantidade";
            this.TxbQuantidade.Size = new System.Drawing.Size(133, 26);
            this.TxbQuantidade.TabIndex = 8;
            // 
            // LblPodutoLancar
            // 
            this.LblPodutoLancar.AutoSize = true;
            this.LblPodutoLancar.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPodutoLancar.Location = new System.Drawing.Point(20, 45);
            this.LblPodutoLancar.Name = "LblPodutoLancar";
            this.LblPodutoLancar.Size = new System.Drawing.Size(99, 19);
            this.LblPodutoLancar.TabIndex = 5;
            this.LblPodutoLancar.Text = "PRODUTO :";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidade.Location = new System.Drawing.Point(16, 107);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(103, 16);
            this.LblQuantidade.TabIndex = 7;
            this.LblQuantidade.Text = "QUANTIDADE :";
            // 
            // TxbProdutoLancar
            // 
            this.TxbProdutoLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbProdutoLancar.Location = new System.Drawing.Point(126, 41);
            this.TxbProdutoLancar.Name = "TxbProdutoLancar";
            this.TxbProdutoLancar.ReadOnly = true;
            this.TxbProdutoLancar.Size = new System.Drawing.Size(133, 26);
            this.TxbProdutoLancar.TabIndex = 6;
            // 
            // DgvComanda
            // 
            this.DgvComanda.AllowUserToAddRows = false;
            this.DgvComanda.AllowUserToDeleteRows = false;
            this.DgvComanda.AllowUserToResizeColumns = false;
            this.DgvComanda.AllowUserToResizeRows = false;
            this.DgvComanda.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.DgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComanda.Location = new System.Drawing.Point(353, 12);
            this.DgvComanda.Name = "DgvComanda";
            this.DgvComanda.Size = new System.Drawing.Size(571, 580);
            this.DgvComanda.TabIndex = 2;
            this.DgvComanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComanda_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 516);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoto.ForeColor = System.Drawing.Color.White;
            this.LblFoto.Location = new System.Drawing.Point(118, 527);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(219, 22);
            this.LblFoto.TabIndex = 4;
            this.LblFoto.Text = "Comanda da Padaria ";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(156, 165);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(124, 54);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(936, 618);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DgvComanda);
            this.Controls.Add(this.GrbLancamento);
            this.Controls.Add(this.GrbInformacoes);
            this.Name = "Comandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            this.GrbInformacoes.ResumeLayout(false);
            this.GrbInformacoes.PerformLayout();
            this.GrbLancamento.ResumeLayout(false);
            this.GrbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbInformacoes;
        private System.Windows.Forms.GroupBox GrbLancamento;
        private System.Windows.Forms.Label LblCoamanda;
        private System.Windows.Forms.DataGridView DgvComanda;
        private System.Windows.Forms.TextBox TxbProduto;
        private System.Windows.Forms.Label LblCodProduto;
        private System.Windows.Forms.TextBox TxbComanda;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Button BtnLancar;
        private System.Windows.Forms.TextBox TxbQuantidade;
        private System.Windows.Forms.Label LblPodutoLancar;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.TextBox TxbProdutoLancar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.Button BtnCancelar;
    }
}