using SISTEMA.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SISTEMA.Modelo.ControlePesquisaProduto;
using static SISTEMA.Modelo.PesquisaModel;

namespace SISTEMA.DALL
{
    class LoginDaoPesquisaProduto
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();

        //public bool pesquisarProduto(int codproduto, string descricao)
        //{
        //    cmd.CommandText = "SELECT * FROM PRODUTO WHERE @IDProduto = codproduto and @PRO_Descricao = @descricao ";
        //    cmd.Parameters.AddWithValue("@PRO_Descricao", descricao);
        //    cmd.Parameters.AddWithValue("@IDProduto", codproduto);

        //    try
        //    {
        //        cmd.Connection = con.conectar();
        //        dr = cmd.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            tem = true;
        //        }
        //        con.desconectar();
        //        dr.Close();
        //    }
        //    catch (SqlException)
        //    {
        //        this.mensagem = "Erro com o Bando de Dados ";

               
        //    }
        //    return tem;
        //}
        //public string buscarProduto(int codproduto,string descricao)
        //{
        //    tem = false;
        //    cmd.CommandText = "SELECT   * PRODUTO WHERE @IDProduto = codproduto and @PRO_Descricao = @descricao)";
        //    cmd.Parameters.AddWithValue("@IDProduto", codproduto);
        //    cmd.Parameters.AddWithValue("@PRO_Descricao", descricao);
        //    //cmd.Parameters.AddWithValue("@PRO_Marca", marca);
        //    //cmd.Parameters.AddWithValue("@PRO_Modelo", modelo);
        //    //cmd.Parameters.AddWithValue("@PRO_Tamanho", tamanho);
        //    //cmd.Parameters.AddWithValue("@PRO_Peso", peso);
        //    //cmd.Parameters.AddWithValue("@PRO_Valor", valor);
        //    //cmd.Parameters.AddWithValue("@PRO_Data", Data);
        //    //cmd.Parameters.AddWithValue("@Categoria", categoria);

        //    try
        //    {
        //        cmd.Connection = con.conectar();
        //        cmd.ExecuteNonQuery();
        //        con.desconectar();
        //        tem = true;
        //    }
        //    catch (SqlException)
        //    {

        //        this.mensagem = "Erro com o banco de dados";
        //    }
        //    return mensagem;

        //}
        
        //METODO PARA LISTAR OS DADOS NO BANCO 
        public DataTable Listar()
        {
            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "SELECT   *  FROM PRODUTO ";
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch(SqlException)
            {
                throw;
            }

        }
        //METODO PARA DIGITAR O PRODUTO PESQUISADO 
        public DataTable Pesquisar(PesquisarModel desc) //desc
        {
            try
            {
                
                cmd.Connection = con.conectar();
                //cmd.CommandText = "SELECT   *  FROM PRODUTO WHERE @IDProduto"; 
                cmd.CommandText = "SELECT   *  FROM PRODUTO WHERE PRO_Descricao LIKE '%' ORDER BY PRO_Descricao ASC "; //
                //cmd.Parameters.AddWithValue("@IDProduto", desc);
                //cmd.Parameters.AddWithValue("@PRO_Descricao", desc.codproduto);
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;

            }
            catch (SqlException)
            {

                throw;
            }
        }
 





    }
}
