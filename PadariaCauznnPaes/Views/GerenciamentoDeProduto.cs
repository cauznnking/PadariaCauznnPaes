using PadariaCauznnPaes.Classes;
using System;
using System.Collections;
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
        Classes.Usuario usuario = new Classes.Usuario();

        public GerenciamentoDeProduto(Classes.Usuario usuario)
        {
            InitializeComponent();

            //istanciar produtos
            Classes.Produto produto = new Classes.Produto();
            this.usuario = usuario;
            DgvProdutos.DataSource = produto.ListarTudo();

            Classes.Categoria categoria = new Classes.Categoria();  
            //Montar um array de itens para colocar no cmb
            var r = categoria.ListarTudo(); // r é a tabela do bd

            //percorrer o r, montar a string e add no cmb
            foreach (DataRow linha in r.Rows)
            {
                CmbCategoria.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                CmbCategoriaEdit.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
            }
            AtualizarTudo();

        }

        private void GerenciamentoDeProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        public void AtualizarTudo()
        {
            Classes.Produto produto = new Classes.Produto();
            // Atualizar o DGV:
            DgvProdutos.DataSource = produto.ListarTudo();
            // Listar os campos de edição:
            TxbNomeEdit.Clear();
            TxbPrecoEdit.Clear();
            LblDoApagar.Text = "Selecione um produto para apagar.";
            // Desabilitar os grbs:
            GrbApagarProduto.Enabled = false;
            GrbEditarProdutos.Enabled = false;
            // Limpar os campos:
            TxbNomeProduto.Clear();
            TxbPreco.Clear();
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
                    AtualizarTudo();
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

                produto.Id = idSelecionado;
                var n = CmbCategoriaEdit.Text;
                produto.Nome = TxbNomeEdit.Text;
                produto.Preco = double.Parse(TxbPrecoEdit.Text);
                produto.IdCategoria = int.Parse(n.Split('-')[0]);
                produto.IdRespCadastro = usuario.Id;



                //Editar 
                if (produto.Modificar() == true)
                {
                    MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar produto", "falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //isntanciar o ususario
            Classes.Produto produto = new Classes.Produto();

            //obter valores dos campos 
            produto.Nome = TxbNomeProduto.Text;
            produto.Preco = double.Parse(TxbPreco.Text);

            // separar os arrays
            var n = CmbCategoria.Text;
            produto.IdCategoria = int.Parse(n.Split('-')[0]);
            produto.IdRespCadastro = usuario.Id;

            if (produto.Cadastrar() == true)
            {
                MessageBox.Show("Produto cadastrado com exito!!");
                AtualizarTudo();
            }
            else
            {
                MessageBox.Show("falha ao cadastrar o usuario!!");
            }
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
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
            

            //juntar os id e o nome  para exibir no apagar
            LblDoApagar.Text = linha.Cells[0].Value.ToString() + "-" +
                linha.Cells[1].Value.ToString();

            //salvar o id do selecionado na variavel global
            idSelecionado = (int)linha.Cells[0].Value;

        }
    }
}