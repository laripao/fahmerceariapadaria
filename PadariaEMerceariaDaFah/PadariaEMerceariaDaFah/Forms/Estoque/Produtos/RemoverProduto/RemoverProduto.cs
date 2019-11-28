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
                Comercio.GerenciaEmpresa.Instance.Banco.Insert("UPDATE ESTOQUE_PRODUTO SET ATIVO = 0 WHERE CODIGO =" + produto.Codigo + " ;");
                MessageBox.Show("Produto Removido.");
                this.Close();
            }
        }

        private void RemoverProduto_Load(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == Code);

                var fornecedor = Comercio.GerenciaEmpresa.Instance.CarregarFornecedoresBanco("SELECT * FROM gerencia_fornecedor GF JOIN estoque_produto_revendido EPR ON (GF.codigo = EPR.cod_fornecedor) WHERE cod_produto = '" + produto.Codigo + "';").FirstOrDefault();

                nome_produto.Text = produto.Nome;
                des_text.Text = produto.Descricao;
                valor_text.Text = produto.Valor.ToString();

                revendido.Checked = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                fabricado.Checked = produto.Tipo == Enums.Produto_tipo.fabricado ? true : false;

                group_ingredientes.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? true : false;
                fornecedores.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;
                Fornecedor.Text = fornecedor == null ? "" : fornecedor.Nome;
                Fornecedor.Visible = produto.Tipo == Enums.Produto_tipo.fabricado ? false : true;


                if (produto.Tipo == Enums.Produto_tipo.fabricado)
                {
                    var relacaoProduto = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoProdutoUtilizaIngredientesBanco("SELECT * FROM UTILIZA WHERE COD_PRODUTO = '" + produto.Codigo + "';").FirstOrDefault();
                    int relacaoIngrediente = relacaoProduto == null ? 0 : relacaoProduto.CodIngrediente;
                    var ingrediente = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("SELECT * FROM ESTOQUE_INGREDIENTE WHERE CODIGO = '" + relacaoIngrediente + "';");
                    var func = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == produto.codFuncionario);

                    QuemFabricou.Text = func.Nome;
                    
                    lista_ingredientes.Items.Clear();
                    foreach (var item in ingrediente)
                    {
                        lista_ingredientes.Items.Add(item.Codigo.ToString() + "|" + item.Nome + "|" + item.Quantidade);
                    }
                }
            }
        }
    }
}
