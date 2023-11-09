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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            //INSTANCIAR A JANELA DE LOGIN
            Login janela = new Login();
            //MOSTRAR JANELA 
            janela.ShowDialog();
            //FECHAR TUDO AO FECHAR A LOGIN
            Application.Exit();
        }
    }
}
