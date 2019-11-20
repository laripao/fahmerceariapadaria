using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.RemoverProduto
{
    public partial class RemoverProduto : Form
    {
        public int Code;
        public RemoverProduto(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void cancel_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == Code);
                Comercio.GerenciaEmpresa.Instance.Produtos.Remove(produto);
                Comercio.GerenciaEmpresa.Instance.SalvarProdutos(Comercio.GerenciaEmpresa.Instance.Produtos);
                MessageBox.Show("Produto Removido.");
                this.Close();
            }
        }

        private void RemoverProduto_Load(object sender, EventArgs e)
        {
            if(Code != 0)
            {
                //var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == Code);
                //var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == Code);

                //nome_produto.Text = produto.Nome;
                //des_text.Text = produto.Descricao;
                //valor_text.Text = produto.Valor.ToString();

                //revendido.Checked = produto.codFornecedor == null ? false : true;
                //fabricado.Checked = produto.codFornecedor == null ? true : false;

                //group_ingredientes.Visible = produto.codFornecedor == null ? true : false;
                //fornecedores.Visible = produto.codFornecedor == null ? false : true;
                //Fornecedor.Text = produto.codFornecedor == null ? "" : fornecedor.Nome;
                //Fornecedor.Visible = produto.codFornecedor == null ? false : true;

                //if (produto.codFornecedor == null)
                //{
                //    for (int i = 0; i < produto.Ingredientes.Count - 1; i++)
                //    {
                //        lista_ingredientes.Items.Add(produto.Ingredientes[i].ToString());
                //    }
                //}
            }
        }
    }
}
