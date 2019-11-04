using PadariaEMerceariaDaFah.Enums;
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

namespace PadariaEMerceariaDaFah.Forms.Estoque.AddProduto
{
    public partial class AddProduto : Form
    {
        public int? codFornecedor;
        public string nomeFornecedor;
        public List<string> Ingredientes = new List<string>();
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

                group_ingredientes.Visible = false;
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

        

        private void fabricado_CheckedChanged(object sender, EventArgs e)
        {
            if (fabricado.Checked == true)
            {
                revendido.Checked = false;
                linkFornecedores.Visible = false;
                fornecedores.Visible = false;
                Fornecedor.Visible = false;

                group_ingredientes.Visible = true;
            }

        }

        private void add_produto_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_produto_salvar_Click(object sender, EventArgs e)
        {
            var produtos = Comercio.GerenciaEmpresa.Instance.Produtos;
            var cod = 1;
            Produto_tipo tipo;

            if (produtos.Any())
            {
                cod = Comercio.GerenciaEmpresa.Instance.Produtos.Max(x => x.Codigo) + 1;
            }

                tipo = fabricado.Checked ? Produto_tipo.fabricado : Produto_tipo.revendido;
 

            var novoProduto = new Comercio.Produto(cod, nome_produto.Text, des_text.Text, tipo,Convert.ToDouble(valor_text.Text), codFornecedor, Ingredientes);

            Comercio.GerenciaEmpresa.Instance.AdicionarProduto(novoProduto);
            Comercio.GerenciaEmpresa.Instance.SalvarProdutos(Comercio.GerenciaEmpresa.Instance.Produtos);

            this.Close();
        }

        private void AddProduto_Load(object sender, EventArgs e)
        {
            fabricado.Checked = true;
            Fornecedor.Enabled = false;

            Ingredientes.Add("");
        }

        private void add_ingredientes_Click(object sender, EventArgs e)
        {
            lista_ingredientes.Items.Add(text_ingredientes.Text);
            Ingredientes.Add(text_ingredientes.Text);
            text_ingredientes.Text = "";
        }

        private void Fornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
