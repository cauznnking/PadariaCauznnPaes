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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
           
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //INSTANCIA O USUARIO
            Classes.Usuario usuario= new Classes.Usuario();
            usuario.Email = TxbEmail.Text;
            usuario.Senha = TxbSenha.Text;

            //OBTER O RESULTADO DO SELECT NO BANCO: 
            var resultado = usuario.Logar();

            if(resultado.Rows.Count == 1)
            {
                //SENHA CORRETA
               usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
               usuario.Id = (int)resultado.Rows[0]["id"];
               MessageBox.Show(usuario.NomeCompleto);

                //PROXIMO PASSSO: ABRIR A JANELA MENU:
                MenuPrincipal janela = new MenuPrincipal();

                //esconder janela atual
                Hide();

                //mostrar menu
                janela.ShowDialog();

                //mostrar o login quando o menu fechar
                Show();
                
            }
            else
            {
                // SENHA INCORRETA 
                MessageBox.Show("Email ou senha incorretos. ",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
