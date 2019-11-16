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

            Comercio.GerenciaEmpresa.Instance.Banco.Insert("insert into gerencia_funcionario values (default,'" + func_cpf.Text + "' ,'" + func_nome.Text + "','" + func_funcao.Text + "', '" + func_telefone.Text + "', '" + func_celular.Text + "', '" + func_email.Text + "', '" + func_rua.Text + "', '" + func_cidade.Text + "', '" + func_estado.Text + "', '" + func_pais.Text + "', '" + func_numero.Text + "', '" + func_cep.Text + "', default);");

            var cod = Comercio.GerenciaEmpresa.Instance.CarregarFuncionariosBanco("SELECT * FROM GERENCIA_FUNCIONARIO WHERE CODIGO = (select MAX(CODIGO) from gerencia_funcionario)").FirstOrDefault().Codigo;

            /*if (funcionarios.Any())
            {
                cod = Comercio.GerenciaEmpresa.Instance.Funcionarios.Max(x => x.Codigo) + 1;
            }
            */
            var novoFunc = new Comercio.Funcionario(cod, func_nome.Text, func_funcao.Text, func_cpf.Text,new Comercio.Contato(func_telefone.Text, func_celular.Text, func_email.Text), new Comercio.Endereco(func_rua.Text, func_cidade.Text,func_estado.Text,func_pais.Text, func_cep.Text, func_numero.Text));

            Comercio.GerenciaEmpresa.Instance.AdicionarFuncionario(novoFunc);

            Comercio.GerenciaEmpresa.Instance.SalvarFuncionarios(Comercio.GerenciaEmpresa.Instance.Funcionarios);

            this.Close();
        }
    }
}
