using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor.RemoveFornecedor
{
    public partial class RemoverFornecedor : Form
    {
        public int Code;
        public RemoverFornecedor(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void cancel_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == Code);
                Comercio.GerenciaEmpresa.Instance.Fornecedores.Remove(fornecedor);
                Comercio.GerenciaEmpresa.Instance.SalvarFornecedores(Comercio.GerenciaEmpresa.Instance.Fornecedores);
                MessageBox.Show("Fornecedor Removido.");
                this.Close();
            }
        }

        private void RemoverFornecedor_Load(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var fornecedor = Comercio.GerenciaEmpresa.Instance.Fornecedores.FirstOrDefault(x => x.Codigo == Code);

                fornecedor_nome.Text = fornecedor.Nome;
                fornecedor_description.Text = fornecedor.Description;
                fornecedor_celular.Text = fornecedor.Contato.Celular;
                fornecedor_telefone.Text = fornecedor.Contato.Telefone;
                fornecedor_email.Text = fornecedor.Contato.Email;
            }
        }
    }
}
