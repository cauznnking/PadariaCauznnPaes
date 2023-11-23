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

namespace PadariaCauznnPaes
{
    public partial class MenuPrincipal : Form
    {
        //objeitos globais 
        Classes.Usuario usuario = new Classes.Usuario();

        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            //Atributo o usuario local no global 
            this.usuario = usuario;

            //mudar a label de apresentação
            LblApresentacao.Text = "Ola, " + usuario.NomeCompleto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
            {
                //isntanciar a janela
                Views.GerenciamentoDeProduto janela = new Views.GerenciamentoDeProduto(usuario);
                janela.Show();
            }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            //isntanciar a janela
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();

        }

        private void BtnComanda_Click(object sender, EventArgs e)
        {
            Views.Comandas janela = new Views.Comandas(usuario);
            janela.Show();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoCaixa janela = new Views.GerenciamentoCaixa(usuario);
            janela.Show();
        }
    }
}
