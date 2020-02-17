using SISTEMA.DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.Modelo
{
    class ControleProduto
    {
        public bool tem;
        public String mensagem = "";

        public bool verProduto(string descricao, string modelo)
        {
            LoginDaoProduto verificacao = new LoginDaoProduto();
            tem = verificacao.verificaProduto(descricao,modelo);
            if (!verificacao.mensagem.Equals(""))
            {
                this.mensagem = verificacao.mensagem;
            }
            return tem;
        }
        public String cadastrarProduto(string descricao, string marca, string modelo, string tamanho, double peso, double valor, DateTime Data, string categoria)
        {

            LoginDaoProduto cadastro = new LoginDaoProduto();
            this.mensagem = cadastro.cadastroProduto(descricao, marca, modelo, tamanho, peso,valor, Data,categoria);
            if (cadastro.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
