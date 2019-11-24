using PadariaEMerceariaDaFah.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Cliente
{
    public partial class ClienteInicio : Form
    {
        public ClienteInicio()
        {
            InitializeComponent();
        }

        private void ClienteInicio_Load(object sender, EventArgs e)
        {
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Clientes)
            {
                list_cliente.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                save_edit_cliente.Enabled = true;
                remove_cliente.Enabled = true;

                cliente_nome.Enabled = true;
                cliente_documento.Enabled = true;
                cliente_celular.Enabled = true;
                cliente_telefone.Enabled = true;
                cliente_email.Enabled = true;

            }
            else
            {
                save_edit_cliente.Enabled = false;
                remove_cliente.Enabled = false;

                cliente_nome.Enabled = false;
                cliente_documento.Enabled = false;
                cliente_celular.Enabled = false;
                cliente_telefone.Enabled = false;
                cliente_email.Enabled = false;

            }
        }

        private void add_cliente_Click(object sender, EventArgs e)
        {
            var cliente = new AddCliente.AddCliente();
            cliente.ShowDialog();
            UpdateForm();
        }

        private void habilitar_edicao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void UpdateForm(int Selected = 0)
        {
            list_cliente.Items.Clear();

            var clientes = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM cliente;");

            foreach (var item in clientes)
            {
                list_cliente.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            if (Selected != 0)
            {
                var clienteeSelected = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == Selected);
                if (clienteeSelected != null)
                {
                    var index = list_cliente.Items.IndexOf(clienteeSelected.Codigo.ToString() + " | " + clienteeSelected.Nome);
                    list_cliente.SetSelected(index, true);
                }
            }
        }

        private void list_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedcliente;
            if (list_cliente.SelectedItem != null)
            {
                selectedcliente = Convert.ToInt32(list_cliente.SelectedItem.ToString().Split('|').First());
                var cliente = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == selectedcliente);

                cliente_nome.Text = cliente.Nome;
                cliente_documento.Text = cliente.Documento;
                cliente_celular.Text = cliente.Contato.Celular;
                cliente_telefone.Text = cliente.Contato.Telefone;
                cliente_email.Text = cliente.Contato.Email;
            }
        }

        private void save_edit_cliente_Click(object sender, EventArgs e)
        {
            if (list_cliente.SelectedItem != null)
            {
                var docExistente = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM CLIENTE WHERE DOCUMENTO = '" + cliente_documento.Text.FormatToDB() + "';");

                if (!docExistente.Any())
                {
                    var selectedcliente = Convert.ToInt32(list_cliente.SelectedItem.ToString().Split('|').First());
                    var cliente = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == selectedcliente);

                    cliente.Nome = cliente_nome.Text.FormatToDB();
                    cliente.Documento = cliente_documento.Text.FormatToDB();
                    cliente.Contato.Celular = cliente_celular.Text.FormatToDB();
                    cliente.Contato.Telefone = cliente_telefone.Text.FormatToDB();
                    cliente.Contato.Email = cliente_email.Text.FormatToDB();

                    Comercio.GerenciaEmpresa.Instance.Banco.Update("update cliente set nome = '" + cliente.Nome + "', documento = '" +
                        cliente.Documento + "', telefone = '" + cliente.Contato.Telefone + "', celular = '" + cliente.Contato.Celular +
                        "', email = '" + cliente.Contato.Email + "' where codigo = '" + cliente.Codigo + "'");

                    UpdateForm(selectedcliente);

                    Comercio.GerenciaEmpresa.Instance.SalvarClientes(Comercio.GerenciaEmpresa.Instance.Clientes);

                    MessageBox.Show("Salvo com sucesso.");

                }
                else
                {
                    MessageBox.Show("Documento Já Cadastrado!");
                }
            }
        }

        private void remove_cliente_Click(object sender, EventArgs e)
        {
            if (list_cliente.SelectedItem != null)
            {
                var selectedCliente = Convert.ToInt32(list_cliente.SelectedItem.ToString().Split('|').First());
                var remove = new RemoveCliente.RemoverCliente(selectedCliente);
                remove.ShowDialog();
                UpdateForm(selectedCliente);
            }
        }
    }
}
