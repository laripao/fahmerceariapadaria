using System;
using System.Linq;
using System.Windows.Forms;
using PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes;
using PadariaEMerceariaDaFah.Forms.Estoque.Itens;
using PadariaEMerceariaDaFah.Forms.Estoque.Itens.AdicionarItem.ListaProdutos;
using PadariaEMerceariaDaFah.Forms.Estoque.Itens.RemoverItem;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos;

namespace PadariaEMerceariaDaFah.Forms.Estoque
{
    public partial class EstoqueInicio : Form
    {
        public int cod_produto = 0;
        public EstoqueInicio()
        {
            InitializeComponent();
        }

        private void EstoqueInicio_Load(object sender, EventArgs e)
        {
            list_estoque.Items.Clear();

            var itens = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM laripaos.ITEM_ESTOQUE;");

            foreach (var item in itens)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == item.CodProduto);

                list_estoque.Items.Add(item.Codigo.ToString() + "|" + produto.Nome);
            }
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                save_edit_item.Enabled = true;
                remove_item.Enabled = true;

                item_edicao.Enabled = true;
                produto_nome.Enabled = false;
            }
            else
            {
                save_edit_item.Enabled = false;
                remove_item.Enabled = false;

                item_edicao.Enabled = false;
            }
        }

        private void UpdateForm(int Selected = 0)
        {
            list_estoque.Items.Clear();

            var itens = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM ITEM_ESTOQUE;");

            foreach (var item in itens)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == item.CodProduto);

                list_estoque.Items.Add(item.Codigo.ToString() + "|" + produto.Nome);
            }
            
            var itemSelected = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == Selected);
            
            if (Selected != 0 && itemSelected != null)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == itemSelected.CodProduto);
                if (itemSelected != null)
                {
                    var index = list_estoque.Items.IndexOf(itemSelected.Codigo.ToString() + "|" + produto.Nome);
                    list_estoque.SetSelected(index, true);
                }
            }
        }


        private void add_item_Click(object sender, EventArgs e)
        {
            var item = new Itens.Itens();
            item.ShowDialog();
            UpdateForm();
        }

        private void go_produtos_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoInicio();
            produto.ShowDialog();
            UpdateForm();
        }

        private void go_ingredientes_Click(object sender, EventArgs e)
        {
            var ingrediente = new IngredientesInicio();
            ingrediente.ShowDialog();
            UpdateForm();
        }

        private void habilitar_edicao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void linkProdutos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var produtos = new ProdutosList();
            produtos.ShowDialog();

            cod_produto = ProdutosList.cod_Produto;
            produto_nome.Text = ProdutosList.nome_produto;
        }

        private void remove_item_Click(object sender, EventArgs e)
        {
            if (list_estoque.SelectedItem != null)
            {
                var selectedItem = Convert.ToInt32(list_estoque.SelectedItem.ToString().Split('|').First());
                var remove = new RemoverItem(selectedItem);
                remove.ShowDialog();
                UpdateForm(selectedItem);
            }
        }

        private void save_edit_item_Click(object sender, EventArgs e)
        {
            if(cod_produto == 0)
            {
                MessageBox.Show("Insira um produto.");
            }
            if(string.IsNullOrEmpty(qtd_text.Text))
            {
                MessageBox.Show("Insira um valor de quantidade.");
            }
            if(cod_produto != 0 && qtd_text.Text != "")
            {
                if (list_estoque.SelectedItem != null)
                {
                    var selectedItem = Convert.ToInt32(list_estoque.SelectedItem.ToString().Split('|').First());
                    var item = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == selectedItem);

                    item.CodProduto = cod_produto;
                    item.Quantidade = Convert.ToInt32(qtd_text.Text);
                    item.Validade = data_validade.Value.Date;

                    Comercio.GerenciaEmpresa.Instance.Banco.Update("UPDATE ITEM_ESTOQUE SET " +
                        "COD_PRODUTO =" + cod_produto + ", " +
                        "VALIDADE_PRODUTO = STR_TO_DATE('" + item.Validade + "','%d/%m/%Y'), " +
                        "QUANTIDADE_PRODUTO = " + item.Quantidade +
                        " WHERE COD_ITEM =" + item.Codigo + ";");

                    UpdateForm(selectedItem);

                    Comercio.GerenciaEmpresa.Instance.SalvarEstoqueItens(Comercio.GerenciaEmpresa.Instance.EstoqueItens);

                    MessageBox.Show("Salvo com sucesso.");
                }
            }
        }

        private void list_estoque_SelectedValueChanged(object sender, EventArgs e)
        {
            if(list_estoque.SelectedItem != null)
            {
                var selectedItem = Convert.ToInt32(list_estoque.SelectedItem.ToString().Split('|')[0]);
                var item = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == selectedItem);
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == item.CodProduto);

                produto_nome.Text = produto.Nome;
                data_validade.Value = item.Validade;
                qtd_text.Text = item.Quantidade.ToString();
                cod_produto = item.CodProduto;
            }
        }
    }
}
