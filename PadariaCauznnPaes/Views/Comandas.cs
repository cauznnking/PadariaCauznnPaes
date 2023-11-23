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
    public partial class Comandas : Form
    {
        //global
        Classes.Usuario usuario;

        public Comandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //mudar o titulo da janela 
            this.Text = "Gerenciamento de comandas - " +
                "Logado como: " + usuario.NomeCompleto.ToUpper();

            Classes.Produto produto = new Classes.Produto();
            DgvComanda.DataSource = produto.ListarTudo();
        }

        private void DgvComanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int LinhaSelecionada = DgvComanda.CurrentCell.RowIndex;
            var linha = DgvComanda.Rows[LinhaSelecionada];

            //populando os txbs com os valores do dgv
            TxbProduto.Text = linha.Cells[0].Value.ToString();
            TxbProdutoLancar.Text = linha.Cells[1].Value.ToString();

        }

        private void LimparTudo()
        {
            //  Limpa os cods
            TxbProduto.Clear();
            TxbProdutoLancar.Clear();
            TxbComanda.Clear();
            TxbQuantidade.Clear();

            //  Resetar os grbs
            GrbInformacoes.Enabled = true;
            GrbLancamento.Enabled = false;
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            if (TxbComanda.Text != "" && TxbProduto.Text != "")
            {
                GrbLancamento.Enabled = true;
                GrbInformacoes.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!!",
                    "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLancar_Click(object sender, EventArgs e)
        {

            if (TxbQuantidade.Text != "")
            {
                var r = MessageBox.Show("tem certeza que desejas lançar?? ", "AVISO!!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                    //obter os valores dos campos
                    ordem.IdFicha = int.Parse(TxbComanda.Text);
                    ordem.IdProduto = int.Parse(TxbProduto.Text);
                    ordem.Quantidade = int.Parse(TxbQuantidade.Text);
                    ordem.IdResp = usuario.Id;
                    //efetuar o cadastro
                    if (ordem.NovoLancamento() == true)
                    {
                        MessageBox.Show("Lançamento efetudado! ", "SUCESSO!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTudo();
                    }
                    else
                    {
                        MessageBox.Show("Lançamento Nao Efetuado! ", "Errorr!",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparTudo();
                    }

                }
            }
            else
            {
                MessageBox.Show("INFORME A QUANTIDADE ", "ERRORR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}
