using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes.RemoveIngrediente
{
    public partial class RemoveIngrediente : Form
    {
        public int Code;
        public RemoveIngrediente(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void add_ingrediente_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveIngrediente_Load(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var ingrediente = Comercio.GerenciaEmpresa.Instance.Ingredientes.FirstOrDefault(x => x.Codigo == Code);
                var relacao = Comercio.GerenciaEmpresa.Instance.RelacaoForneceIngredientes.FirstOrDefault(x => x.CodIngrediente == ingrediente.Codigo);
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == relacao.CodFornecedor);

                Fornecedor.Text = fornecedor.Nome;
                nome_ingrediente.Text = ingrediente.Nome;
                valor_text.Text = ingrediente.Valor.ToString();
                quantidade_text.Text = ingrediente.Quantidade.ToString();
                data_validade.Value = ingrediente.Validade.Date;
            }
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if(Code != 0)
            {
                var ingrediente = Comercio.GerenciaEmpresa.Instance.Ingredientes.FirstOrDefault(x => x.Codigo == Code);
                try
                {
                    Comercio.GerenciaEmpresa.Instance.Ingredientes.Remove(ingrediente);
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("UPDATE ESTOQUE_INGREDIENTE SET ATIVO = 0 WHERE CODIGO = '" + ingrediente.Codigo + "'");
                    Comercio.GerenciaEmpresa.Instance.SalvarIngredientes(Comercio.GerenciaEmpresa.Instance.Ingredientes);
                    MessageBox.Show("Ingrediente removido");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro encontrado:" + ex);
                }
                finally
                {
                    this.Close();
                }
            }
        }
    }
}
