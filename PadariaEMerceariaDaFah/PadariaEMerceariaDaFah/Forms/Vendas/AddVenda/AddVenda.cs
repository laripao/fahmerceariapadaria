using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios;
using PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaClientes;
using PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaEstoque;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Vendas.AddVenda
{
    public partial class AddVenda : Form
    {
        public string nomeFuncionario;
        public int codFuncionario = 0;
        public int codCLiente = 0;
        public double valorTotal = 0;
        public AddVenda()
        {
            InitializeComponent();
        }

        private void add_venda_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddVenda_Load(object sender, EventArgs e)
        {
            data_venda.Value = DateTime.Now;
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

        private void add_ingredientes_Click(object sender, EventArgs e)
        {
            var produto = new EstoqueList();
            produto.ShowDialog();
            
            if(produto.codItem != 0)
            {
                valorTotal += (produto.quantidade * produto.valorItem);

                lista_produtos.Items.Add(produto.codItem + "|" + produto.nomeItem + "|" + produto.quantidade);

                Valor.Text = "R$ " + valorTotal.ToString();
            }
        }

        private void remove_ingredientes_Click(object sender, EventArgs e)
        {
            if(lista_produtos.SelectedItem != null)
            {
                lista_produtos.Items.RemoveAt(lista_produtos.SelectedIndex);
            }
        }

        private void add_venda_salvar_Click(object sender, EventArgs e)
        {
            if(codCLiente == 0)
            {
                MessageBox.Show("Insira um cliente.");
            }
            if(codFuncionario == 0)
            {
                MessageBox.Show("Insira um funcionário.");
            }
            if(valorTotal == 0)
            {
                MessageBox.Show("Insira os produtos vendidos.");
            }
            if(codFuncionario != 0 && codCLiente != 0 && valorTotal > 0)
            {
                var venda = Comercio.GerenciaEmpresa.Instance.Vendas;
                var relacaoVenda = Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos;

                Comercio.GerenciaEmpresa.Instance.Banco.Insert("INSERT INTO VENDAS VALUES(DEFAULT, " +
                                                                "STR_TO_DATE('" + data_venda.Value.Date + "','%d/%m/%Y')," +
                                                                + codFuncionario+"," +
                                                                + codCLiente +");");

                var vendas = Comercio.GerenciaEmpresa.Instance.CarregarVendasBanco("SELECT * FROM VENDAS WHERE CODIGO = (SELECT MAX(CODIGO) FROM VENDAS);").FirstOrDefault();
                
                foreach(var item in lista_produtos.Items)
                {
                    var aux = item.ToString().Split('|');
                    Comercio.GerenciaEmpresa.Instance.Banco.Insert("INSERT INTO VENDA_ITEM VALUES(DEFAULT, " +
                                                                    aux[0] + ", " +
                                                                    vendas.Codigo + ", " +
                                                                    aux[2] + ");");

                    var cod = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoForneceProdutosBanco("SELECT * FROM VENDA_ITEM WHERE CODIGO = (SELECT MAX(CODIGO) FROM VENDA_ITEM);").FirstOrDefault();


                    var produto = Comercio.GerenciaEmpresa.Instance.CarregarEstoqueItensBanco("SELECT * FROM ITEM_ESTOQUE WHERE COD_ITEM = " + aux[0] + ";").FirstOrDefault();

                    int quantidade_atualizada = produto.Quantidade - Convert.ToInt32(aux[2]);

                    Comercio.GerenciaEmpresa.Instance.Banco.Update("UPDATE ITEM_ESTOQUE SET QUANTIDADE_PRODUTO = " + quantidade_atualizada + " WHERE COD_ITEM = " + produto.Codigo + ";");

                    Comercio.GerenciaEmpresa.Instance.AdicionarRelacaoVendaProduto(new Comercio.RelacaoVendaProduto(cod.Codigo, cod.CodProduto, 1, Convert.ToInt32(aux[2])));

                    Comercio.GerenciaEmpresa.Instance.SalvarRelacaoVendaProduto(Comercio.GerenciaEmpresa.Instance.RelacaoVendaProdutos);
                }


                Comercio.GerenciaEmpresa.Instance.AdicionarVenda(new Comercio.Venda(vendas.Codigo, vendas.Data, vendas.Funcionario, vendas.Cliente));
                   
                Comercio.GerenciaEmpresa.Instance.SalvarVendas(Comercio.GerenciaEmpresa.Instance.Vendas);

                this.Close();
            }
        }
    }
}
