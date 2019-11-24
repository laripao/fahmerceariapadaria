using PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor;
using PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor.AddFornecedor;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores
{
    public partial class FornecedoresList : Form
    {
        public FornecedoresList()
        {
            InitializeComponent();
        }

        public static string nome_fornecedor;
        public static int cod_fornecedor;

        private void FornecedoresList_Load(object sender, EventArgs e)
        {
            list_fornecedor.Items.Clear();
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Fornecedores)
            {
                list_fornecedor.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
        }

        private void list_fornecedor_DoubleClick(object sender, EventArgs e)
        {
            if(list_fornecedor.SelectedItem != null)
            {
                string[] aux = list_fornecedor.SelectedItem.ToString().Split('|');
                nome_fornecedor = aux[1];
                cod_fornecedor = Convert.ToInt32(aux[0].Trim());
                Close();
            }
        }

        private void UpdateForm(int Selected = 0)
        {
            list_fornecedor.Items.Clear();

            var fornecedores = Comercio.GerenciaEmpresa.Instance.CarregarFornecedoresBanco("SELECT * FROM GERENCIA_FORNECEDOR WHERE ATIVO = 1;");

            foreach (var item in fornecedores)
            {
                list_fornecedor.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            if (Selected != 0)
            {
                var fornecedoreSelected = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == Selected);
                if (fornecedoreSelected != null)
                {
                    var index = list_fornecedor.Items.IndexOf(fornecedoreSelected.Codigo.ToString() + " | " + fornecedoreSelected.Nome);
                    list_fornecedor.SetSelected(index, true);
                }
            }
        }

        private void go_fornecedor_Click_Click(object sender, EventArgs e)
        {
            var fornecedor = new FornecedorInicio();
            fornecedor.ShowDialog();
            UpdateForm();
        }

        private void go_addFornecedor_Click(object sender, EventArgs e)
        {
            var fornecedor = new AddFornecedor();
            fornecedor.ShowDialog();
            UpdateForm();
        }

        private void add_produto_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

