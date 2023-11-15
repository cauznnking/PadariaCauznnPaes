namespace PadariaCauznnPaes.Views
{
    partial class GerenciamentoDeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoDeProduto));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrbCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.LblNomeDoProduto = new System.Windows.Forms.Label();
            this.CmbProduto = new System.Windows.Forms.ComboBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.CmbPreco = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrbCadastrarProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(102, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(647, 55);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "gerenciamento os produtos ";
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(56, 88);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(660, 222);
            this.DgvProdutos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GrbCadastrarProduto
            // 
            this.GrbCadastrarProduto.Controls.Add(this.CmbPreco);
            this.GrbCadastrarProduto.Controls.Add(this.LblPreco);
            this.GrbCadastrarProduto.Controls.Add(this.CmbProduto);
            this.GrbCadastrarProduto.Controls.Add(this.LblNomeDoProduto);
            this.GrbCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCadastrarProduto.ForeColor = System.Drawing.Color.MintCream;
            this.GrbCadastrarProduto.Location = new System.Drawing.Point(56, 333);
            this.GrbCadastrarProduto.Name = "GrbCadastrarProduto";
            this.GrbCadastrarProduto.Size = new System.Drawing.Size(280, 219);
            this.GrbCadastrarProduto.TabIndex = 3;
            this.GrbCadastrarProduto.TabStop = false;
            this.GrbCadastrarProduto.Text = "Cadastrar produto";
            // 
            // LblNomeDoProduto
            // 
            this.LblNomeDoProduto.AutoSize = true;
            this.LblNomeDoProduto.Location = new System.Drawing.Point(6, 47);
            this.LblNomeDoProduto.Name = "LblNomeDoProduto";
            this.LblNomeDoProduto.Size = new System.Drawing.Size(113, 16);
            this.LblNomeDoProduto.TabIndex = 0;
            this.LblNomeDoProduto.Text = "Nome do Produto";
            // 
            // CmbProduto
            // 
            this.CmbProduto.FormattingEnabled = true;
            this.CmbProduto.Location = new System.Drawing.Point(125, 44);
            this.CmbProduto.Name = "CmbProduto";
            this.CmbProduto.Size = new System.Drawing.Size(121, 24);
            this.CmbProduto.TabIndex = 1;
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Location = new System.Drawing.Point(76, 82);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(43, 16);
            this.LblPreco.TabIndex = 2;
            this.LblPreco.Text = "Preço";
            // 
            // CmbPreco
            // 
            this.CmbPreco.FormattingEnabled = true;
            this.CmbPreco.Location = new System.Drawing.Point(125, 79);
            this.CmbPreco.Name = "CmbPreco";
            this.CmbPreco.Size = new System.Drawing.Size(121, 24);
            this.CmbPreco.TabIndex = 3;
            this.CmbPreco.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // GerenciamentoDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(761, 618);
            this.Controls.Add(this.GrbCadastrarProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.LblTitulo);
            this.Name = "GerenciamentoDeProduto";
            this.Text = "Gerenciamento Dos Produtos ";
            this.Load += new System.EventHandler(this.GerenciamentoDeProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrbCadastrarProduto.ResumeLayout(false);
            this.GrbCadastrarProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GrbCadastrarProduto;
        private System.Windows.Forms.ComboBox CmbPreco;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.ComboBox CmbProduto;
        private System.Windows.Forms.Label LblNomeDoProduto;
    }
}