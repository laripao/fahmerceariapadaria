using PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes.AdicionarIngrediente;
using PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes
{
    public partial class IngredientesInicio : Form
    {
        public string nomeFornecedor;
        public int codFornecedor;
        public IngredientesInicio()
        {
            InitializeComponent();
        }

        private void add_produto_Click(object sender, EventArgs e)
        {
            var ingrediente = new AddIngrediente();
            ingrediente.ShowDialog();
            UpdateForm();
        }

        private void IngredientesInicio_Load(object sender, EventArgs e)
        {
            list_Ingrediente.Items.Clear();
            var ingrediente = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("SELECT * FROM ESTOQUE_INGREDIENTE WHERE ATIVO = '" + 1 + "';");

            foreach (var item in ingrediente)
            {
                list_Ingrediente.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                edit_ingrediente.Enabled = true;
            }
            else
            {
                edit_ingrediente.Enabled = false;
            }
        }

        private void UpdateForm(int Selected = 0)
        {
            list_Ingrediente.Items.Clear();

            var ingredientes = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("");

            foreach(var item in ingredientes)
            {
                list_Ingrediente.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }

            if (Selected != 0 )
            {
                var ingredienteSelected = Comercio.GerenciaEmpresa.Instance.Ingredientes.FirstOrDefault(x => x.Codigo == Selected);
                if(ingredienteSelected != null)
                {
                    var index = list_Ingrediente.Items.IndexOf(ingredienteSelected.Codigo.ToString() + " | " + ingredienteSelected.Nome);
                    list_Ingrediente.SetSelected(index, true);
                }
            }
        }

        private void remove_ingrediente_Click(object sender, EventArgs e)
        {
            if(list_Ingrediente.SelectedItem != null)
            {
                var selectecIng = Convert.ToInt32(list_Ingrediente.SelectedItem.ToString().Split('|').First());
                var remove = new RemoveIngrediente.RemoveIngrediente(selectecIng);
                remove.ShowDialog();
                UpdateForm(selectecIng);
            }
        }

        private void list_Ingrediente_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectIngredient;
            if(list_Ingrediente.SelectedItem != null)
            {
                selectIngredient = Convert.ToInt32(list_Ingrediente.SelectedItem.ToString().Split('|').First());
                var ingrediente = Comercio.GerenciaEmpresa.Instance.Ingredientes.FirstOrDefault(x => x.Codigo == selectIngredient);

                var relacao = Comercio.GerenciaEmpresa.Instance.RelacaoForneceIngredientes.FirstOrDefault(x => x.CodIngrediente == ingrediente.Codigo);
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == relacao.CodFornecedor);

                Fornecedor.Text = fornecedor.Nome;
                nome_ingrediente.Text = ingrediente.Nome;
                valor_text.Text = ingrediente.Valor.ToString();
                quantidade_text.Text = ingrediente.Quantidade.ToString();
                data_validade.Value = ingrediente.Validade.Date;
            }
        }

        private void habilitar_edicao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void linkFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fornecedor = new FornecedoresList();
            fornecedor.ShowDialog();


            codFornecedor = FornecedoresList.cod_fornecedor;
            nomeFornecedor = FornecedoresList.nome_fornecedor;

            Fornecedor.Text = nomeFornecedor;
        }

        private void save_edit_ingrediente_Click(object sender, EventArgs e)
        {
            if(list_Ingrediente.SelectedItem != null)
            {
                var selectedIngrediente = Convert.ToInt32(list_Ingrediente.SelectedItem.ToString().Split('|').First());
                var ingrediente = Comercio.GerenciaEmpresa.Instance.Ingredientes.FirstOrDefault(x => x.Codigo == selectedIngrediente);

                var relacao = Comercio.GerenciaEmpresa.Instance.RelacaoForneceIngredientes.FirstOrDefault(x => x.CodIngrediente == ingrediente.Codigo);

                relacao.CodFornecedor = codFornecedor;
                ingrediente.Nome = nome_ingrediente.Text;
                ingrediente.Valor = Convert.ToDouble(valor_text.Text);
                ingrediente.Quantidade = Convert.ToInt32(quantidade_text.Text);
                ingrediente.Validade = data_validade.Value;

                Comercio.GerenciaEmpresa.Instance.Banco.Update("UPDATE ESTOQUE_INGREDIENTE SET NAME = '" + ingrediente.Nome + "'," +
                    "VALIDADE = '" + ingrediente.Validade + "'," +
                    "VALOR = '" + ingrediente.Valor + "'," +
                    "QUANTIDADE = '" + ingrediente.Quantidade + "'" +
                    "WHERE CODIGO = '" + ingrediente.Codigo + "';");

                Comercio.GerenciaEmpresa.Instance.Banco.Update("UPDATE FORNECE SET COD_FORNECEDOR = '" + relacao.CodFornecedor + "WHERE COD_INGREDIENTE = '" + ingrediente.Codigo + "';");

                UpdateForm(selectedIngrediente);

                Comercio.GerenciaEmpresa.Instance.SalvarIngredientes(Comercio.GerenciaEmpresa.Instance.Ingredientes);
                Comercio.GerenciaEmpresa.Instance.SalvarRelacaoForneceIngredientes(Comercio.GerenciaEmpresa.Instance.RelacaoForneceIngredientes);

                MessageBox.Show("Ingrediente Atualizado com sucesso!");
            }
        }

        private void Fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void valor_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';

                if (valor_text.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void quantidade_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';

                if (quantidade_text.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
