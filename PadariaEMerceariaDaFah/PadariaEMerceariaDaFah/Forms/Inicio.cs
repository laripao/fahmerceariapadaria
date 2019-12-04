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
using PadariaEMerceariaDaFah.Classes;

using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PadariaEMerceariaDaFah.Forms.Vendas;

namespace PadariaEMerceariaDaFah
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void Inicio_Load(object sender, EventArgs e)
        {

            Form est = new EstoqueInicio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panel_produto.Controls.Add(est);
            est.Show();

            Form vend = new VendasInicio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panel_vendas.Controls.Add(vend);
            vend.Show();

            var gerenciaEmpresa = new GerenciaEmpresa();

            gerenciaEmpresa.Banco.Insert("create database if not exists laripaos");

            this.HorizontalScroll.Enabled = true;

            gerenciaEmpresa.Banco = new Formulario.DB("Laripaos");

            

            gerenciaEmpresa.Banco.Insert(
                "SET default_storage_engine= INNODB;"
                + "CREATE TABLE IF NOT EXISTS GERENCIA_FORNECEDOR (    codigo INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    description TEXT,    telefone VARCHAR(20),    celular VARCHAR(20),    email VARCHAR(100),    ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS GERENCIA_FUNCIONARIO (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    CPF VARCHAR(20) NOT NULL UNIQUE,    NAME VARCHAR(45),    FUNCAO VARCHAR(50),    TELEFONE VARCHAR(20),    CELULAR VARCHAR(10),    EMAIL VARCHAR(100),    RUA VARCHAR(20),    CIDADE VARCHAR(20),    ESTADO VARCHAR(20),    PAIS VARCHAR(20),   NUMERO INT,   CEP VARCHAR(20),  ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO (    codigo INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    description TEXT,    tipo INT,    valor DOUBLE,    COD_FUNCIONARIO INT, ativo TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_PRODUTO_REVENDIDO (	CODIGO INT PRIMARY KEY AUTO_INCREMENT,    cod_produto INT NOT NULL,    cod_fornecedor INT NOT NULL,    valor DOUBLE,    CONSTRAINT `fk_supre_fornecedo` FOREIGN KEY (`COD_FORNECEDOR`) REFERENCES GERENCIA_FORNECEDOR (`CODIGO`),	CONSTRAINT `fk_supre_produto` FOREIGN KEY (`COD_PRODUTO`) REFERENCES  ESTOQUE_PRODUTO (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS ESTOQUE_INGREDIENTE (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    name VARCHAR(45),    validade DATE NOT NULL,    valor DOUBLE,    quantidade INT,    ATIVO TINYINT(1) DEFAULT 1);"
                + "CREATE TABLE IF NOT EXISTS FORNECE (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_FORNECEDOR INT NOT NULL,    COD_INGREDIENTE INT NOT NULL,    CONSTRAINT `fk_fornece_fornecedor` FOREIGN KEY ( `COD_FORNECEDOR` ) REFERENCES GERENCIA_FORNECEDOR ( `CODIGO` ),	CONSTRAINT `fk_fornece_ingrediente` FOREIGN KEY ( `COD_INGREDIENTE` ) REFERENCES ESTOQUE_INGREDIENTE ( `CODIGO` ));"
                + "CREATE TABLE IF NOT EXISTS UTILIZA (    CODIGO INT PRIMARY KEY AUTO_INCREMENT,    COD_PRODUTO INT NOT NULL,    COD_INGREDIENTE INT NOT NULL,    QUANTIDADE_UTILIZADA INT NOT NULL,    CONSTRAINT `fk_utiliza_produto` FOREIGN KEY (`COD_PRODUTO`) REFERENCES ESTOQUE_PRODUTO (`CODIGO`),	CONSTRAINT `fk_utiliza_ingrediente` FOREIGN KEY (`COD_INGREDIENTE`) REFERENCES ESTOQUE_INGREDIENTE (`CODIGO`));"
                + "CREATE TABLE IF NOT EXISTS ITEM_ESTOQUE (    COD_ITEM INT PRIMARY KEY AUTO_INCREMENT,    COD_PRODUTO INT NOT NULL,    VALIDADE_PRODUTO DATE,    QUANTIDADE_PRODUTO INT);"
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
            if (GerenciaEmpresa.Instance.CarregarEstoqueItens() != null)
            {
                GerenciaEmpresa.Instance.EstoqueItens.AddRange(GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM laripaos.item_estoque;"));
            }
            GerenciaEmpresa.Instance.Clientes.AddRange(GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM CLIENTE;"));

            var Vencimento = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM laripaos.item_estoque where validade_produto between CURDATE()-1 and CURDATE()+5;");

            foreach(var item in Vencimento)
            {
                var Produto = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM estoque_produto WHERE CODIGO = " + item.Codigo + ";").FirstOrDefault();
                list_vencimento.Items.Add(item.CodProduto + "|" + item.Validade + "|" + Produto.Nome);
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
            #region Limpando GroupBox
            groupBox1.Controls.Clear();
            groupResultados.Controls.Clear();
            #endregion

            #region Tabela Selecionada e Campos
            string tabelaSelecionada;

            switch (tabela.SelectedItem.ToString())
            {
                case "Produto":
                    tabelaSelecionada = "item_estoque";
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
                case "Venda":
                    tabelaSelecionada = "vendas";
                    break;
                case "Ingrediente":
                    tabelaSelecionada = "estoque_ingrediente";
                    break;
                default:
                    tabelaSelecionada = "SEM TABELA";
                    break;
            }

            var desc = Comercio.GerenciaEmpresa.Instance.Banco.Select("desc " + tabelaSelecionada);
            var maxLinhas = Convert.ToInt32(Comercio.GerenciaEmpresa.Instance.Banco.Select("SELECT COUNT(*) FROM " + tabelaSelecionada).Rows[0].ItemArray[0].ToString());
            var numCampos = desc.Rows.Count;

            string[,] campos = new string[2, numCampos];

            for (int i = 0; i < numCampos; i++)
            {
                campos[0, i] = desc.Rows[i].ItemArray[0].ToString();
                campos[1, i] = desc.Rows[i].ItemArray[1].ToString();
            }

            #endregion

            this.WindowState = FormWindowState.Maximized;
            groupBox1.Width = Width = 15 + (130 * numCampos);
            groupResultados.Width = 15 + (130 * numCampos);

            for (int i = 0; i < numCampos; i++)
            {
                #region Titulo Dos Campos
                var label = new Label();
                label.Text = campos[0, i].ToUpper().Replace("COD_", "");
                label.Width = 90;
                label.Location = new Point(25 + (120 * i), 25);
                label.TextAlign = ContentAlignment.MiddleCenter;
                #endregion

                #region Selecionar Filtros
                var checkBox = new CheckBox();
                checkBox.Checked = true;
                checkBox.Location = new Point(10+(120 * i), 25);
                checkBox.Name = label.Text;
                #endregion

                #region Funcao de Agregacao
                var comboBox = new ComboBox();
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.Width = 90;
                comboBox.Name = label.Text;
                comboBox.Location = new Point(10 + (120 * i), 75);
                comboBox.SelectedIndexChanged += (s, element) => {

                    var checkBoxesExistentes = new List<CheckBox>();

                    var comboBoxesExistentes = new List<ComboBox>();

                    for (int k = 0; k< groupBox1.Controls.Count; k++)
                    {
                        if (groupBox1.Controls[k].AccessibilityObject.Role == AccessibleRole.ComboBox)
                            comboBoxesExistentes.Add((ComboBox)groupBox1.Controls[k]);
                        if (groupBox1.Controls[k].AccessibilityObject.Role == AccessibleRole.CheckButton)
                            checkBoxesExistentes.Add((CheckBox)groupBox1.Controls[k]);
                    }

                    for (int k = 0; k < checkBoxesExistentes.Count; k++)
                    {
                        if (comboBoxesExistentes[k].SelectedItem == null || string.IsNullOrEmpty(comboBoxesExistentes[k].SelectedItem.ToString()))
                            checkBoxesExistentes[k].Checked = false;
                    }

                };

                if ((campos[1, i].Contains("int") && !campos[1, i].Contains("tinyint")) || campos[1, i].Contains("double") || campos[1, i].Contains("float"))
                {
                    comboBox.Items.Add("Maior");
                    comboBox.Items.Add("Menor");
                    comboBox.Items.Add("Média");
                    comboBox.Items.Add("Contar");
                    comboBox.Items.Add("Somar");
                }
                else if (campos[1, i].Contains("tinyint"))
                {
                    comboBox.Items.Add("Contar");
                }
                else                
                {
                    comboBox.Items.Add("Maior");
                    comboBox.Items.Add("Menor");
                    comboBox.Items.Add("Contar");
                }

                #endregion

                #region Botao e Lista do DropDownMultiSelect
                var listBox = new ListBox();
                listBox.Width = 110;
                listBox.Height = 100;
                listBox.Visible = false;
                listBox.Name = label.Text;
                listBox.SelectionMode = SelectionMode.MultiSimple;
                listBox.MouseLeave += (s, element ) => {

                    var listBoxSender = (ListBox)s; listBoxSender.Visible = false;
                    groupBox1.Height -= 30;
                    groupResultados.Location = new Point(groupResultados.Location.X, groupResultados.Location.Y - (30));


                };

                var button = new Button();
                button.Text = "Selecionar";
                button.Name = label.Text;
                button.Width = 110;
                button.Click += (s, element) => {

                    var buttonSender = (Button)s;
                    var listBoxes = new List<ListBox>();

                    for (int k = 0; k < groupBox1.Controls.Count; k++)
                    {
                        if (groupBox1.Controls[k].AccessibilityObject.Role == AccessibleRole.List)
                            listBoxes.Add((ListBox)groupBox1.Controls[k]);
                    }

                    var listBoxSelected = listBoxes.FirstOrDefault(x => x.Name == buttonSender.Name);
                    listBoxSelected.Visible = true;
                    groupResultados.Location = new Point(groupResultados.Location.X, groupResultados.Location.Y + (30));
                    groupBox1.Height += 30;
                    groupBox1.Controls.SetChildIndex(listBoxSelected, 0);


                };

                #endregion

                var valores = Comercio.GerenciaEmpresa.Instance.Banco.Select("SELECT DISTINCT(" + campos[0, i] + ") from " + tabelaSelecionada).Rows;
                for (int j = 0; j < valores.Count; j++)
                {
                    listBox.Items.Add(valores[j].ItemArray[0].ToString());
                }

                listBox.Location = new Point(10 + (120 * i), 50);
                button.Location = new Point(10 + (120 * i), 50);

                groupBox1.Controls.Add(label);
                groupBox1.Controls.Add(button);
                groupBox1.Controls.Add(listBox);
                groupBox1.Controls.Add(checkBox);
                groupBox1.Controls.Add(comboBox);

            }

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            #region Inicialização, Tabela Selecionada E Campos
            if (tabela.SelectedItem == null)
                return;
            var controles = groupBox1.Controls;
            groupResultados.Controls.Clear();

            string tabelaSelecionada;
            
            switch (tabela.SelectedItem.ToString())
            {
                case "Produto":
                    tabelaSelecionada = "item_estoque";
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
                case "Venda":
                    tabelaSelecionada = "vendas";
                    break;
                case "Ingrediente":
                    tabelaSelecionada = "estoque_ingrediente";
                    break;
                default:
                    tabelaSelecionada = "SEM TABELA";
                    break;
            }

            var desc = GerenciaEmpresa.Instance.Banco.Select("desc " + tabelaSelecionada);
            var maxLinhas = Convert.ToInt32(GerenciaEmpresa.Instance.Banco.Select("SELECT COUNT(*) FROM " + tabelaSelecionada).Rows[0].ItemArray[0].ToString());
            var numCampos = desc.Rows.Count;

            string[,] campos = new string[2,numCampos];

            for (int i = 0; i < numCampos; i++)
            {
                campos[0,i] = desc.Rows[i].ItemArray[0].ToString();
                campos[1, i] = desc.Rows[i].ItemArray[1].ToString();
            }

            #endregion

            string query;

            #region Listas, CheckBoxes e ComboBoxes
            List<ListBox> Listas = new List<ListBox>();
            List<CheckBox> checkBoxes = new List<CheckBox>();
            List<ComboBox> comboBoxes = new List<ComboBox>();
            for (int i =0; i< controles.Count; i++)
            {
                if(controles[i].AccessibilityObject.Role == AccessibleRole.List)
                    Listas.Add((ListBox)controles[i]);
                if (controles[i].AccessibilityObject.Role == AccessibleRole.CheckButton)
                    checkBoxes.Add((CheckBox)controles[i]);
                if (controles[i].AccessibilityObject.Role == AccessibleRole.ComboBox)
                    comboBoxes.Add((ComboBox)controles[i]);
            }
            #endregion

            var camposSelecionados = CamposSelecionados(tabelaSelecionada, checkBoxes, campos, comboBoxes);

            #region Query
            query = "SELECT "+camposSelecionados+" FROM " + tabelaSelecionada;
            if (Listas.Any(x => x.SelectedItems.Count > 0 ))
            {
                query = query + " WHERE ";
                var and = false;
                for(int i = 0; i< numCampos; i++)
                {
                    var listaSelecionado = Listas.FirstOrDefault(x => x.Name == checkBoxes[i].Name);

                    if (listaSelecionado.SelectedItems.Count > 0)
                    {
                        if (and)
                        {
                            query = query + " AND ";
                        }
                        query = query + campos[0,i] + " in ( " + ClausulaIn(listaSelecionado) + ") ";
                        and = true;
                        
                    } 

                }
            }

            #endregion

            var dados = GerenciaEmpresa.Instance.Banco.Select(query);

            #region Exibicao dos Dados
            groupResultados.Height = 100 + (dados.Rows.Count * 25);
            var count = 0;
            for (int i = 0; i < campos.Length/2; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    var label = new Label();
                    label.Width = 110;
                    label.Location = new Point(10 + (120 * count), 20);
                    label.BackColor = Color.Gray;
                    label.Text = campos[0,i];
                    groupResultados.Controls.Add(label);
                    count++;
                }
            }

            for (int j = 0; j < dados.Rows.Count; j++)
            {
                for (int i = 0; i < checkBoxes.Count(x=> x.Checked); i++)
                {
                    
                        var label = new Label();
                        label.Width = 110;
                        label.Location = new Point(10 + (120 * i), 45 + (j * 25));
                        label.BackColor = ((j % 2) != 0) ? Color.LightSkyBlue : Color.SkyBlue;
                        label.Text = dados.Rows[j].ItemArray[i] != null ? dados.Rows[j].ItemArray[i].ToString() : "";
                        groupResultados.Controls.Add(label);
                    
                }
                
            }

            #endregion

        }

        public string CamposSelecionados(string table, List<CheckBox> checkBoxes, string[,] campos, List<ComboBox> combos)
        {
            string select = "";
            if (!checkBoxes.Any(x => x.Checked))
            {
                select = table + ".* ";
            }
            else
            {
                for (int i= 0; i< checkBoxes.Count; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        if (!string.IsNullOrEmpty(select))
                        {
                            select += ", ";
                        }
                        if(combos[i].SelectedItem != null && !string.IsNullOrEmpty(combos[i].SelectedItem.ToString()))
                            select += combos[i].SelectedItem.ToString().Agregacao() + "(" + table + "." + campos[0, i] + ") ";
                        else
                            select += table + "."+ campos[0,i]+" ";
                    }
                }
            }

            return select;
        }

        public string ClausulaIn(ListBox lista)
        {
            string result = "";
            if (lista.SelectedItems.Count > 0)
            {
                result = "";
                bool virgula = false;
                foreach (var item in lista.SelectedItems)
                {
                    if (virgula)
                        result += " , ";

                    if (item.ToString()!= null)
                    {
                        result +=  "'"+ item.ToString() + "'";
                        virgula = true;
                    }

                }
            }

            return result;
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            string dir;

            int tamFonte = 10;
            List<Label> labels = new List<Label>();
            for (int i = 0; i< groupResultados.Controls.Count; i++)
            {
                if (groupResultados.Controls[i].AccessibilityObject.Role == AccessibleRole.StaticText)
                    labels.Add(new Label() { Text = groupResultados.Controls[i].Text, BackColor = groupResultados.Controls[i].BackColor });
            }

            if (!labels.Any())
            {
                return;
            }
            folderBrowserDialog1.Description = "Selecione a pasta para salvar o Relatório.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                dir = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return;
            }

            var colunas = labels.Count(x => x.BackColor == Color.Gray);

            PdfDocument document = new PdfDocument(); //cria um documento pdf
            document.Info.Title = tabela.SelectedItem.ToString(); //título do pdf(meio obvio)
            PdfPage page = document.AddPage(); //cria uma página no pdf
            XGraphics gfx = XGraphics.FromPdfPage(page); //permite desenhar coisas no pdf
            XFont font = new XFont("Consolas", tamFonte, XFontStyle.Italic); //permite definir fonte, tamanho de fonte e estilo de fonte

            XTextFormatter tf = new XTextFormatter(gfx);

            var tamanho = page.Width.Point-40;
            var tamColuna = Math.Ceiling(tamanho / colunas);

            var altura = page.Height.Point-40;
            var paginas = Math.Ceiling(((labels.Count/colunas)* tamFonte) /(altura));

            int pageAtual = 0;

            for (int i = 0; i < labels.Count / colunas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if(paginas > 1 && (20+(i * tamFonte) + tamFonte - (pageAtual * altura)) > altura  )
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        tf = new XTextFormatter(gfx);
                        pageAtual++;
                        paginas--;
                    }
                    XRect rect = new XRect(20+(tamColuna * j), (20+(i * tamFonte)-(pageAtual*altura))>0? (20+(i * tamFonte) - (pageAtual * altura)) : 0, tamColuna, tamFonte);
                    var brush = new XSolidBrush(new XColor() {A=1, R = labels[(i * colunas) + j].BackColor.R, G = labels[(i * colunas) + j].BackColor.G, B = labels[(i * colunas) + j].BackColor.B });
                    gfx.DrawRectangle(brush, rect);
                    tf.Alignment = XParagraphAlignment.Left;
                    tf.DrawString(labels[(i * colunas) + j].Text, font, XBrushes.Black, rect, XStringFormats.TopLeft);
                    
                }
            }

            string filename = dir+"\\"+tabela.SelectedItem.ToString() +"-"+ DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")+".pdf";
            document.Save(filename);


        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Text=="Importante")
            {
                list_vencimento.Items.Clear();
                
                    var Vencimento = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM laripaos.item_estoque where validade_produto between CURDATE()-1 and CURDATE()+5;");

                foreach (var item in Vencimento)
                {
                    var Produto = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM estoque_produto WHERE CODIGO = " + item.Codigo + ";").FirstOrDefault();
                    list_vencimento.Items.Add(item.CodProduto + "|" + item.Validade + "|" + Produto.Nome);
                }
            }
        }
    }
}
