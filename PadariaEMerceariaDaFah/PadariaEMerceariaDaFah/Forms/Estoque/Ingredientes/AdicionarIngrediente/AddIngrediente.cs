using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes.AdicionarIngrediente
{
    public partial class AddIngrediente : Form
    {
        public string nomeFornecedor;
        public int codFornecedor;

        public AddIngrediente()
        {
            InitializeComponent();
        }

        private void linkFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fornecedor = new FornecedoresList();
            fornecedor.ShowDialog();


            codFornecedor = FornecedoresList.cod_fornecedor;
            nomeFornecedor = FornecedoresList.nome_fornecedor;

            Fornecedor.Text = nomeFornecedor;
        }

        private void valor_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void add_ingrediente_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantidade_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresNaoPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ,.;";

            if ((caracteresNaoPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void add_ingrediente_salvar_Click(object sender, EventArgs e)
        {
            var ingrediente = Comercio.GerenciaEmpresa.Instance.Ingredientes;
            
            Comercio.GerenciaEmpresa.Instance.Banco.Insert("INSERT INTO ESTOQUE_INGREDIENTE VALUES( default," +
                " '" + nome_ingrediente.Text + "', " +
                " STR_TO_DATE('" + data_validade.Value.Date + "','%d/%m/%Y'), " +
                " '" + Convert.ToDouble(valor_text.Text) + "', " +
                " '" + Convert.ToInt32(quantidade_text.Text) + "', " +
                " default);");

            var cod = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("SELECT * FROM laripaos.ESTOQUE_INGREDIENTE WHERE CODIGO = (SELECT MAX(CODIGO) FROM laripaos.ESTOQUE_INGREDIENTE);").FirstOrDefault().Codigo;

            var codRelacaoUltima = Comercio.GerenciaEmpresa.Instance.CarregarRelacaoForneceIngredienteBanco("SELECT * FROM laripaos.FORNECE WHERE CODIGO = (SELECT MAX(CODIGO) FROM laripaos.FORNECE);").FirstOrDefault();

            int codRelacao = codRelacaoUltima == null ? 1 : codRelacaoUltima.Codigo; 
            

            Comercio.GerenciaEmpresa.Instance.Banco.Insert("INSERT INTO FORNECE VALUES( default," +
                "'" + codFornecedor + "'," +
                "'" + cod + "');");

            var novaRelacao = new Comercio.RelacaoForneceIngrediente(codRelacao, codFornecedor, cod);

            Comercio.GerenciaEmpresa.Instance.AdicionarRelacaoForneceIngredientes(novaRelacao);

            Comercio.GerenciaEmpresa.Instance.SalvarRelacaoForneceIngredientes(Comercio.GerenciaEmpresa.Instance.RelacaoForneceIngredientes);

            var novoIngrediente = new Comercio.Ingrediente(cod, nome_ingrediente.Text, Convert.ToDouble(valor_text.Text), Convert.ToDateTime(data_validade.Value), Convert.ToInt32(quantidade_text.Text), true);

            Comercio.GerenciaEmpresa.Instance.AdicionarIngrediente(novoIngrediente);

            Comercio.GerenciaEmpresa.Instance.SalvarIngredientes(Comercio.GerenciaEmpresa.Instance.Ingredientes);

            this.Close();
        }
    }
}
