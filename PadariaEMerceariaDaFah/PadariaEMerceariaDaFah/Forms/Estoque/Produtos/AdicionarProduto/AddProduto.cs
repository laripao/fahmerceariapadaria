using PadariaEMerceariaDaFah.Enums;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.AddProduto
{
    public partial class AddProduto : Form
    {
        public int? codFornecedor;
        public string nomeFornecedor;
        public string nomeFuncionario;
        public int? codFuncionario = 0;

        public AddProduto()
        {
            InitializeComponent();
        }

        private void revendido_CheckedChanged(object sender, EventArgs e)
        {
            if (revendido.Checked == true)
            {
                fabricado.Checked = false;
                linkFornecedores.Visible = true;
                fornecedores.Visible = true;
                Fornecedor.Visible = true;
                fabricado_funcionario.Visible = false;
                QuemFabricou.Visible = false;
                linkFuncionario.Visible = false;

                group_ingredientes.Visible = false;
            }
        }

        private void linkFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fornecedor = new FornecedoresList();
            FornecedoresList.cod_fornecedor = 0;
            FornecedoresList.nome_fornecedor = "";

            fornecedor.ShowDialog();


            codFornecedor = FornecedoresList.cod_fornecedor;
            nomeFornecedor = FornecedoresList.nome_fornecedor;

            Fornecedor.Text = nomeFornecedor;
        }

        

        private void fabricado_CheckedChanged(object sender, EventArgs e)
        {
            if (fabricado.Checked == true)
            {
                revendido.Checked = false;
                linkFornecedores.Visible = false;
                fornecedores.Visible = false;
                Fornecedor.Visible = false;
                fabricado_funcionario.Visible = true;
                QuemFabricou.Visible = true;
                linkFuncionario.Visible = true;

                group_ingredientes.Visible = true;
            }

        }

        private void add_produto_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_produto_salvar_Click(object sender, EventArgs e)
        {
            if(nome_produto.Text == "")
            {
                MessageBox.Show("Insira um nome do produto.");
            }
            if(valor_text.Text == "")
            {
                MessageBox.Show("Insira um valor.");
            }
            else
            {
                var produtos = Comercio.GerenciaEmpresa.Instance.Produtos;

                var query = "INSERT INTO ESTOQUE_PRODUTO VALUES(default" + ","
                            + " '" + nome_produto.Text + "' " + ","
                            + " '" + des_text.Text + "' " + ","
                            + (fabricado.Checked ? 0 : 1) + ", "
                            + Convert.ToDouble(valor_text.Text) + ", " +
                            "'" + codFuncionario + "', default);";

                Comercio.GerenciaEmpresa.Instance.Banco.Insert(query);

                Produto_tipo tipo = fabricado.Checked ? Produto_tipo.fabricado : Produto_tipo.revendido;

                var codProduto = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM laripaos.ESTOQUE_PRODUTO WHERE CODIGO = (SELECT MAX(CODIGO) FROM laripaos.ESTOQUE_PRODUTO);").FirstOrDefault();

                int cod = codProduto == null ? 1 : codProduto.Codigo;


                var novoProduto = new Comercio.Produto(cod, nome_produto.Text, des_text.Text, tipo, Convert.ToDouble(valor_text.Text), codFornecedor);

                Comercio.GerenciaEmpresa.Instance.AdicionarProduto(novoProduto);
                Comercio.GerenciaEmpresa.Instance.SalvarProdutos(Comercio.GerenciaEmpresa.Instance.Produtos);


                if (revendido.Checked == true)
                {
                    var queryProdRevendido = ("INSERT INTO ESTOQUE_PRODUTO_REVENDIDO VALUES( default, "
                        + " '" + cod + "', "
                        + " '" + codFornecedor + "', "
                        + " '" + Convert.ToDouble(valor_text.Text) + "');");

                    Comercio.GerenciaEmpresa.Instance.Banco.Insert(queryProdRevendido);
                }
                else
                {
                    foreach (var item in lista_ingredientes.Items)
                    {
                        string[] aux = item.ToString().Split('|');
                        int cod_ingrediente = Convert.ToInt32(aux[0].Trim());
                        double qtd_ingrediente = Convert.ToDouble(aux[1].Trim());

                        var queryItens = ("INSERT INTO UTILIZA VALUES( default,"
                            + " '" + cod + "', "
                            + " '" + cod_ingrediente + "','" +
                            +qtd_ingrediente + "');");

                        Comercio.GerenciaEmpresa.Instance.Banco.Insert(queryItens);
                    }
                }

                this.Close();
            }
        }

        private void AddProduto_Load(object sender, EventArgs e)
        {
            fabricado.Checked = true;
            Fornecedor.Enabled = false;
        }

        private void add_ingredientes_Click(object sender, EventArgs e)
        {
            var ingredientes = new IngredientesList();
            ingredientes.ShowDialog();

            if(ingredientes.nomeIngrediente != null)
            {
                lista_ingredientes.Items.Add(ingredientes.codIngrediente + "|" + ingredientes.nomeIngrediente + "|" + ingredientes.qtdIngrediente);
            }
        }

        private void Fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_ingredientes_Click(object sender, EventArgs e)
        {
            lista_ingredientes.Items.RemoveAt(lista_ingredientes.SelectedIndex);
        }

        private void valor_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';

                if (valor_text.Text.Contains("."))
                {
                    e.Handled = true; 
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void linkFuncionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var funcionario = new FuncionariosList();
            FuncionariosList.cod_funcionario = 0;
            FuncionariosList.nome_funcionario = "";
            funcionario.ShowDialog();

            nomeFuncionario = FuncionariosList.nome_funcionario;
            codFuncionario = FuncionariosList.cod_funcionario;

            QuemFabricou.Text = nomeFuncionario;
        }

        private void QuemFabricou_TextChanged(object sender, EventArgs e)
        {

        }

        private void fabricado_funcionario_Click(object sender, EventArgs e)
        {

        }
    }
}
