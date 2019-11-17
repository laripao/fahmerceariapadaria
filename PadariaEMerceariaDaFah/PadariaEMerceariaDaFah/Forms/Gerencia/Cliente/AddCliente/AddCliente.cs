using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Cliente.AddCliente
{
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void add_cliente_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_cliente_salvar_Click(object sender, EventArgs e)
        {
            var docExistente = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM CLIENTE WHERE DOCUMENTO = '"+cliente_documento.Text+"';");

            if (!docExistente.Any())
            {
                Comercio.GerenciaEmpresa.Instance.Banco.Insert("insert into cliente values (default, '" + cliente_nome.Text + "', '" + cliente_documento.Text + "', '" + cliente_telefone.Text + "', '" + cliente_celular.Text + "', '" + cliente_email.Text + "' );");

                var cod = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("select * from laripaos.cliente where CODIGO = (select MAX(CODIGO) from laripaos.cliente);").FirstOrDefault().Codigo; ;

                var novocliente = new Comercio.Cliente(cod, cliente_nome.Text, cliente_documento.Text, new Comercio.Contato(cliente_telefone.Text, cliente_celular.Text, cliente_email.Text));

                Comercio.GerenciaEmpresa.Instance.AdicionarCliente(novocliente);

                Comercio.GerenciaEmpresa.Instance.SalvarClientes(Comercio.GerenciaEmpresa.Instance.Clientes);

                this.Close();
            }
            else
            {
                MessageBox.Show("Documento Já Cadastrado!");
            }
        }
    }
}
