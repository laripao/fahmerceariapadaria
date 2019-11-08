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

            gerenciaEmpresa.Banco.Insert("create database if not exists laripaos");

            gerenciaEmpresa.Banco = new Formulario.DB("Laripaos");

            gerenciaEmpresa.Banco.Insert("CREATE TABLE IF NOT EXISTS GERENCIA_FORNECEDOR  (codigo int primary key AUTO_INCREMENT, name varchar(45), description text,                telefone varchar(20),                celular varchar(20),               email varchar(100))");
            gerenciaEmpresa.Banco.Insert("CREATE TABLE IF NOT EXISTS GERENCIA_FUNCIONARIO(        CODIGO INT PRIMARY KEY AUTO_INCREMENT,        CPF VARCHAR(20) NOT NULL UNIQUE,        NOME VARCHAR(45),        DESCRICAO TEXT,        FUNCAO VARCHAR(20),        TELEFONE VARCHAR(20),        CELULAR VARCHAR(10),        EMAIL VARCHAR(100),        RUA VARCHAR(20),        CIDADE VARCHAR(20),        ESTADO VARCHAR(20),        PAIS VARCHAR(20),        NUMERO VARCHAR(10));");
            gerenciaEmpresa.Banco.Insert("CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO  (                codigo int primary key AUTO_INCREMENT,                name varchar(45),                description text,                tipo int,                valor double,               ingredientes text(100),                cod_fornecedor int); ");

            if (GerenciaEmpresa.Instance.CarregarFornecedores() != null)
                GerenciaEmpresa.Instance.Fornecedores.AddRange(GerenciaEmpresa.Instance.CarregarFornecedores());

            if (GerenciaEmpresa.Instance.CarregarFuncionarios() != null)
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
