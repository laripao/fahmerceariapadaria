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
                var relacao = Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos.FirstOrDefault(x => x.CodVenda == venda.Codigo);
                try
                {
                    Comercio.GerenciaEmpresa.Instance.Vendas.Remove(venda);
                    Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos.Remove(relacao);
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("DELETE FROM VENDA_ITEM WHERE COD_VENDA = " + venda.Codigo + ";");
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("DELETE FROM VENDAS WHERE CODIGO = " + venda.Codigo + ";");
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
                double valor = 0;

                var venda = Comercio.GerenciaEmpresa.Instance.Vendas.FirstOrDefault(x => x.Codigo == Code);
                var cliente = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == venda.Cliente);
                var funcionario = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == venda.Funcionario);

                data_venda.Value = venda.Data.Date;
                QuemVendeu.Text = funcionario.Nome;
                QuemComprou.Text = cliente.Nome;

                var relacao = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoVendaProdutosBanco("SELECT * FROM VENDA_ITEM WHERE COD_VENDA = " + venda.Codigo + ";");
                
                foreach (var item in relacao)
                {
                    var estoque = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == item.CodItem);
                    var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == estoque.CodProduto);

                    lista_produtos.Items.Add(item.Codigo + "|" + produto.Nome + "|" + item.Quantidade);

                    valor += produto.Valor;
                }

                Valor.Text = valor.ToString();
            }
        }
    }
}
