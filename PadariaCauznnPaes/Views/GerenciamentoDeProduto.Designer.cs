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
            this.TxbPreco = new System.Windows.Forms.TextBox();
            this.TxbNomeProduto = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblNomeDoProduto = new System.Windows.Forms.Label();
            this.GrbEditarProdutos = new System.Windows.Forms.GroupBox();
            this.TxbPrecoEdit = new System.Windows.Forms.TextBox();
            this.TxbNomeEdit = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.CmbCategoriaEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrbApagarProduto = new System.Windows.Forms.GroupBox();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.LblDoApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrbCadastrarProduto.SuspendLayout();
            this.GrbEditarProdutos.SuspendLayout();
            this.GrbApagarProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(93, 19);
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
            this.DgvProdutos.Size = new System.Drawing.Size(660, 239);
            this.DgvProdutos.TabIndex = 1;
            this.DgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GrbCadastrarProduto
            // 
            this.GrbCadastrarProduto.Controls.Add(this.TxbPreco);
            this.GrbCadastrarProduto.Controls.Add(this.TxbNomeProduto);
            this.GrbCadastrarProduto.Controls.Add(this.BtnCadastrar);
            this.GrbCadastrarProduto.Controls.Add(this.CmbCategoria);
            this.GrbCadastrarProduto.Controls.Add(this.LblCategoria);
            this.GrbCadastrarProduto.Controls.Add(this.LblPreco);
            this.GrbCadastrarProduto.Controls.Add(this.LblNomeDoProduto);
            this.GrbCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCadastrarProduto.ForeColor = System.Drawing.Color.MintCream;
            this.GrbCadastrarProduto.Location = new System.Drawing.Point(56, 333);
            this.GrbCadastrarProduto.Name = "GrbCadastrarProduto";
            this.GrbCadastrarProduto.Size = new System.Drawing.Size(311, 219);
            this.GrbCadastrarProduto.TabIndex = 3;
            this.GrbCadastrarProduto.TabStop = false;
            this.GrbCadastrarProduto.Text = "Cadastrar Produtos";
            // 
            // TxbPreco
            // 
            this.TxbPreco.Location = new System.Drawing.Point(126, 82);
            this.TxbPreco.Name = "TxbPreco";
            this.TxbPreco.Size = new System.Drawing.Size(120, 22);
            this.TxbPreco.TabIndex = 8;
            // 
            // TxbNomeProduto
            // 
            this.TxbNomeProduto.Location = new System.Drawing.Point(126, 47);
            this.TxbNomeProduto.Name = "TxbNomeProduto";
            this.TxbNomeProduto.Size = new System.Drawing.Size(120, 22);
            this.TxbNomeProduto.TabIndex = 7;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Green;
            this.BtnCadastrar.Location = new System.Drawing.Point(32, 160);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(237, 44);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(125, 114);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.CmbCategoria.TabIndex = 5;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(53, 117);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(66, 16);
            this.LblCategoria.TabIndex = 4;
            this.LblCategoria.Text = "Categoria";
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
            // LblNomeDoProduto
            // 
            this.LblNomeDoProduto.AutoSize = true;
            this.LblNomeDoProduto.Location = new System.Drawing.Point(6, 47);
            this.LblNomeDoProduto.Name = "LblNomeDoProduto";
            this.LblNomeDoProduto.Size = new System.Drawing.Size(113, 16);
            this.LblNomeDoProduto.TabIndex = 0;
            this.LblNomeDoProduto.Text = "Nome do Produto";
            // 
            // GrbEditarProdutos
            // 
            this.GrbEditarProdutos.Controls.Add(this.TxbPrecoEdit);
            this.GrbEditarProdutos.Controls.Add(this.TxbNomeEdit);
            this.GrbEditarProdutos.Controls.Add(this.BtnEditar);
            this.GrbEditarProdutos.Controls.Add(this.CmbCategoriaEdit);
            this.GrbEditarProdutos.Controls.Add(this.label1);
            this.GrbEditarProdutos.Controls.Add(this.label2);
            this.GrbEditarProdutos.Controls.Add(this.label3);
            this.GrbEditarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEditarProdutos.ForeColor = System.Drawing.Color.MintCream;
            this.GrbEditarProdutos.Location = new System.Drawing.Point(390, 333);
            this.GrbEditarProdutos.Name = "GrbEditarProdutos";
            this.GrbEditarProdutos.Size = new System.Drawing.Size(326, 219);
            this.GrbEditarProdutos.TabIndex = 9;
            this.GrbEditarProdutos.TabStop = false;
            this.GrbEditarProdutos.Text = "Editar Produtos";
            // 
            // TxbPrecoEdit
            // 
            this.TxbPrecoEdit.Location = new System.Drawing.Point(140, 82);
            this.TxbPrecoEdit.Name = "TxbPrecoEdit";
            this.TxbPrecoEdit.Size = new System.Drawing.Size(120, 22);
            this.TxbPrecoEdit.TabIndex = 8;
            // 
            // TxbNomeEdit
            // 
            this.TxbNomeEdit.Location = new System.Drawing.Point(140, 47);
            this.TxbNomeEdit.Name = "TxbNomeEdit";
            this.TxbNomeEdit.Size = new System.Drawing.Size(120, 22);
            this.TxbNomeEdit.TabIndex = 7;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEditar.Location = new System.Drawing.Point(32, 160);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(256, 44);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // CmbCategoriaEdit
            // 
            this.CmbCategoriaEdit.FormattingEnabled = true;
            this.CmbCategoriaEdit.Location = new System.Drawing.Point(140, 114);
            this.CmbCategoriaEdit.Name = "CmbCategoriaEdit";
            this.CmbCategoriaEdit.Size = new System.Drawing.Size(121, 24);
            this.CmbCategoriaEdit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Produto";
            // 
            // GrbApagarProduto
            // 
            this.GrbApagarProduto.Controls.Add(this.BtnApagar);
            this.GrbApagarProduto.Controls.Add(this.LblDoApagar);
            this.GrbApagarProduto.Enabled = false;
            this.GrbApagarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbApagarProduto.ForeColor = System.Drawing.Color.Red;
            this.GrbApagarProduto.Location = new System.Drawing.Point(168, 558);
            this.GrbApagarProduto.Name = "GrbApagarProduto";
            this.GrbApagarProduto.Size = new System.Drawing.Size(421, 70);
            this.GrbApagarProduto.TabIndex = 10;
            this.GrbApagarProduto.TabStop = false;
            this.GrbApagarProduto.Text = "Apagar";
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.Red;
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnApagar.ForeColor = System.Drawing.Color.White;
            this.BtnApagar.Location = new System.Drawing.Point(274, 21);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(141, 38);
            this.BtnApagar.TabIndex = 1;
            this.BtnApagar.Text = "apagar";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // LblDoApagar
            // 
            this.LblDoApagar.AutoSize = true;
            this.LblDoApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoApagar.ForeColor = System.Drawing.Color.White;
            this.LblDoApagar.Location = new System.Drawing.Point(6, 30);
            this.LblDoApagar.Name = "LblDoApagar";
            this.LblDoApagar.Size = new System.Drawing.Size(273, 20);
            this.LblDoApagar.TabIndex = 0;
            this.LblDoApagar.Text = "Selecione o Produto para apagar";
            // 
            // GerenciamentoDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(761, 650);
            this.Controls.Add(this.GrbApagarProduto);
            this.Controls.Add(this.GrbEditarProdutos);
            this.Controls.Add(this.GrbCadastrarProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.LblTitulo);
            this.Name = "GerenciamentoDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento Dos Produtos ";
            this.Load += new System.EventHandler(this.GerenciamentoDeProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrbCadastrarProduto.ResumeLayout(false);
            this.GrbCadastrarProduto.PerformLayout();
            this.GrbEditarProdutos.ResumeLayout(false);
            this.GrbEditarProdutos.PerformLayout();
            this.GrbApagarProduto.ResumeLayout(false);
            this.GrbApagarProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GrbCadastrarProduto;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblNomeDoProduto;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxbPreco;
        private System.Windows.Forms.TextBox TxbNomeProduto;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.GroupBox GrbEditarProdutos;
        private System.Windows.Forms.TextBox TxbPrecoEdit;
        private System.Windows.Forms.TextBox TxbNomeEdit;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.ComboBox CmbCategoriaEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrbApagarProduto;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label LblDoApagar;
    }
}