using SISTEMA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA.Apresentação
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btmCadastrar_Click(object sender, EventArgs e)
        {
            //Chamando o Formulário para cadastrar um novo ususário
            Cadastre_Se cad = new Cadastre_Se();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if(controle.mensagem.Equals(""))
            {

           
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Produto prod = new Produto();
                    prod.Show();
                }
                else
                {
                    MessageBox.Show("login não encontrado, verifique login  e senha ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
