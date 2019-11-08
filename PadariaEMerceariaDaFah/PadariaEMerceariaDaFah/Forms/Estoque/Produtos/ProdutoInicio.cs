using Formulario;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos
{
    public partial class ProdutoInicio : Form
    {
        public string nomeFornecedor;
        public int? codFornecedor;

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
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Produtos)
            {
                list_produto.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            if (Selected != 0)
            {
                var fornecedoreSelected = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == Selected);
                if (fornecedoreSelected != null)
                {
                    var index = list_produto.Items.IndexOf(fornecedoreSelected.Codigo.ToString() + " | " + fornecedoreSelected.Nome);
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
            lista_ingredientes.Items.Clear();
            int selectedProduto;
            if (list_produto.SelectedItem != null)
            {
                selectedProduto = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == selectedProduto);
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == produto.Codigo);

                nome_produto.Text = produto.Nome;
                des_text.Text = produto.Descricao;
                valor_text.Text = produto.Valor.ToString();

                revendido.Checked = produto.Tipo == Enums.Produto_tipo.fabricado? false : true;
                fabricado.Checked = produto.Tipo == Enums.Produto_tipo.fabricado ? true : false;

                group_ingredientes.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? true : false;
                linkFornecedores.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                fornecedores.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                //Fornecedor.Text = revendido.Checked == false ? "" : fornecedor.Nome;
                Fornecedor.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;

                if (produto.Tipo == Enums.Produto_tipo.fabricado)
                {
                    foreach (var item in produto.Ingredientes)
                    {
                        lista_ingredientes.Items.Add(item.ToString());
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

                var query = "DELETE FROM ESTOQUE_PRODUTO WHERE CODIGO = '" + selectedFunc+"'";
                Comercio.GerenciaEmpresa.Instance.Banco.Delete(query);

                UpdateForm(selectedFunc);
            }
        }

        private void save_edit_produto_Click(object sender, EventArgs e)
        {
            if (list_produto.SelectedItem != null)
            {
                var selectedProduto = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == selectedProduto);

                produto.Nome = nome_produto.Text;
                produto.Valor = Convert.ToDouble(valor_text.Text);
                produto.Descricao = des_text.Text;
                produto.codFornecedor = codFornecedor;

                if(codFornecedor == null)
                {
                    produto.Ingredientes.Clear();
                    foreach(var item in lista_ingredientes.Items)
                    {
                        produto.Ingredientes.Add(item.ToString());
                    }
                }

                UpdateForm(selectedProduto);

                lista_ingredientes.Items.Clear();

                Comercio.GerenciaEmpresa.Instance.SalvarProdutos(Comercio.GerenciaEmpresa.Instance.Produtos);

                MessageBox.Show("Salvo com sucesso.");

                var query = "UPDATE ESTOQUE_PRODUTO SET name = '" + nome_produto.Text + "', description = '" + des_text.Text + "', tipo =" + (fabricado.Checked ? 0 : 1) + ", valor = " + Convert.ToDouble(valor_text.Text) + ", ingredientes = '' , cod_fornecedor = '" + codFornecedor + "' WHERE CODIGO = " + produto.Codigo + ";";

                Comercio.GerenciaEmpresa.Instance.Banco.Update(query);

                if (codFornecedor == null)
                {
                    foreach (var item in produto.Ingredientes)
                    {
                        lista_ingredientes.Items.Add(item.ToString());
                    }
                }
            }
        }

        private void revendido_CheckedChanged(object sender, EventArgs e)
        {
            if(revendido.Checked == true)
            {
                fabricado.Checked = false;

                lista_ingredientes.Items.Clear();

                group_ingredientes.Visible = false;

                linkFornecedores.Visible = true;
                fornecedores.Visible = true;
                Fornecedor.Visible = true;
            }
        }

        private void fabricado_CheckedChanged(object sender, EventArgs e)
        {
            if(fabricado.Checked == true)
            {
                revendido.Checked = false;

                int selectedProduto;

                selectedProduto = Convert.ToInt32(list_produto.SelectedItem.ToString().Split('|').First());
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == selectedProduto);

                produto.codFornecedor = null;

                group_ingredientes.Visible = true;

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
            lista_ingredientes.Items.Add(text_ingredientes.Text);
            text_ingredientes.Text = "";
        }
    }
}
