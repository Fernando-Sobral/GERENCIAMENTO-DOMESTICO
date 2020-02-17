using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.DALL
{
     public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()// Construtor 
        {
            con.ConnectionString = @"Data Source=DESKTOP-KLAIKGG\SQLEXPRESS;Initial Catalog=GERENCIAMENTO;Integrated Security=True";
        }
        public SqlConnection conectar()
        {//Verifica se á conexão como banco está fechada caso sim abrir
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {//Verificar se a conexão como banco está aberta caso sim fecha 
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
