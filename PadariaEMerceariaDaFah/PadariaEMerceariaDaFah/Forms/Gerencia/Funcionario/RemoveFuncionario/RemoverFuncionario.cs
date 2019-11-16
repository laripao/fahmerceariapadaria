using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario.RemoveFuncionario
{
    public partial class RemoverFuncionario : Form
    {
        public int Code;
        public RemoverFuncionario(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void RemoverFuncionario_Load(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var func = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == Code);

                func_nome.Text = func.Nome;
                func_funcao.Text = func.Funcao;
                func_cpf.Text = func.CPF;
                func_celular.Text = func.Contato.Celular;
                func_telefone.Text = func.Contato.Telefone;
                func_email.Text = func.Contato.Email;
            }
        }

        private void cancel_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var func = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == Code);
                Comercio.GerenciaEmpresa.Instance.Funcionarios.Remove(func);
                Comercio.GerenciaEmpresa.Instance.Banco.Delete("update gerencia_funcionario set ativo = 0 where codigo = '" + func.Codigo + "'");
                Comercio.GerenciaEmpresa.Instance.SalvarFuncionarios(Comercio.GerenciaEmpresa.Instance.Funcionarios);
                MessageBox.Show("Funcionário Removido.");
                this.Close();
            }
        }
    }
}
