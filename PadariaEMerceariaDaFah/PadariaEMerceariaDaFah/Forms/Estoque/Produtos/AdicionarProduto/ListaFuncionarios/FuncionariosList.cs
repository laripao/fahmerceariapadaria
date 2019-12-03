using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario;
using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario.AddFuncinario;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios
{
    public partial class FuncionariosList : Form
    {
        public static string nome_funcionario;
        public static int cod_funcionario;

        public FuncionariosList()
        {
            InitializeComponent();
        }

        private void FuncionariosList_Load(object sender, EventArgs e)
        {
            cod_funcionario = 0;
            nome_funcionario = "";

            list_funcionario.Items.Clear();
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Funcionarios)
            {
                list_funcionario.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
        }

        private void UpdateForm(int Selected = 0)
        {
            list_funcionario.Items.Clear();

            var funcionarios = Comercio.GerenciaEmpresa.Instance.CarregarFuncionariosBanco("SELECT * FROM GERENCIA_FUNCIONARIO WHERE ATIVO = 1;");

            foreach (var item in funcionarios)
            {
                list_funcionario.Items.Add(item.Codigo.ToString() + "|" + item.Nome.Trim());
            }
            if (Selected != 0)
            {
                var funcionarioSelected = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == Selected);
                if (funcionarioSelected != null)
                {
                    var index = list_funcionario.Items.IndexOf(funcionarioSelected.Codigo.ToString() + "|" + funcionarioSelected.Nome.Trim());
                    list_funcionario.SetSelected(index, true);
                }
            }
        }

        private void go_funcionario_Click_Click(object sender, EventArgs e)
        {
            var funcionario = new FuncionarioInicio();
            funcionario.ShowDialog();
            UpdateForm();
        }

        private void go_addFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new AddFuncionario();
            funcionario.ShowDialog();
            UpdateForm();
        }

        private void list_funcionario_DoubleClick(object sender, EventArgs e)
        {
            if (list_funcionario.SelectedItem != null)
            {
                string[] aux = list_funcionario.SelectedItem.ToString().Split('|');
                nome_funcionario = aux[1];
                cod_funcionario = Convert.ToInt32(aux[0].Trim());
                Close();
            }
        }

        private void add_produto_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
