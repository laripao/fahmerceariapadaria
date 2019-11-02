using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario;
using System;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms
{
    public partial class GerenciaInicio : Form
    {
        public GerenciaInicio()
        {
            InitializeComponent();
        }

        private void go_funcionario_Click(object sender, EventArgs e)
        {
            var funcionario = new FuncionarioInicio();
            funcionario.ShowDialog();
        }
    }
}
