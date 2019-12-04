using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Vendas.RemoveVenda
{
    public partial class RemoveVenda : Form
    {
        public int Code;
        public RemoveVenda(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void add_ingrediente_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var venda = Comercio.GerenciaEmpresa.Instance.Vendas.FirstOrDefault(x => x.Codigo == Code);
                var relacao = Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos.FirstOrDefault(x => x.CodVenda == Code);
                try
                {
                    Comercio.GerenciaEmpresa.Instance.Vendas.Remove(venda);
                    Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos.Remove(relacao);
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("DELETE FROM VENDA_ITEM WHERE COD_VENDA = " + Code + ";");
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("DELETE FROM VENDAS WHERE CODIGO = " + Code + ";");
                    Comercio.GerenciaEmpresa.Instance.SalvarRelacaoVendaProduto(Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos);
                    Comercio.GerenciaEmpresa.Instance.SalvarVendas(Comercio.GerenciaEmpresa.Instance.Vendas);

                    MessageBox.Show("Item removido");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro encontrado:" + ex);
                }
                finally
                {
                    this.Close();
                }
            }
        }

        private void RemoveVenda_Load(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var funcionario = Comercio.GerenciaEmpresa.Instance.CarregarFuncionariosBanco("SELECT GF.* FROM GERENCIA_FUNCIONARIO GF INNER JOIN VENDAS VD ON VD.COD_FUNCIONARIO = GF.CODIGO WHERE VD.CODIGO = " + Code + ";").FirstOrDefault();
                var cliente = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT CL.* FROM CLIENTE CL INNER JOIN VENDAS VD ON VD.COD_CLIENTE = CL.CODIGO WHERE VD.CODIGO = " + Code + ";").FirstOrDefault();

                QuemVendeu.Text = funcionario.Nome;
                QuemComprou.Text = cliente.Nome;

                double valor = 0;

                var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT EP.* FROM VENDAS VD INNER JOIN VENDA_ITEM VI ON VD.CODIGO = VI.COD_VENDA " +
                                                                                                  "INNER JOIN ITEM_ESTOQUE IE ON IE.COD_ITEM = VI.COD_ITEM " +
                                                                                                  "INNER JOIN ESTOQUE_PRODUTO EP ON EP.CODIGO = IE.COD_PRODUTO " +
                                                                                                  "WHERE VD.CODIGO = " + Code + ";");

                foreach (var itemRelacao in produtos)
                {
                    var relacao = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoVendaProdutosBanco("SELECT VI.* FROM VENDA_ITEM VI INNER JOIN ITEM_ESTOQUE IE " +
                                                                                                        " ON VI.COD_ITEM = IE.COD_ITEM " +
                                                                                                        " WHERE IE.COD_PRODUTO = " + itemRelacao.Codigo + " AND VI.COD_VENDA = " + Code + ";").FirstOrDefault();

                    lista_produtos.Items.Add(itemRelacao.Codigo + "|" + itemRelacao.Nome + "|" + relacao.Quantidade);

                    valor += itemRelacao.Valor;
                }

                Valor.Text = valor.ToString();
            }
        }
    }
}
