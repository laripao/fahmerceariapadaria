using Comercio;
using PadariaEMerceariaDaFah.Forms;
using PadariaEMerceariaDaFah.Forms.Estoque;
using System;
using System.Windows.Forms;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos;
using PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor;
using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario;
using PadariaEMerceariaDaFah.Forms.Gerencia.Cliente;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace PadariaEMerceariaDaFah
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            Form prod = new ProdutoInicio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panel_produto.Controls.Add(prod);
            prod.Show();

            var gerenciaEmpresa = new GerenciaEmpresa();

            gerenciaEmpresa.Banco.Insert("create database if not exists laripaos");

            this.HorizontalScroll.Enabled = true;

            gerenciaEmpresa.Banco = new Formulario.DB("Laripaos");

            

            gerenciaEmpresa.Banco.Insert(
                "SET default_storage_engine= INNODB;"
                + "CREATE TABLE IF NOT EXISTS GERENCIA_FORNECEDOR (    codigo INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    description TEXT,    telefone VARCHAR(20),    celular VARCHAR(20),    email VARCHAR(100),    ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS GERENCIA_FUNCIONARIO (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    CPF VARCHAR(20) NOT NULL UNIQUE,    NAME VARCHAR(45),    FUNCAO VARCHAR(50),    TELEFONE VARCHAR(20),    CELULAR VARCHAR(10),    EMAIL VARCHAR(100),    RUA VARCHAR(20),    CIDADE VARCHAR(20),    ESTADO VARCHAR(20),    PAIS VARCHAR(20),   NUMERO INT,   CEP VARCHAR(20),  ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO (    codigo INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    description TEXT,    tipo INT,    valor DOUBLE,    COD_FUNCIONARIO INT);"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO_REVENDIDO (	CODIGO INT PRIMARY KEY AUTO_INCREMENT,    cod_produto INT NOT NULL,    cod_fornecedor INT NOT NULL,    valor DOUBLE,    CONSTRAINT `fk_supre_fornecedo` FOREIGN KEY (`COD_FORNECEDOR`) REFERENCES GERENCIA_FORNECEDOR (`CODIGO`),	CONSTRAINT `fk_supre_produto` FOREIGN KEY (`COD_PRODUTO`) REFERENCES  ESTOQUE_PRODUTO (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_INGREDIENTE (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    validade DATE NOT NULL,    valor DOUBLE,    quantidade INT,    ATIVO TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS FORNECE (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_FORNECEDOR INT NOT NULL,    COD_INGREDIENTE INT NOT NULL,    CONSTRAINT `fk_fornece_fornecedor` FOREIGN KEY ( `COD_FORNECEDOR` ) REFERENCES GERENCIA_FORNECEDOR ( `CODIGO` ),	CONSTRAINT `fk_fornece_ingrediente` FOREIGN KEY ( `COD_INGREDIENTE` ) REFERENCES ESTOQUE_INGREDIENTE ( `CODIGO` ));"
                + "CREATE TABLE IF NOT EXISTS UTILIZA (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_PRODUTO INT NOT NULL,    COD_INGREDIENTE INT NOT NULL,    QUANTIDADE_UTILIZADA INT NOT NULL,    CONSTRAINT `fk_utiliza_produto` FOREIGN KEY (`COD_PRODUTO`) REFERENCES ESTOQUE_PRODUTO (`CODIGO`),	CONSTRAINT `fk_utiliza_ingrediente` FOREIGN KEY (`COD_INGREDIENTE`) REFERENCES ESTOQUE_INGREDIENTE (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS ITEM_ESTOQUE (    COD_ITEM INT PRIMARY KEY AUTO_INCREMENT,    COD_PRODUTO INT NOT NULL,    TIPO TINYINT(1),    VALIDADE_PRODUTO DATE,    QUANTIDADE_PRODUTO INT);"
                + "CREATE TABLE IF NOT EXISTS CLIENTE (    CODIGO INT PRIMARY KEY NOT NULL AUTO_INCREMENT,    NOME VARCHAR(45),        DOCUMENTO VARCHAR(15) NOT NULL UNIQUE, telefone VARCHAR(20),    celular VARCHAR(20),    email VARCHAR(100));"
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
                GerenciaEmpresa.Instance.Produtos.AddRange(GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM laripaos.estoque_produto;"));
            }
            GerenciaEmpresa.Instance.Clientes.AddRange(GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM CLIENTE;"));

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

        private void TabGoCliente_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteInicio();
            cliente.ShowDialog();

        }

        private void tabPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void tabela_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tabelaSelecionada;

            groupBox1.Controls.Clear();

            switch (tabela.SelectedItem.ToString())
            {
                case "Produto":
                    tabelaSelecionada = "estoque_produto";
                    break;
                case "Funcionario":
                    tabelaSelecionada = "gerencia_funcionario";
                    break;
                case "Fornecedor":
                    tabelaSelecionada = "gerencia_fornecedor";
                    break;
                case "Cliente":
                    tabelaSelecionada = "cliente";
                    break;
                default:
                    tabelaSelecionada = "SEM TABELA";
                    break;
            }

            var desc = Comercio.GerenciaEmpresa.Instance.Banco.Select("desc " + tabelaSelecionada);
            var maxLinhas = Convert.ToInt32(Comercio.GerenciaEmpresa.Instance.Banco.Select("SELECT COUNT(*) FROM " + tabelaSelecionada).Rows[0].ItemArray[0].ToString());
            var numCampos = desc.Rows.Count;

            string[,] campos = new string[maxLinhas + 1, numCampos];

            for (int i = 0; i < numCampos; i++)
            {
                campos[0, i] = desc.Rows[i].ItemArray[0].ToString();
            }

            this.WindowState = FormWindowState.Maximized;
            groupBox1.Width = Width = 15 + (100 * numCampos);
            groupResultados.Width = 15 + (100 * numCampos);

            for (int i = 0; i < numCampos; i++)
            {
                var label = new Label();
                label.Text = campos[0, i].ToUpper().Replace("COD_", "");
                label.Width = 95;
                label.Location = new Point(10 + (100 * i), 25);
                label.TextAlign = ContentAlignment.MiddleCenter;
                var combo = new ComboBox();
                combo.Width = 95;
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                combo.AutoCompleteMode = AutoCompleteMode.Suggest;

                var valores = Comercio.GerenciaEmpresa.Instance.Banco.Select("SELECT DISTINCT(" + campos[0, i] + ") from " + tabelaSelecionada).Rows;
                for (int j = 0; j < valores.Count; j++)
                {
                    combo.Items.Add(valores[j].ItemArray[0].ToString());
                }
                combo.Location = new Point(10 + (100 * i), 50);

                groupBox1.Controls.Add(label);
                groupBox1.Controls.Add(combo);

            }
            /*var combo = new ComboBox();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.Items.Add("Teste1");
            combo.Items.Add("Teste2");
            combo.Items.Add("Teste3");
            combo.Items.Add("Teste4");
            combo.Items.Add("Teste4");
            combo.Location = new Point(50,50);*/
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (tabela.SelectedItem == null)
                return;
            var controles = groupBox1.Controls;
            groupResultados.Controls.Clear();

            string tabelaSelecionada;
            
            switch (tabela.SelectedItem.ToString())
            {
                case "Produto":
                    tabelaSelecionada = "estoque_produto";
                    break;
                case "Funcionario":
                    tabelaSelecionada = "gerencia_funcionario";
                    break;
                case "Fornecedor":
                    tabelaSelecionada = "gerencia_fornecedor";
                    break;
                case "Cliente":
                    tabelaSelecionada = "cliente";
                    break;
                default:
                    tabelaSelecionada = "SEM TABELA";
                    break;
            }

            var desc = GerenciaEmpresa.Instance.Banco.Select("desc " + tabelaSelecionada);
            var maxLinhas = Convert.ToInt32(GerenciaEmpresa.Instance.Banco.Select("SELECT COUNT(*) FROM " + tabelaSelecionada).Rows[0].ItemArray[0].ToString());
            var numCampos = desc.Rows.Count;

            string[] campos = new string[numCampos];

            for (int i = 0; i < numCampos; i++)
            {
                campos[i] = desc.Rows[i].ItemArray[0].ToString();
            }

            string query;
            List<ComboBox> Combos = new List<ComboBox>();
            for (int i =0; i< controles.Count; i++)
            {
                if(controles[i].AccessibilityObject.Role == AccessibleRole.ComboBox)
                    Combos.Add((ComboBox)controles[i]);

            }

            query = "SELECT * FROM " + tabelaSelecionada;
            if (Combos.Any(x => x.SelectedItem != null))
            {
                query = query + " WHERE ";
                var and = false;
                for(int i = 0; i< numCampos; i++)
                {                    
                    if (Combos[i].SelectedItem != null)
                    {
                        if (and)
                        {
                            query = query + " AND ";
                        }
                        query = query + campos[i] + " = '" + Combos[i].SelectedItem.ToString() + "' ";
                        and = true;
                        
                    } 

                }
            }

           var dados = GerenciaEmpresa.Instance.Banco.Select(query);

            groupResultados.Height = 25 + (dados.Rows.Count * 25);
            for (int j = 0; j < dados.Rows.Count; j++)
            {
                for (int i = 0; i < numCampos; i++)
                {
                    var label = new Label();
                    label.Width = 95;
                    label.Location = new Point(10 + (100 * i), 20+(j*25));
                    label.BackColor = ((j % 2) != 0) ? Color.LightSkyBlue : Color.SkyBlue;
                    label.Text = dados.Rows[j].ItemArray[i] != null? dados.Rows[j].ItemArray[i].ToString(): "";
                    groupResultados.Controls.Add(label);
                }
                
            }

        }
    }
}
