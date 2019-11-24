using System;
using System.Windows.Forms;
using System.Linq;
using PadariaEMerceariaDaFah.Classes;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor
{
    public partial class FornecedorInicio : Form
    {
        public FornecedorInicio()
        {
            InitializeComponent();
        }

        private void add_fornecedor_Click(object sender, EventArgs e)
        {
            var fornecedor = new AddFornecedor.AddFornecedor();
            fornecedor.ShowDialog();
            UpdateForm();
        }

        private void UpdateForm(int Selected = 0)
        {
            list_fornecedor.Items.Clear();

            var fornecedores = Comercio.GerenciaEmpresa.Instance.CarregarFornecedoresBanco("SELECT * FROM GERENCIA_FORNECEDOR WHERE ATIVO = 1;");

            foreach (var item in fornecedores)
            {
                list_fornecedor.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            if (Selected != 0)
            {
                var fornecedoreSelected = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == Selected);
                if (fornecedoreSelected != null)
                {
                    var index = list_fornecedor.Items.IndexOf(fornecedoreSelected.Codigo.ToString() + " | " + fornecedoreSelected.Nome);
                    list_fornecedor.SetSelected(index, true);
                }
            }
        }

        private void save_edit_fornecedor_Click(object sender, EventArgs e)
        {
            if (list_fornecedor.SelectedItem != null)
            {
                var selectedfornecedor = Convert.ToInt32(list_fornecedor.SelectedItem.ToString().Split('|').First());
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == selectedfornecedor);

                fornecedor.Nome = fornecedor_nome.Text.FormatToDB();
                fornecedor.Description = fornecedor_description.Text.FormatToDB();
                fornecedor.Contato.Celular = fornecedor_celular.Text.FormatToDB();
                fornecedor.Contato.Telefone = fornecedor_telefone.Text.FormatToDB();
                fornecedor.Contato.Email = fornecedor_email.Text.FormatToDB();

                Comercio.GerenciaEmpresa.Instance.Banco.Update("update gerencia_fornecedor set name = '"+fornecedor.Nome+"', description = '"+
                    fornecedor.Description+"', telefone = '"+fornecedor.Contato.Telefone+"', celular = '"+fornecedor.Contato.Celular+
                    "', email = '"+fornecedor.Contato.Email+"' where codigo = '"+fornecedor.Codigo+"'");

                UpdateForm(selectedfornecedor);

                Comercio.GerenciaEmpresa.Instance.SalvarFornecedores(Comercio.GerenciaEmpresa.Instance.Fornecedores);

                MessageBox.Show("Salvo com sucesso.");

            }
        }

        private void list_fornecedor_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedFornecedor;
            if (list_fornecedor.SelectedItem != null)
            {
                selectedFornecedor = Convert.ToInt32(list_fornecedor.SelectedItem.ToString().Split('|').First());
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == selectedFornecedor);

                fornecedor_nome.Text = fornecedor.Nome;
                fornecedor_description.Text = fornecedor.Description;
                fornecedor_celular.Text = fornecedor.Contato.Celular;
                fornecedor_telefone.Text = fornecedor.Contato.Telefone;
                fornecedor_email.Text = fornecedor.Contato.Email;
            }
        }

        private void FornecedorInicio_Load(object sender, EventArgs e)
        {
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Fornecedores)
            {
                list_fornecedor.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                save_edit_fornecedor.Enabled = true;
                remove_fornecedor.Enabled = true;

                fornecedor_nome.Enabled = true;
                fornecedor_description.Enabled = true;
                fornecedor_celular.Enabled = true;
                fornecedor_telefone.Enabled = true;
                fornecedor_email.Enabled = true;

            }
            else
            {
                save_edit_fornecedor.Enabled = false;
                remove_fornecedor.Enabled = false;

                fornecedor_nome.Enabled = false;
                fornecedor_description.Enabled = false;
                fornecedor_celular.Enabled = false;
                fornecedor_telefone.Enabled = false;
                fornecedor_email.Enabled = false;

            }
        }

        private void habilitar_edicao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void remove_fornecedor_Click(object sender, EventArgs e)
        {
            if (list_fornecedor.SelectedItem != null)
            {
                var selectedFunc = Convert.ToInt32(list_fornecedor.SelectedItem.ToString().Split('|').First());
                var remove = new RemoveFornecedor.RemoverFornecedor(selectedFunc);
                remove.ShowDialog();
                UpdateForm(selectedFunc);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
