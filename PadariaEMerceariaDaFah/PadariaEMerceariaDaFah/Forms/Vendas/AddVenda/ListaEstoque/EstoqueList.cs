using PadariaEMerceariaDaFah.Forms.Estoque;
using PadariaEMerceariaDaFah.Forms.Estoque.Itens;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaEstoque
{
    public partial class EstoqueList : Form
    {
        public int codItem;
        public string nomeItem;
        public double valorItem;
        public int quantidade;
        public EstoqueList()
        {
            InitializeComponent();
        }

        private void add_estoque_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_addEstoque_Click(object sender, EventArgs e)
        {
            var item = new Itens();
            item.ShowDialog();
            UpdateForm();
        }

        private void go_estoque_Click_Click(object sender, EventArgs e)
        {
            var item = new EstoqueInicio();
            item.ShowDialog();
            UpdateForm();
        }
        
        private void UpdateForm(int Selected = 0)
        {
            list_estoque.Items.Clear();

            var itens = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM ITEM_ESTOQUE WHERE QUANTIDADE_PRODUTO >= " + quantidade + ";");

            foreach (var item in itens)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == item.CodProduto);

                list_estoque.Items.Add(item.Codigo.ToString() + "|" + produto.Nome + "|" + produto.Valor.ToString());
            }

            var itemSelected = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == Selected);

            if (Selected != 0 && itemSelected != null)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == itemSelected.CodProduto);
                if (itemSelected != null)
                {
                    var index = list_estoque.Items.IndexOf(itemSelected.Codigo.ToString() + "|" + produto.Nome + "|" + produto.Valor.ToString());
                    list_estoque.SetSelected(index, true);
                }
            }
        }

        private void list_estoque_DoubleClick(object sender, EventArgs e)
        {
            if (list_estoque != null)
            {
                string[] aux = list_estoque.SelectedItem.ToString().Split('|');

                codItem = Convert.ToInt32(aux[0].Trim());
                nomeItem = aux[1];
                valorItem = Convert.ToDouble(aux[2]);

                this.Close();
            }
        }

        private void EstoqueList_Load(object sender, EventArgs e)
        {
            nomeItem = "";
            codItem = 0;
            valorItem = 0;

            list_estoque.Items.Clear();

            var estoque = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM ITEM_ESTOQUE;");

            foreach (var item in estoque)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT * FROM laripaos.estoque_produto WHERE CODIGO = " + item.CodProduto + ";").FirstOrDefault();
                list_estoque.Items.Add(item.Codigo.ToString() + "|" + produto.Nome + "|" + produto.Valor.ToString());
            }
        }

        private void ok_button_qtd_Click(object sender, EventArgs e)
        {
            quantidade_text.Enabled = false;
            list_estoque.Enabled = true;
            quantidade = Convert.ToInt32(quantidade_text.Text);

            Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM ITEM_ESTOQUE WHERE QUANTIDADE_PRODUTO >= " + quantidade +";");
            UpdateForm();
        }

        private void quantidade_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
