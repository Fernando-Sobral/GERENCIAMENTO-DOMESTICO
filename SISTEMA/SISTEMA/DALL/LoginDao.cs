using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.DALL
{
    //Classe que irá se comunicar com o banco de dados através das informações que virão da classe "CONTROLE" 
    class LoginDao
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao(); //Estanciando a conexão 
        SqlDataReader dr; //onde será guardado as informação do banco de dados 

        // metodo para verificar o login passando o login e senha como parametro 
        public bool verificarLogin(String login, String senha)// Metodo verifica se as informações contém no banco de dados 
        {
            //CommandTEXT é o comando que usariamos no banco de dados
            cmd.CommandText = "select * from LOGINS where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);//O que foi passado por parametro irá ser passado para o Login
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();//Pega informação do banco de dados que será guardado
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados";
            }
            return tem;
        }

        // Metodto que verifica se ao cadastrar o nome no banco o mesmo não se encontra cadastrado
        public String cadastrar(String login, String senha, String Confsenha)
        {
            tem = false;
            //Comando para incerir no banco e retornar uma mensagem 
            if (senha.Equals(Confsenha))
            {
                cmd.CommandText = "insert into LOGINS values (@e,@s);";
                cmd.Parameters.AddWithValue("@e", login);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senha não correspondem ";
            }
           
            return mensagem;
        }
    }
}
