using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PadariaEMerceariaDaFah.Classes;

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
            var docExistente = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM CLIENTE WHERE DOCUMENTO = '"+cliente_documento.Text.FormatToDB()+"';");

            if (!docExistente.Any())
            {
                Comercio.GerenciaEmpresa.Instance.Banco.Insert("insert into cliente values (default, '" + cliente_nome.Text.FormatToDB() + "', '" + cliente_documento.Text.FormatToDB() + "', '" + cliente_telefone.Text.FormatToDB() + "', '" + cliente_celular.Text.FormatToDB() + "', '" + cliente_email.Text.FormatToDB() + "' );");

                var cod = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("select * from laripaos.cliente where CODIGO = (select MAX(CODIGO) from laripaos.cliente);").FirstOrDefault().Codigo; ;

                var novocliente = new Comercio.Cliente(cod, cliente_nome.Text.FormatToDB(), cliente_documento.Text.FormatToDB(), new Comercio.Contato(cliente_telefone.Text.FormatToDB(), cliente_celular.Text.FormatToDB(), cliente_email.Text.FormatToDB()));

                Comercio.GerenciaEmpresa.Instance.AdicionarCliente(novocliente);

                Comercio.GerenciaEmpresa.Instance.SalvarClientes(Comercio.GerenciaEmpresa.Instance.Clientes);

                this.Close();
            }
            else
            {
                MessageBox.Show("Documento Já Cadastrado!");
            }
        }

        private void AddCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
