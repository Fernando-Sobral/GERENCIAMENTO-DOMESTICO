using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.DALL
{
    class LoginDaoProduto
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificaProduto(string descricao, string modelo)
        {
            cmd.CommandText = "select * from PRODUTO where @PRO_Descricao = @descricao and @PRO_Modelo = @modelo";
            cmd.Parameters.AddWithValue("@PRO_Descricao",descricao );
            cmd.Parameters.AddWithValue("@PRO_Modelo", modelo);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
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

        public String cadastroProduto(string descricao, string marca, string modelo, string tamanho, double peso, double valor, DateTime Data, string categoria)
        {
           
            tem = false;
            cmd.CommandText = "insert  into PRODUTO values (@PRO_Descricao,@PRO_Marca,@PRO_Modelo,@PRO_Tamanho,@PRO_Peso,@PRO_Valor,@PRO_Data,@Categoria)";
           
            //cmd.Parameters.AddWithValue("@IDProduto", IDProduto);
            cmd.Parameters.AddWithValue("@PRO_Descricao", descricao);
            cmd.Parameters.AddWithValue("@PRO_Marca", marca);
            cmd.Parameters.AddWithValue("@PRO_Modelo", modelo);
            cmd.Parameters.AddWithValue("@PRO_Tamanho", tamanho);
            cmd.Parameters.AddWithValue("@PRO_Peso", peso);
            cmd.Parameters.AddWithValue("@PRO_Valor", valor);
            cmd.Parameters.AddWithValue("@PRO_Data", Data);
            cmd.Parameters.AddWithValue("@Categoria", categoria);

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
                this.mensagem = "Erro com o banco de dados ";
               
            }
            return mensagem;

        }

       
    }
}
