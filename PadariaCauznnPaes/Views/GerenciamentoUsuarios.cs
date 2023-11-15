using PadariaCauznnPaes.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCauznnPaes.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        //atributos globais 
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            //atributar a tabela (resultado do SELECT )
            DgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void GerenciamentoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //isntanciar o ususario
            Classes.Usuario usuario = new Classes.Usuario();
            
            //obter valores dos campos 
            usuario.NomeCompleto = TxbNomeCompleto.Text;
            usuario.Email = TxbEmail.Text;
            usuario.Senha = TxbSenha.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuario cadastrado com exito!!");
                // Limpar os campos:
                TxbNomeCompleto.Clear();
                TxbEmail.Clear();
                TxbSenha.Clear();
                // Atualizar o dgv:
                DgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("falha ao cadastrar o usuario!!");
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os grbs:
            GrbEditar.Enabled = true;
            GrbApagar.Enabled = true;

            //obter a linha clicada:
            int LinhaSelecionada = DgvUsuarios.CurrentCell.RowIndex;

            //armazenar os dados da linha selecionada em "linha" (tipo um vetor )
            var linha = DgvUsuarios.Rows[LinhaSelecionada];

            //preencher os campos:
            TxbEditNomeCompleto.Text = linha.Cells[1].Value.ToString();
            TxbEditEmail.Text = linha.Cells[2].Value.ToString();

            //juntar os id e o nome  para exibir no apagar
            LblDoApagar.Text = linha.Cells[0].Value.ToString() + "-" +
                linha.Cells[1].Value.ToString();

            //salvar o id do selecionado na variavel global
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            //apagar:
            var r = MessageBox.Show("Tem certeza que desejas apagar o usuarios?", "ATENÇÃO",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            { 
                //apagar
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("USUARIO APAGADO ", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualizar o dgv:
                    DgvUsuarios.DataSource = usuario.ListarTudo();
                    //limpar os campos de edição
                    TxbEditEmail.Clear();
                    TxbEditNomeCompleto.Clear();
                    TxbNovaSenha.Clear();
                    LblDoApagar.Text = "selecione um usuario para apagar";
                    //desabilitar o gbrs
                    GrbApagar.Enabled = false;
                    GrbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("FALHA AO APAGAR", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            
            
            // obter os valores dos Txbs
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = TxbEditNomeCompleto.Text;
            usuario.Email = TxbEditEmail.Text;
            usuario.Senha = TxbNovaSenha.Text;

            //editar
            if (usuario.Modificar() == true)
            {
                MessageBox.Show("USUARIO MODIFICADO ", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //atualizar o dgv:
                DgvUsuarios.DataSource = usuario.ListarTudo();
                //limpar os campos de edição
                TxbEditEmail.Clear();
                TxbEditNomeCompleto.Clear();
                TxbNovaSenha.Clear();
                LblDoApagar.Text = "selecione um usuario para apagar";
                //desabilitar o gbrs
                GrbApagar.Enabled = false;
                GrbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("FALHA AO MODIFICAR O USUARIO ", "FALHA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
