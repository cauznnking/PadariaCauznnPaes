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
    public partial class GerenciamentoDeProduto : Form
    {
        //atributos globais 
        int idSelecionado = 0;

        public GerenciamentoDeProduto()
        {
            InitializeComponent();

            //istanciar produtos
            Classes.Produto produto = new Classes.Produto();
            DgvProdutos.DataSource = produto.ListarTudo();

        }

        private void GerenciamentoDeProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //ativar os grbs:
            GrbEditarProdutos.Enabled = true;
            GrbApagarProduto.Enabled = true;

            //obter a linha clicada:
            int LinhaSelecionada = DgvProdutos.CurrentCell.RowIndex;

            //armazenar os dados da linha selecionada em "linha" (tipo um vetor )
            var linha = DgvProdutos.Rows[LinhaSelecionada];

            //preencher os campos:
           TxbNomeEdit.Text = linha.Cells[1].Value.ToString();
            TxbPrecoEdit.Text = linha.Cells[2].Value.ToString();
            CmbCategoriaEdit.Text = linha.Cells[2].Value.ToString();

            //juntar os id e o nome  para exibir no apagar
            LblDoApagar.Text = linha.Cells[0].Value.ToString() + "-" +
                linha.Cells[1].Value.ToString();

            //salvar o id do selecionado na variavel global
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            //apagar:
            var r = MessageBox.Show("Tem certeza que desejas apagar o usuarios?", "ATENÇÃO",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                //apagar
                if (produto.Apagar() == true)
                {
                    MessageBox.Show("PRODUTO APAGADO ", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualizar o dgv:
                    DgvProdutos.DataSource = produto.ListarTudo();
                    //limpar os campos de edição
                    TxbNomeEdit.Clear();
                    TxbPrecoEdit.Clear();
                    
                    LblDoApagar.Text = "selecione um produto para apagar";
                    //desabilitar o gbrs
                    GrbApagarProduto.Enabled = false;
                    GrbEditarProdutos.Enabled = false;
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
            {
                Classes.Produto produto = new Classes.Produto();


                // Obter os valores dos txbs:
                produto.Nome = TxbNomeEdit.Text;
                produto.Preco = int.Parse(TxbPrecoEdit.Text);
                produto.IdCategoria = int.Parse(CmbCategoriaEdit.Text);


                //Editar 
                if (produto.Modificar() == true)
                {
                    MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Falha ao modificar produto", "falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Editar:
                    if (produto.Modificar() == true)
                    {
                        MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao modificar produto!", "Falha!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //isntanciar o ususario
            Classes.Produto produto = new Classes.Produto();

            //obter valores dos campos 
            produto.Nome = TxbNomeProduto.Text;
            produto.Preco = TxbPreco.Text;
            produto. = TxbSenha.Text;

            if (produto.Cadastrar() == true)
            {
                MessageBox.Show("Usuario cadastrado com exito!!");
                // Limpar os campos:
                TxbNomeProduto.Clear();
                TxbPreco.Clear();
                CmbCategoria.Clear();
                // Atualizar o dgv:
                DgvProdutos.DataSource = produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("falha ao cadastrar o usuario!!");
            }
        }
    }
}