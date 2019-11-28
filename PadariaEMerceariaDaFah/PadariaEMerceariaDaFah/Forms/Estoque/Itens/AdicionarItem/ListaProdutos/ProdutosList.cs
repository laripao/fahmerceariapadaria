using PadariaEMerceariaDaFah.Forms.Estoque.Produtos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Itens.AdicionarItem.ListaProdutos
{
    public partial class ProdutosList : Form
    {
        public static int cod_Produto;
        public static string nome_produto;

        public ProdutosList()
        {
            InitializeComponent();
        }

        private void add_produto_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_produto_Click_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoInicio();
            produto.ShowDialog();
            UpdateForm();
        }

        private void go_addProduto_Click(object sender, EventArgs e)
        {
            var produto = new AddProduto.AddProduto();
            produto.ShowDialog();
            UpdateForm();
        }

        private void ProdutosList_Load(object sender, EventArgs e)
        {
            list_produtos.Items.Clear();

            var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM ESTOQUE_PRODUTO WHERE ATIVO = 1;");

            foreach(var item in produtos)
            {
                list_produtos.Items.Add(item.Codigo + "|" + item.Nome);
            }
        }

        private void UpdateForm(int Selected = 0)
        {
            list_produtos.Items.Clear();

            var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM ESTOQUE_PRODUTO WHERE ATIVO = 1;");

            foreach (var item in produtos)
            {
                list_produtos.Items.Add(item.Codigo + "|" + item.Nome);
            }

            if(Selected != 0)
            {
                var produtoSelected = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == Selected);
                if(produtoSelected != null)
                {
                    var index = list_produtos.Items.IndexOf(produtoSelected.Codigo.ToString() + "|" + produtoSelected.Nome);
                    list_produtos.SetSelected(index, true);
                }
            }
        }

        private void list_produtos_DoubleClick(object sender, EventArgs e)
        {
            if (list_produtos.SelectedItem != null)
            {
                string[] aux = list_produtos.SelectedItem.ToString().Split('|');
                nome_produto = aux[1];

                cod_Produto = Convert.ToInt32(aux[0].Trim());
                Close();
                this.Close();
            }
        }
    }
}
