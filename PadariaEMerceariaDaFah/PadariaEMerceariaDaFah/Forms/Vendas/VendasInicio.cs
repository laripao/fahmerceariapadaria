using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios;
using PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaClientes;
using PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaEstoque;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Vendas
{
    public partial class VendasInicio : Form
    {
        public string nomeFuncionario;
        public int codFuncionario = 0;
        public int codCLiente = 0;
        public double valorTotal = 0;
        public VendasInicio()
        {
            InitializeComponent();

        }

        private void add_venda_Click(object sender, EventArgs e)
        {
            var venda = new AddVenda.AddVenda();
            venda.ShowDialog();
            UpdateForm();
        }
        private void UpdateForm(int Selected = 0)
        {
            list_vendas.Items.Clear();
            foreach (var item in Comercio.GerenciaEmpresa.Instance.CarregarVendasBanco("SELECT * FROM LARIPAOS.VENDAS;"))
            {
                double valor = 0;

                var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT EP.* FROM VENDAS VD INNER JOIN VENDA_ITEM VI ON VD.CODIGO = VI.COD_VENDA " +
                                                                                                  "INNER JOIN ITEM_ESTOQUE IE ON IE.COD_ITEM = VI.COD_ITEM " +
                                                                                                  "INNER JOIN ESTOQUE_PRODUTO EP ON EP.CODIGO = IE.COD_PRODUTO " +
                                                                                                  "WHERE VD.CODIGO = " + item.Codigo + ";");

                foreach (var itemRelacao in produtos)
                {
                    valor += itemRelacao.Valor;
                }

                list_vendas.Items.Add(item.Codigo.ToString() + "|" + item.Data.Date.ToString() + "|" + valor);
            }

            var itemSelected = Comercio.GerenciaEmpresa.Instance.Vendas.FirstOrDefault(x => x.Codigo == Selected);

            if (Selected != 0 && itemSelected != null)
            {
                var venda = Comercio.GerenciaEmpresa.Instance.Vendas.FirstOrDefault(x => x.Codigo == itemSelected.Codigo);

                if (itemSelected != null)
                {
                    double valor = 0;

                    var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT EP.* FROM VENDAS VD INNER JOIN VENDA_ITEM VI ON VD.CODIGO = VI.COD_VENDA " +
                                                                                                      "INNER JOIN ITEM_ESTOQUE IE ON IE.COD_ITEM = VI.COD_ITEM " +
                                                                                                      "INNER JOIN ESTOQUE_PRODUTO EP ON EP.CODIGO = IE.COD_PRODUTO " +
                                                                                                      "WHERE VD.CODIGO = " + itemSelected.Codigo + ";");

                    foreach (var itemRelacao in produtos)
                    {
                        valor += itemRelacao.Valor;
                    }

                    var index = list_vendas.Items.IndexOf(itemSelected.Codigo.ToString() + "|" + itemSelected.Data.Date + "|" + valor);
                    list_vendas.SetSelected(index, true);
                }
            }
        }

        private void remove_venda_Click(object sender, EventArgs e)
        {
            if(list_vendas.SelectedItem != null)
            {
                var selectedVenda = Convert.ToInt32(list_vendas.SelectedItem.ToString().Split('|').First());
                var remove = new RemoveVenda.RemoveVenda(selectedVenda);
                remove.ShowDialog();
                UpdateForm(selectedVenda);
            }
        }

        private void habilitar_edicao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                groupVendas.Enabled = true;
            }
            else
            {
                groupVendas.Enabled = false;
            }
        }

        private void linkFuncionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var funcionario = new FuncionariosList();
            funcionario.ShowDialog();

            nomeFuncionario = FuncionariosList.nome_funcionario;
            codFuncionario = FuncionariosList.cod_funcionario;

            QuemVendeu.Text = nomeFuncionario;
        }

        private void linkCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cliente = new ClienteList();
            cliente.ShowDialog();

            codCLiente = cliente.codCliente;
            QuemComprou.Text = cliente.nomeCliente;
        }

        private void add_produtos_Click(object sender, EventArgs e)
        {
            var produto = new EstoqueList();
            produto.ShowDialog();

            if (produto.codItem != 0)
            {
                valorTotal += (produto.quantidade * produto.valorItem);

                lista_produtos.Items.Add(produto.codItem + "|" + produto.nomeItem + "|" + produto.quantidade);

                Valor.Text = "R$ " + valorTotal.ToString();
            }
        }

        private void remove_produtos_Click(object sender, EventArgs e)
        {
            if (lista_produtos.SelectedItem != null)
            {
                lista_produtos.Items.RemoveAt(lista_produtos.SelectedIndex);
                var aux = lista_produtos.Items.ToString().Split('|')[0];
                Comercio.GerenciaEmpresa.Instance.Banco.Delete("DELETE FROM VENDA_ITEM WHERE COD_ITEM = " + aux + ";");
            }
        }

        private void save_edit_venda_Click(object sender, EventArgs e)
        {
            if(list_vendas.SelectedItem != null)
            {
                var selectedVenda = Convert.ToInt32(list_vendas.SelectedItem.ToString().Split('|').First());

                var venda = Comercio.GerenciaEmpresa.Instance.CarregarVendasBanco("SELECT * FROM VENDAS WHERE CODIGO = " + selectedVenda + ";").FirstOrDefault();

                venda.Cliente = codCLiente;
                venda.Data = data_venda.Value.Date;
                venda.Funcionario = codFuncionario;

                Comercio.GerenciaEmpresa.Instance.Banco.Update("UPDATE VENDAS SET " +
                    "DATA_DE_VENDA = STR_TO_DATE('" + venda.Data + "','%d/%m/%Y')" +
                    " WHERE CODIGO = " + venda.Codigo);

                Comercio.GerenciaEmpresa.Instance.SalvarVendas(Comercio.GerenciaEmpresa.Instance.Vendas);

                MessageBox.Show("Salvo com sucesso!");
            }
        }

        private void VendasInicio_Load(object sender, EventArgs e)
        {
            foreach (var item in Comercio.GerenciaEmpresa.Instance.CarregarVendasBanco("SELECT * FROM LARIPAOS.VENDAS;"))
            {
                double valor = 0;

                var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT EP.* FROM VENDAS VD INNER JOIN VENDA_ITEM VI ON VD.CODIGO = VI.COD_VENDA " +
                                                                                                  "INNER JOIN ITEM_ESTOQUE IE ON IE.COD_ITEM = VI.COD_ITEM " +
                                                                                                  "INNER JOIN ESTOQUE_PRODUTO EP ON EP.CODIGO = IE.COD_PRODUTO " +
                                                                                                  "WHERE VD.CODIGO = " + item.Codigo  + ";");

                foreach (var itemRelacao in produtos)
                {
                    valor += itemRelacao.Valor;
                }

                list_vendas.Items.Add(item.Codigo.ToString() + "|" + item.Data.Date.ToString() + "|" + valor);
            }
            HabilitarEdicao();
        }

        private void list_vendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista_produtos.Items.Clear();
            int selectecVenda;
            if(list_vendas.SelectedItem != null)
            {
                selectecVenda = Convert.ToInt32(list_vendas.SelectedItem.ToString().Split('|').First());

                var funcionario = Comercio.GerenciaEmpresa.Instance.CarregarFuncionariosBanco("SELECT GF.* FROM GERENCIA_FUNCIONARIO GF INNER JOIN VENDAS VD ON VD.COD_FUNCIONARIO = GF.CODIGO WHERE VD.CODIGO = "+ selectecVenda +";").FirstOrDefault();
                var cliente = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT CL.* FROM CLIENTE CL INNER JOIN VENDAS VD ON VD.COD_CLIENTE = CL.CODIGO WHERE VD.CODIGO = "+ selectecVenda +";").FirstOrDefault();

                QuemVendeu.Text = funcionario.Nome;
                QuemComprou.Text = cliente.Nome;

                double valor = 0;

                var produtos = Comercio.GerenciaEmpresa.Instance.CarregarProdutoBanco("SELECT EP.* FROM VENDAS VD INNER JOIN VENDA_ITEM VI ON VD.CODIGO = VI.COD_VENDA " +
                                                                                                  "INNER JOIN ITEM_ESTOQUE IE ON IE.COD_ITEM = VI.COD_ITEM " +
                                                                                                  "INNER JOIN ESTOQUE_PRODUTO EP ON EP.CODIGO = IE.COD_PRODUTO " +
                                                                                                  "WHERE VD.CODIGO = " + selectecVenda + ";");

                foreach (var itemRelacao in produtos)
                {
                    var relacao = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoVendaProdutosBanco("SELECT VI.* FROM VENDA_ITEM VI INNER JOIN ITEM_ESTOQUE IE " +
                                                                                                        " ON VI.COD_ITEM = IE.COD_ITEM " +
                                                                                                        " WHERE IE.COD_PRODUTO = "+ itemRelacao.Codigo + " AND VI.COD_VENDA = " + selectecVenda + ";").FirstOrDefault();

                    lista_produtos.Items.Add(itemRelacao.Codigo + "|" + itemRelacao.Nome + "|" + relacao.Quantidade);

                    valor += itemRelacao.Valor;
                }

                Valor.Text = valor.ToString();
            }
            
        }
    }
}
