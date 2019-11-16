using Comercio;
using PadariaEMerceariaDaFah.Forms;
using PadariaEMerceariaDaFah.Forms.Estoque;
using System;
using System.Windows.Forms;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos;
using PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor;
using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario;

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

            gerenciaEmpresa.Banco.Insert(
                "SET default_storage_engine= INNODB;"
                + "CREATE TABLE IF NOT EXISTS GERENCIA_FORNECEDOR (    codigo INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    description TEXT,    telefone VARCHAR(20),    celular VARCHAR(20),    email VARCHAR(100),    ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS GERENCIA_FUNCIONARIO (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    CPF VARCHAR(20) NOT NULL UNIQUE,    NAME VARCHAR(45),    FUNCAO VARCHAR(50),    TELEFONE VARCHAR(20),    CELULAR VARCHAR(10),    EMAIL VARCHAR(100),    RUA VARCHAR(20),    CIDADE VARCHAR(20),    ESTADO VARCHAR(20),    PAIS VARCHAR(20),   NUMERO INT,   CEP VARCHAR(20),  ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO (    codigo INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    description TEXT,    tipo INT,    valor DOUBLE,    COD_FUNCIONAROIO INT);"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO_REVENDIDO (	CODIGO INT PRIMARY KEY AUTO_INCREMENT,    cod_produto INT NOT NULL,    cod_fornecedor INT NOT NULL,    valor DOUBLE,    CONSTRAINT `fk_supre_fornecedo` FOREIGN KEY (`COD_FORNECEDOR`) REFERENCES GERENCIA_FORNECEDOR (`CODIGO`),	CONSTRAINT `fk_supre_produto` FOREIGN KEY (`COD_PRODUTO`) REFERENCES  ESTOQUE_PRODUTO (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_INGREDIENTE (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    validade DATE NOT NULL,    valor DOUBLE,    quantidade INT,    ATIVO TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS FORNECE (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_FORNECEDOR INT NOT NULL,    COD_INGREDIENTE INT NOT NULL,    CONSTRAINT `fk_fornece_fornecedor` FOREIGN KEY ( `COD_FORNECEDOR` ) REFERENCES GERENCIA_FORNECEDOR ( `CODIGO` ),	CONSTRAINT `fk_fornece_ingrediente` FOREIGN KEY ( `COD_INGREDIENTE` ) REFERENCES ESTOQUE_INGREDIENTE ( `CODIGO` ));"
                + "CREATE TABLE IF NOT EXISTS UTILIZA (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_PRODUTO INT NOT NULL,    COD_INGREDIENTE INT NOT NULL,    QUANTIDADE_UTILIZADA INT NOT NULL,    CONSTRAINT `fk_utiliza_produto` FOREIGN KEY (`COD_PRODUTO`) REFERENCES ESTOQUE_PRODUTO (`CODIGO`),	CONSTRAINT `fk_utiliza_ingrediente` FOREIGN KEY (`COD_INGREDIENTE`) REFERENCES ESTOQUE_INGREDIENTE (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS ITEM_ESTOQUE (    COD_ITEM INT PRIMARY KEY AUTO_INCREMENT,    COD_PRODUTO INT NOT NULL,    TIPO TINYINT(1),    VALIDADE_PRODUTO DATE,    QUANTIDADE_PRODUTO INT);"
                + "CREATE TABLE IF NOT EXISTS CLIENTE (    CODIGO INT PRIMARY KEY NOT NULL AUTO_INCREMENT,    NOME VARCHAR(45),    CONTATO VARCHAR(15),    DOCUMENTO VARCHAR(15) NOT NULL UNIQUE);"
                + "CREATE TABLE IF NOT EXISTS ARMAZENA_PRODUTO (	CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_ITEM INT NOT NULL,    COD_PRODUTO INT NOT NULL,	CONSTRAINT `FK_ARMAZENA_ITEM` FOREIGN KEY (`COD_ITEM`) REFERENCES ITEM_ESTOQUE (`COD_ITEM`),	CONSTRAINT `FK_ARMAZENA_PRODUTO` FOREIGN KEY (`COD_PRODUTO`) REFERENCES ESTOQUE_PRODUTO (`codigo`));"
                + "CREATE TABLE IF NOT EXISTS VENDAS (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    DATA_DE_VENDA DATETIME,    COD_FUNCIONARIO INT NOT NULL,    COD_CLIENTE INT,    CONSTRAINT `FK_VENDAS_FUNCIONARIOS` FOREIGN KEY (`COD_FUNCIONARIO`) REFERENCES GERENCIA_FUNCIONARIO (`CODIGO`),    CONSTRAINT `FK_VENDA_ENCOMENDA` FOREIGN KEY (`COD_CLIENTE`) REFERENCES CLIENTE (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS VENDA_ITEM (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_ITEM INT NOT NULL,    COD_VENDA INT NOT NULL,    QUANTIDADE INT,    CONSTRAINT `FK_VENDA_ITEM` FOREIGN KEY (`COD_ITEM`) REFERENCES ITEM_ESTOQUE (`COD_ITEM`),	CONSTRAINT `FK_VENDA_VENDAS` FOREIGN KEY (`COD_VENDA`) REFERENCES VENDAS (`CODIGO`));");

            if (GerenciaEmpresa.Instance.CarregarFornecedores() != null)
            {
                GerenciaEmpresa.Instance.Fornecedores.AddRange(GerenciaEmpresa.Instance.CarregarFornecedoresBanco("SELECT * FROM GERENCIA_FORNECEDOR WHERE ATIVO = 1;"));
            }

            if (GerenciaEmpresa.Instance.CarregarFuncionarios() != null)
            {
                GerenciaEmpresa.Instance.Funcionarios.AddRange(GerenciaEmpresa.Instance.CarregarFuncionariosBanco("SELECT * FROM GERENCIA_FUNCIONARIO WHERE ATIVO = 1;"));
            }
            if (GerenciaEmpresa.Instance.CarregarProdutos() != null)
            {
                GerenciaEmpresa.Instance.Produtos.AddRange(GerenciaEmpresa.Instance.CarregarProdutos());
            }
            
        }



        private void TabShowProducts_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoInicio();
            produto.ShowDialog();
        }

        private void TabGoFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new FuncionarioInicio();
            funcionario.ShowDialog();
        }

        private void TabGo_Fornecedor_Click(object sender, EventArgs e)
        {
            var fornecedor = new FornecedorInicio();
            fornecedor.ShowDialog();
        }
    }
}
