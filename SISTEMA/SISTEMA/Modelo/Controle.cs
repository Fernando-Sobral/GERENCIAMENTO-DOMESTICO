using SISTEMA.DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = ""; // Para retornar uma mensagem 
        
        public bool acessar(String login, String senha)
        {
            LoginDao logar = new LoginDao();//estanciando a classe LoginDao
            tem = logar.verificarLogin(login, senha);// Informações que vieram do formulário
            if (!logar.mensagem.Equals(""))
            {
                this.mensagem = logar.mensagem;
            }
            return tem;
        }
        // Metodo para cadastra senha, passando como paramêtro o Login, Senha e a Confirmação da Senha
        public String cadastrar(String login,String senha, String confSenha)
        {
            LoginDao logar = new LoginDao();
            this.mensagem = logar.cadastrar(login, senha, confSenha);
            if (logar.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }
       
    }
}
