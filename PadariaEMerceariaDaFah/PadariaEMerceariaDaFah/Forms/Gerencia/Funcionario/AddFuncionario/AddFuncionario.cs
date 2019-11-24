using PadariaEMerceariaDaFah.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario.AddFuncinario
{
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void add_funcionario_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_funcionario_salvar_Click(object sender, EventArgs e)
        {
            var funcionarios = Comercio.GerenciaEmpresa.Instance.Funcionarios;

            Comercio.GerenciaEmpresa.Instance.Banco.Insert("insert into gerencia_funcionario values (default,'" + func_cpf.Text.FormatToDB() + "' ,'" + func_nome.Text.FormatToDB() + "','" + func_funcao.Text.FormatToDB() + "', '" + func_telefone.Text.FormatToDB() + "', '" + func_celular.Text.FormatToDB() + "', '" + func_email.Text.FormatToDB() + "', '" + func_rua.Text.FormatToDB() + "', '" + func_cidade.Text.FormatToDB() + "', '" + func_estado.Text.FormatToDB() + "', '" + func_pais.Text.FormatToDB() + "', '" + func_numero.Text.FormatToDB() + "', '" + func_cep.Text.FormatToDB() + "', default);");

            var cod = Comercio.GerenciaEmpresa.Instance.CarregarFuncionariosBanco("SELECT * FROM GERENCIA_FUNCIONARIO WHERE CODIGO = (select MAX(CODIGO) from gerencia_funcionario)").FirstOrDefault().Codigo;

            /*if (funcionarios.Any())
            {
                cod = Comercio.GerenciaEmpresa.Instance.Funcionarios.Max(x => x.Codigo) + 1;
            }
            */
            var novoFunc = new Comercio.Funcionario(cod, func_nome.Text.FormatToDB(), func_funcao.Text.FormatToDB(), func_cpf.Text.FormatToDB(),new Comercio.Contato(func_telefone.Text.FormatToDB(), func_celular.Text.FormatToDB(), func_email.Text.FormatToDB()), new Comercio.Endereco(func_rua.Text.FormatToDB(), func_cidade.Text.FormatToDB(),func_estado.Text.FormatToDB(),func_pais.Text.FormatToDB(), func_cep.Text.FormatToDB(), func_numero.Text.FormatToDB()));

            Comercio.GerenciaEmpresa.Instance.AdicionarFuncionario(novoFunc);

            Comercio.GerenciaEmpresa.Instance.SalvarFuncionarios(Comercio.GerenciaEmpresa.Instance.Funcionarios);

            this.Close();
        }
    }
}
