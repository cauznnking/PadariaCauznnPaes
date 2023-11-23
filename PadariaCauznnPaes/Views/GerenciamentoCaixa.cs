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
    public partial class GerenciamentoCaixa : Form
    {
        Classes.Usuario usuario;

        public GerenciamentoCaixa(Classes.Usuario usuario)
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GerenciamentoCaixa_Load(object sender, EventArgs e)
        {

        }

        private void ChbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            //Ativa e desativa o botão com o checked
            BtnEncerrarComada.Enabled= ChbPagamento.Checked;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            //verificar se o txb esta vazio:
            if(TxbNumeroDaComanda.Text != "")
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(TxbNumeroDaComanda.Text);
               var r = ordem.BuscarFicha();
                DgvFicha.DataSource = r;
                //Atualizar o valor total 
                LblTotal.Text = "R$" + r.Compute("SUM(total_item)", "true").ToString();
            }
            else
            {
                MessageBox.Show("digite o numero da ficha", 
                    "ERRORR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEncerrarComada_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar a comanda? ","ATENÇÃO!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( r == DialogResult.Yes )
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(TxbNumeroDaComanda.Text) ;
                if(ordem.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encerrada", "CONCLUIDO!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //limpar
                    TxbNumeroDaComanda.Clear();
                    DgvFicha.DataSource=null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!!! ", "ERRORR!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }
    }
}
