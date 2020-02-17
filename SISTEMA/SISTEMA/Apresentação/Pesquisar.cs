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
using static SISTEMA.Modelo.PesquisaModel;

namespace SISTEMA.Apresentação
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ControlePesquisaProduto pesquisa = new ControlePesquisaProduto();
            object v = dtgPesquisa.DataSource = pesquisa.Listar();

            //string mensagem = pesquisa.pesProduto(Convert.ToInt32(txtId.Text),txtDescricao.Text);
            //if (pesquisa.tem)
            //{
            //    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show(pesquisa.mensagem);
            //}
        }

        private void Pesquisa(PesquisarModel descricao)
        {
            //descricao.codproduto = Convert.ToInt32(txtId.Text);
            descricao.descricao = txtDescricao.Text.Trim();
            ControlePesquisaProduto pesquisaControle = new ControlePesquisaProduto();
            dtgPesquisa.DataSource = pesquisaControle.Pesquisar(descricao);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text =="")
            {
                ControlePesquisaProduto buscarControle = new ControlePesquisaProduto();
                dtgPesquisa.DataSource = buscarControle.Listar();
            }
            else
            {
                PesquisarModel pesqModel = new PesquisarModel();
                Pesquisa(pesqModel);
            }
        }
    }
}
