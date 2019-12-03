using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios;
using PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaClientes;
using PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        private void UpdateForm(int Selected = 0)
        {
            double valor = 0;

            list_vendas.Items.Clear();

            var vendas = Comercio.GerenciaEmpresa.Instance.CarregarVendasBanco("SELECT * FROM VENDAS;").FirstOrDefault(x => x.Codigo == Selected);


            var relacao = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoVendaProdutosBanco("SELECT * FROM VENDA_ITEM WHERE COD_VENDA = " + vendas.Codigo + ";");

            foreach (var item in relacao)
            {
                var estoque = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == item.CodItem);
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == estoque.CodProduto);

                lista_produtos.Items.Add(item.Codigo + "|" + produto.Nome + "|" + item.Quantidade);

                valor += produto.Valor;
            }

            Valor.Text = valor.ToString();

            var itemSelected = Comercio.GerenciaEmpresa.Instance.Vendas.FirstOrDefault(x => x.Codigo == Selected);

            if (Selected != 0 && itemSelected != null)
            {
                var venda = Comercio.GerenciaEmpresa.Instance.Vendas.FirstOrDefault(x => x.Codigo == itemSelected.Codigo);
                if (itemSelected != null)
                {
                    //var index = list_vendas.Items.IndexOf(itemSelected.Codigo.ToString() + "|" + produto.Nome + "|" + produto.Valor.ToString());
                    //list_vendas.SetSelected(index, true);
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
            }
        }

        private void save_edit_venda_Click(object sender, EventArgs e)
        {

        }

        private void VendasInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
