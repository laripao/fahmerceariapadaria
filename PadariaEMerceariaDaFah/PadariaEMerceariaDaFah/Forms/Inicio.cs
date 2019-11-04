using Comercio;
using PadariaEMerceariaDaFah.Forms;
using PadariaEMerceariaDaFah.Forms.Estoque;
using System;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void go_gerencia_Click(object sender, EventArgs e)
        {
            var gerencia = new GerenciaInicio();
            gerencia.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            var gerenciaEmpresa = new GerenciaEmpresa();
            if(GerenciaEmpresa.Instance.CarregarFornecedores()!= null)
                GerenciaEmpresa.Instance.Fornecedores.AddRange(GerenciaEmpresa.Instance.CarregarFornecedores());

            if(GerenciaEmpresa.Instance.CarregarFuncionarios()!= null)
                GerenciaEmpresa.Instance.Funcionarios.AddRange(GerenciaEmpresa.Instance.CarregarFuncionarios());

            if (GerenciaEmpresa.Instance.CarregarProdutos() != null)
                GerenciaEmpresa.Instance.Produtos.AddRange(GerenciaEmpresa.Instance.CarregarProdutos());
        }

        private void go_estoque_Click(object sender, EventArgs e)
        {
            var estoque = new EstoqueInicio();
            estoque.ShowDialog();
        }
    }
}
