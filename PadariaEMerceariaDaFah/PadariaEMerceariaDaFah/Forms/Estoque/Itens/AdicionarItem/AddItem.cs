using PadariaEMerceariaDaFah.Forms.Estoque.Itens.AdicionarItem.ListaProdutos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Itens
{
    public partial class Itens : Form
    {
        public int cod_produto;
        public Itens()
        {
            InitializeComponent();
        }

        private void qtd_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';

                if (qtd_text.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void linkProdutos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var produtos = new ProdutosList();
            produtos.ShowDialog();

            cod_produto = ProdutosList.cod_Produto;
            produto_nome.Text = ProdutosList.nome_produto;
        }

        private void add_ingrediente_salvar_Click(object sender, System.EventArgs e)
        {
            var itens = Comercio.GerenciaEmpresa.Instance.EstoqueItens;

            Comercio.GerenciaEmpresa.Instance.Banco.Insert("INSERT INTO ITEM_ESTOQUE VALUES(default, " +
                cod_produto + ", " +
                "STR_TO_DATE('"+ data_validade.Value.Date + "','%d/%m/%Y'), " +
                qtd_text.Text + ");");

            var cod = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM ITEM_ESTOQUE WHERE COD_ITEM = (SELECT MAX(COD_ITEM) FROM ITEM_ESTOQUE);").FirstOrDefault();

            var codItem = cod == null ? 1 : cod.Codigo;
            Comercio.GerenciaEmpresa.Instance.AdicionarEstoqueItens(new Classes.EstoqueItem(codItem, cod_produto, data_validade.Value.Date, Convert.ToInt32(qtd_text.Text)));

            Comercio.GerenciaEmpresa.Instance.SalvarEstoqueItens(Comercio.GerenciaEmpresa.Instance.EstoqueItens);

            this.Close();
        }
    }
}
