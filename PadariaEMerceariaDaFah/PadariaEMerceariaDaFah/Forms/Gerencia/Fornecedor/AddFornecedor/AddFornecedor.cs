using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor.AddFornecedor
{
    public partial class AddFornecedor : Form
    {
        public AddFornecedor()
        {
            InitializeComponent();
        }

        private void add_fornecedor_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_fornecedor_salvar_Click(object sender, EventArgs e)
        {
            var fornecedores = Comercio.GerenciaEmpresa.Instance.Fornecedores;
            var cod = 1;

            if (fornecedores.Any())
            {
                cod = Comercio.GerenciaEmpresa.Instance.Fornecedores.Max(x => x.Codigo) + 1;
            }
            var novoFornecedor = new Comercio.Fornecedor(cod, fornecedor_nome.Text, fornecedor_description.Text, new Comercio.Contato(fornecedor_telefone.Text, fornecedor_celular.Text, fornecedor_email.Text));

            Comercio.GerenciaEmpresa.Instance.AdicionarFornecedor(novoFornecedor);

            Comercio.GerenciaEmpresa.Instance.SalvarFornecedores(Comercio.GerenciaEmpresa.Instance.Fornecedores);

            this.Close();
        }

        private void fornecedor_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
