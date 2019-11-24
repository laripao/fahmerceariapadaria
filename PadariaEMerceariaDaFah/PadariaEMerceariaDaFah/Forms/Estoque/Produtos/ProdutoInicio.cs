using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaProdutos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos
{
    public partial class ProdutoInicio : Form
    {
        public string nomeFornecedor;
        public string nomeFuncionario;
        public int? codFornecedor;
        public int? codFuncionario;

        public ProdutoInicio()
        {
            InitializeComponent();
        }

        private void add_produto_Click(object sender, EventArgs e)
        {
            var produto = new AddProduto.AddProduto();
            produto.ShowDialog();
            UpdateForm();
        }

        private void UpdateForm(int Selected = 0)
        {
            list_produto.Items.Clear();

            var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM ESTOQUE_PRODUTO;");

            foreach (var item in produtos)
            {
                list_produto.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            if (Selected != 0)
            {
                var produtoSelected = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == Selected);
                if (produtoSelected != null)
                {
                    var index = list_produto.Items.IndexOf(produtoSelected.Codigo.ToString() + " | " + produtoSelected.Nome);
                    list_produto.SetSelected(index, true);
                }
            }
        }

        private void habilitar_edicao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                save_edit_produto.Enabled = true;
                remove_produto.Enabled = true;

                group_edit_produto.Enabled = true;
            }
            else
            {
                save_edit_produto.Enabled = false;
                remove_produto.Enabled = false;

                group_edit_produto.Enabled = false;
            }
        }

        private void list_produto_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedProduto;
            if (list_produto.SelectedItem != null)
            {
                selectedProduto = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == selectedProduto);

                var fornecedor = Comercio.GerenciaEmpresa.Instance.CarregarFornecedoresBanco("SELECT * FROM gerencia_fornecedor GF JOIN estoque_produto_revendido EPR ON (GF.codigo = EPR.cod_fornecedor) WHERE cod_produto = '" + produto.Codigo + "';").FirstOrDefault();

                nome_produto.Text = produto.Nome;
                des_text.Text = produto.Descricao;
                valor_text.Text = produto.Valor.ToString();

                revendido.Checked = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                fabricado.Checked = produto.Tipo == Enums.Produto_tipo.fabricado ? true : false;

                group_ingredientes.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? true : false;
                linkFornecedores.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                fornecedores.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                Fornecedor.Text = fornecedor == null ? "" : fornecedor.Nome;
                Fornecedor.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;


                if (produto.Tipo == Enums.Produto_tipo.fabricado)
                {
                    var relacaoProduto = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoProdutoUtilizaIngredientesBanco("SELECT * FROM UTILIZA WHERE COD_PRODUTO = '" + produto.Codigo + "';").FirstOrDefault();
                    int relacaoIngrediente = relacaoProduto == null ? 0 : relacaoProduto.CodIngrediente;
                    var ingrediente = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("SELECT * FROM ESTOQUE_INGREDIENTE WHERE CODIGO = '" + relacaoIngrediente + "';");

                    foreach (var item in ingrediente)
                    {
                        lista_ingredientes.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
                    }
                }
            }
        }

        private void ProdutoInicio_Load(object sender, EventArgs e)
        {
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Produtos)
            {
                list_produto.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            HabilitarEdicao();
        }

        private void remove_produto_Click(object sender, EventArgs e)
        {
            if (list_produto.SelectedItem != null)
            {
                var selectedFunc = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var remove = new RemoverProduto.RemoverProduto(selectedFunc);
                remove.ShowDialog();
                UpdateForm(selectedFunc);

                var query = "DELETE FROM ESTOQUE_PRODUTO WHERE CODIGO = '" + selectedFunc + "'";
                Comercio.GerenciaEmpresa.Instance.Banco.Delete(query);
            }
        }

        private void save_edit_produto_Click(object sender, EventArgs e)
        {
            if (list_produto.SelectedItem != null)
            {
                var selectedProduto = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == selectedProduto);

                int mudou = produto.Tipo == Enums.Produto_tipo.revendido && revendido.Checked == true ? 0 : 1;

                produto.Nome = nome_produto.Text;
                produto.Valor = Convert.ToDouble(valor_text.Text);
                produto.Descricao = des_text.Text;
                produto.Tipo = revendido.Checked == true ? Enums.Produto_tipo.revendido : Enums.Produto_tipo.fabricado;

                Comercio.GerenciaEmpresa.Instance.AtualizarProduto(produto);

                MessageBox.Show("Salvo com sucesso.");

                var query = "UPDATE ESTOQUE_PRODUTO SET name = '" + nome_produto.Text + "', description = '" + des_text.Text + "', tipo =" + (fabricado.Checked ? 0 : 1) + ", valor = " + Convert.ToDouble(valor_text.Text) + ", COD_FUNCIONARIO = '" + codFuncionario + "' WHERE CODIGO = '" + produto.Codigo + "';";

                Comercio.GerenciaEmpresa.Instance.Banco.Update(query);

                if (mudou == 1)
                {
                    if (revendido.Checked == true)
                    {
                        var queryProdRevendido = ("INSERT INTO ESTOQUE_PRODUTO_REVENDIDO VALUES( default, "
                            + " '" + produto.Codigo + "', "
                            + " '" + codFornecedor + "', "
                            + " '" + Convert.ToDouble(valor_text.Text) + "');");

                        Comercio.GerenciaEmpresa.Instance.Banco.Insert(queryProdRevendido);

                        var queryDeleta = "DELETE FROM UTILIZA WHERE COD_PRODUTO = '" + produto.Codigo + "'";
                        Comercio.GerenciaEmpresa.Instance.Banco.Delete(queryDeleta);
                    }
                    else
                    {
                        foreach (var item in lista_ingredientes.Items)
                        {
                            string[] aux = item.ToString().Split('|');
                            int cod_ingrediente = Convert.ToInt32(aux[0].Trim());
                            double qtd_ingrediente = Convert.ToDouble(aux[1].Trim());

                            var queryItens = ("INSERT INTO UTILIZA VALUES( default,"
                                + " '" + produto.Codigo + "', "
                                + " '" + cod_ingrediente + "'" +
                                " '" + qtd_ingrediente + "');");

                            Comercio.GerenciaEmpresa.Instance.Banco.Insert(queryItens);
                        }

                        var queryDeleta = "DELETE FROM ESTOQUE_PRODUTO_REVENDIDO WHERE cod_produto = '" + produto.Codigo + "'";
                        Comercio.GerenciaEmpresa.Instance.Banco.Delete(queryDeleta);
                    }
                }
                else
                {
                    if (revendido.Checked == true)
                    {
                        var queryProdRevendido = ("UPDATE ESTOQUE_PRODUTO_REVENDIDO SET " +
                            "COD_FORNECEDOR = '" + codFornecedor + "', " +
                            "VALOR = '" + Convert.ToDouble(valor_text.Text) + "' " +
                            "WHERE COD_PRODUTO = '" + produto.Codigo + "';");

                        Comercio.GerenciaEmpresa.Instance.Banco.Insert(queryProdRevendido);
                    }
                    else
                    {
                        foreach (var item in lista_ingredientes.Items)
                        {
                            string[] aux = item.ToString().Split('|');
                            int cod_ingrediente = Convert.ToInt32(aux[0].Trim());
                            double qtd_ingrediente = Convert.ToDouble(aux[1].Trim());

                            var queryItens = ("UPDATE UTILIZA SET"
                                + " COD_INGREDIENTE = '" + cod_ingrediente + "'," +
                                "QUANTIDADE = '" + qtd_ingrediente + "'" +
                                "WHERE COD_PRODUTO = '" + produto.Codigo + "';");

                            Comercio.GerenciaEmpresa.Instance.Banco.Insert(queryItens);
                        }

                    }

                }
                UpdateForm(selectedProduto);
            }
        }

        private void revendido_CheckedChanged(object sender, EventArgs e)
        {
            if (revendido.Checked == true)
            {
                fabricado.Checked = false;

                lista_ingredientes.Items.Clear();

                group_ingredientes.Visible = false;
                fabricado_funcionario.Visible = false;
                QuemFabricou.Visible = false;
                linkFuncionario.Visible = false;

                linkFornecedores.Visible = true;
                fornecedores.Visible = true;
                Fornecedor.Visible = true;
            }
        }

        private void fabricado_CheckedChanged(object sender, EventArgs e)
        {
            if (fabricado.Checked == true)
            {
                revendido.Checked = false;

                int selectedProduto;

                selectedProduto = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == selectedProduto);

                group_ingredientes.Visible = true;
                fabricado_funcionario.Visible = true;
                QuemFabricou.Visible = true;
                linkFuncionario.Visible = true;

                linkFornecedores.Visible = false;
                fornecedores.Visible = false;
                Fornecedor.Visible = false;
            }
        }

        private void linkFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fornecedor = new FornecedoresList();
            fornecedor.ShowDialog();

            codFornecedor = FornecedoresList.cod_fornecedor;
            nomeFornecedor = FornecedoresList.nome_fornecedor;

            Fornecedor.Text = nomeFornecedor;
        }

        private void add_ingredientes_Click(object sender, EventArgs e)
        {

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

        private void remove_ingredientes_Click(object sender, EventArgs e)
        {
            lista_ingredientes.Items.RemoveAt(lista_ingredientes.SelectedIndex);
        }

        private void add_ingredientes_Click_1(object sender, EventArgs e)
        {
            var ingredientes = new IngredientesList();
            ingredientes.ShowDialog();

            if(ingredientes.nomeIngrediente != null)
            {
                lista_ingredientes.Items.Add(ingredientes.codIngrediente + "|" + ingredientes.nomeIngrediente + "|" + ingredientes.qtdIngrediente);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
}
