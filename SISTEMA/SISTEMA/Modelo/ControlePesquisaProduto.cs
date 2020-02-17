using SISTEMA.DALL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SISTEMA.Modelo.PesquisaModel;

namespace SISTEMA.Modelo
{

    public class ControlePesquisaProduto
    {
        public DataTable Listar()
        {
            try
            {
                LoginDaoPesquisaProduto pesquisar = new LoginDaoPesquisaProduto();
                DataTable dt = new DataTable();

                dt = pesquisar.Listar();
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }

        }
        public DataTable Pesquisar(PesquisarModel descricao)
        {
            try
            {
                LoginDaoPesquisaProduto buscar = new LoginDaoPesquisaProduto();
                DataTable dt = new DataTable();
                dt = buscar.Pesquisar(descricao);

                return dt;
            }
            catch (SqlException)
            {

                throw;
            }

        }


        //public bool tem;
        //public string mensagem = "";

        //public bool verificaProduto(int codproduto,string descricao)
        //{
        //    LoginDaoPesquisaProduto pesquisar = new LoginDaoPesquisaProduto();
        //    tem = pesquisar.pesquisarProduto(codproduto,descricao);
        //    if (!pesquisar.mensagem.Equals(""))
        //    {
        //        this.mensagem = pesquisar.mensagem;
        //    }
        //    return tem;
        //}

        //public String pesProduto(int codproduto,string descricao)
        //{

        //    LoginDaoPesquisaProduto buscar = new LoginDaoPesquisaProduto();
        //    this.mensagem = buscar.buscarProduto(codproduto,descricao);
        //    if (buscar.tem)
        //    {
        //        this.tem = true;
        //    }
        //    return mensagem;
        //}
        }
    
}
