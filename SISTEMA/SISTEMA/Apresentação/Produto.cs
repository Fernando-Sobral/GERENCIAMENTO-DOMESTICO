using SISTEMA.Apresentação;
using SISTEMA.DALL;
using SISTEMA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            txtCategoria.Enabled = false;
            txtDescricao.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtPeso.Enabled = false;
            txtPreco.Enabled = false;
            txtTamanho.Enabled = false;
            mskData.Enabled = false;
        }
        private string strsql = string.Empty;
        Conexao con = new Conexao();
        private string mensagem;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
            txtDescricao.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtPeso.Enabled = true;
            txtPreco.Enabled = true;
            txtTamanho.Enabled = true;
            mskData.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {     
            ControleProduto salvar = new ControleProduto();
            
                                    //cadastrarProduto(int IDProduto, string Data, string descricao, string categoria, double valor, string marca, string tamanho, double peso, string modelo)
            string mensagem = salvar.cadastrarProduto(txtDescricao.Text, txtMarca.Text, txtModelo.Text, txtTamanho.Text, Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtPreco.Text),Convert.ToDateTime(mskData.Text), txtCategoria.Text);
            if (salvar.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(salvar.mensagem);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pesquisar consultar = new Pesquisar();
            consultar.ShowDialog();
        }
    }
}
