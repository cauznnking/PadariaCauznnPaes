namespace PadariaCauznnPaes.Views
{
    partial class GerenciamentoUsuarios
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
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.GrbCadastro = new System.Windows.Forms.GroupBox();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.LblNomeCompleto = new System.Windows.Forms.Label();
            this.TxbNomeCompleto = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.GrbEditar = new System.Windows.Forms.GroupBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.LblNovaSenha = new System.Windows.Forms.Label();
            this.TxbNovaSenha = new System.Windows.Forms.TextBox();
            this.TxbEditEmail = new System.Windows.Forms.TextBox();
            this.LblEmailEditado = new System.Windows.Forms.Label();
            this.TxbEditNomeCompleto = new System.Windows.Forms.TextBox();
            this.LblNomeEditado = new System.Windows.Forms.Label();
            this.LblDoApagar = new System.Windows.Forms.Label();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.GrbCadastro.SuspendLayout();
            this.GrbApagar.SuspendLayout();
            this.GrbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeColumns = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(21, 69);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.Size = new System.Drawing.Size(421, 221);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // GrbCadastro
            // 
            this.GrbCadastro.Controls.Add(this.BtnCadastrar);
            this.GrbCadastro.Controls.Add(this.LblSenha);
            this.GrbCadastro.Controls.Add(this.TxbSenha);
            this.GrbCadastro.Controls.Add(this.TxbEmail);
            this.GrbCadastro.Controls.Add(this.LblEmail);
            this.GrbCadastro.Controls.Add(this.TxbNomeCompleto);
            this.GrbCadastro.Controls.Add(this.LblNomeCompleto);
            this.GrbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCadastro.ForeColor = System.Drawing.Color.White;
            this.GrbCadastro.Location = new System.Drawing.Point(21, 307);
            this.GrbCadastro.Name = "GrbCadastro";
            this.GrbCadastro.Size = new System.Drawing.Size(206, 155);
            this.GrbCadastro.TabIndex = 1;
            this.GrbCadastro.TabStop = false;
            this.GrbCadastro.Text = "Cadastro";
            // 
            // GrbApagar
            // 
            this.GrbApagar.Controls.Add(this.BtnApagar);
            this.GrbApagar.Controls.Add(this.LblDoApagar);
            this.GrbApagar.Enabled = false;
            this.GrbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbApagar.ForeColor = System.Drawing.Color.Red;
            this.GrbApagar.Location = new System.Drawing.Point(21, 482);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(421, 70);
            this.GrbApagar.TabIndex = 2;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "Apagar";
            // 
            // LblNomeCompleto
            // 
            this.LblNomeCompleto.AutoSize = true;
            this.LblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCompleto.Location = new System.Drawing.Point(6, 32);
            this.LblNomeCompleto.Name = "LblNomeCompleto";
            this.LblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.LblNomeCompleto.TabIndex = 0;
            this.LblNomeCompleto.Text = "Nome Completo";
            // 
            // TxbNomeCompleto
            // 
            this.TxbNomeCompleto.Location = new System.Drawing.Point(94, 27);
            this.TxbNomeCompleto.Name = "TxbNomeCompleto";
            this.TxbNomeCompleto.Size = new System.Drawing.Size(100, 22);
            this.TxbNomeCompleto.TabIndex = 1;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(56, 63);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(94, 58);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(100, 22);
            this.TxbEmail.TabIndex = 3;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Location = new System.Drawing.Point(94, 86);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(100, 22);
            this.TxbSenha.TabIndex = 4;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(50, 91);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(38, 13);
            this.LblSenha.TabIndex = 5;
            this.LblSenha.Text = "Senha";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(9, 114);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(185, 35);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // GrbEditar
            // 
            this.GrbEditar.Controls.Add(this.BtnEditar);
            this.GrbEditar.Controls.Add(this.LblNovaSenha);
            this.GrbEditar.Controls.Add(this.TxbNovaSenha);
            this.GrbEditar.Controls.Add(this.TxbEditEmail);
            this.GrbEditar.Controls.Add(this.LblEmailEditado);
            this.GrbEditar.Controls.Add(this.TxbEditNomeCompleto);
            this.GrbEditar.Controls.Add(this.LblNomeEditado);
            this.GrbEditar.Enabled = false;
            this.GrbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEditar.ForeColor = System.Drawing.Color.White;
            this.GrbEditar.Location = new System.Drawing.Point(236, 307);
            this.GrbEditar.Name = "GrbEditar";
            this.GrbEditar.Size = new System.Drawing.Size(206, 155);
            this.GrbEditar.TabIndex = 7;
            this.GrbEditar.TabStop = false;
            this.GrbEditar.Text = "Editar";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(9, 114);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(185, 35);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // LblNovaSenha
            // 
            this.LblNovaSenha.AutoSize = true;
            this.LblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNovaSenha.Location = new System.Drawing.Point(21, 91);
            this.LblNovaSenha.Name = "LblNovaSenha";
            this.LblNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.LblNovaSenha.TabIndex = 5;
            this.LblNovaSenha.Text = "Nova Senha";
            // 
            // TxbNovaSenha
            // 
            this.TxbNovaSenha.Location = new System.Drawing.Point(94, 86);
            this.TxbNovaSenha.Name = "TxbNovaSenha";
            this.TxbNovaSenha.Size = new System.Drawing.Size(100, 22);
            this.TxbNovaSenha.TabIndex = 4;
            // 
            // TxbEditEmail
            // 
            this.TxbEditEmail.Location = new System.Drawing.Point(94, 58);
            this.TxbEditEmail.Name = "TxbEditEmail";
            this.TxbEditEmail.Size = new System.Drawing.Size(100, 22);
            this.TxbEditEmail.TabIndex = 3;
            // 
            // LblEmailEditado
            // 
            this.LblEmailEditado.AutoSize = true;
            this.LblEmailEditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailEditado.Location = new System.Drawing.Point(56, 63);
            this.LblEmailEditado.Name = "LblEmailEditado";
            this.LblEmailEditado.Size = new System.Drawing.Size(32, 13);
            this.LblEmailEditado.TabIndex = 2;
            this.LblEmailEditado.Text = "Email";
            // 
            // TxbEditNomeCompleto
            // 
            this.TxbEditNomeCompleto.Location = new System.Drawing.Point(94, 27);
            this.TxbEditNomeCompleto.Name = "TxbEditNomeCompleto";
            this.TxbEditNomeCompleto.Size = new System.Drawing.Size(100, 22);
            this.TxbEditNomeCompleto.TabIndex = 1;
            // 
            // LblNomeEditado
            // 
            this.LblNomeEditado.AutoSize = true;
            this.LblNomeEditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeEditado.Location = new System.Drawing.Point(6, 32);
            this.LblNomeEditado.Name = "LblNomeEditado";
            this.LblNomeEditado.Size = new System.Drawing.Size(82, 13);
            this.LblNomeEditado.TabIndex = 0;
            this.LblNomeEditado.Text = "Nome Completo";
            // 
            // LblDoApagar
            // 
            this.LblDoApagar.AutoSize = true;
            this.LblDoApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoApagar.ForeColor = System.Drawing.Color.White;
            this.LblDoApagar.Location = new System.Drawing.Point(6, 30);
            this.LblDoApagar.Name = "LblDoApagar";
            this.LblDoApagar.Size = new System.Drawing.Size(259, 20);
            this.LblDoApagar.TabIndex = 0;
            this.LblDoApagar.Text = "Selecione o usuario para pagar";
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
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(14, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(435, 37);
            this.LblTitulo.TabIndex = 8;
            this.LblTitulo.Text = "Gerenciamento de usuarios";
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(462, 566);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GrbEditar);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.GrbCadastro);
            this.Controls.Add(this.DgvUsuarios);
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GerenciamentoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.GrbCadastro.ResumeLayout(false);
            this.GrbCadastro.PerformLayout();
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            this.GrbEditar.ResumeLayout(false);
            this.GrbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.GroupBox GrbCadastro;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxbNomeCompleto;
        private System.Windows.Forms.Label LblNomeCompleto;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label LblDoApagar;
        private System.Windows.Forms.GroupBox GrbEditar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label LblNovaSenha;
        private System.Windows.Forms.TextBox TxbNovaSenha;
        private System.Windows.Forms.TextBox TxbEditEmail;
        private System.Windows.Forms.Label LblEmailEditado;
        private System.Windows.Forms.TextBox TxbEditNomeCompleto;
        private System.Windows.Forms.Label LblNomeEditado;
        private System.Windows.Forms.Label LblTitulo;
    }
}