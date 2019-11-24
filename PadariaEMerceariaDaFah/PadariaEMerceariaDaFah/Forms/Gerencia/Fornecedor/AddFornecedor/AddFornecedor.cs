using PadariaEMerceariaDaFah.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            Comercio.GerenciaEmpresa.Instance.Banco.Insert("insert into gerencia_fornecedor values (default, '" + fornecedor_nome.Text.FormatToDB() + "', '" + fornecedor_description.Text.FormatToDB() + "', '" + fornecedor_telefone.Text.FormatToDB() + "', '" + fornecedor_celular.Text.FormatToDB() + "', '" + fornecedor_email.Text.FormatToDB() + "', default );");

            var cod =  Comercio.GerenciaEmpresa.Instance.CarregarFornecedoresBanco("select * from laripaos.gerencia_fornecedor where CODIGO = (select MAX(CODIGO) from laripaos.gerencia_fornecedor)").FirstOrDefault().Codigo; ;

            var novoFornecedor = new Comercio.Fornecedor(cod, fornecedor_nome.Text.FormatToDB(), fornecedor_description.Text.FormatToDB(), new Comercio.Contato(fornecedor_telefone.Text.FormatToDB(), fornecedor_celular.Text.FormatToDB(), fornecedor_email.Text.FormatToDB()));

            Comercio.GerenciaEmpresa.Instance.AdicionarFornecedor(novoFornecedor);

            Comercio.GerenciaEmpresa.Instance.SalvarFornecedores(Comercio.GerenciaEmpresa.Instance.Fornecedores);

            this.Close();
        }

        private void fornecedor_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
