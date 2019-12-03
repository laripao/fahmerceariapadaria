using PadariaEMerceariaDaFah.Forms.Gerencia.Cliente;
using PadariaEMerceariaDaFah.Forms.Gerencia.Cliente.AddCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaClientes
{
    public partial class ClienteList : Form
    {
        public int codCliente;
        public string nomeCliente;
        public ClienteList()
        {
            InitializeComponent();
        }

        private void add_cliente_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_addCliente_Click(object sender, EventArgs e)
        {
            var cliente = new AddCliente();
            cliente.ShowDialog();
            UpdateForm();
        }

        private void go_cliente_Click_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteInicio();
            cliente.ShowDialog();
            UpdateForm();
        }

        private void ClienteList_Load(object sender, EventArgs e)
        {
            nomeCliente = "";

            codCliente = 0;

            list_cliente.Items.Clear();

            var clientes = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM laripaos.CLIENTE;");

            foreach(var item in clientes)
            {
                list_cliente.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
        }
        private void UpdateForm(int Selected = 0)
        {
            list_cliente.Items.Clear();

            var clientes = Comercio.GerenciaEmpresa.Instance.CarregarClientesBanco("SELECT * FROM laripaos.CLIENTE;");

            foreach (var item in clientes)
            {
                list_cliente.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
            if (Selected != 0)
            {
                var ClienteSelected = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == Selected);
                if (ClienteSelected != null)
                {
                    var index = list_cliente.Items.IndexOf(ClienteSelected.Codigo.ToString() + "|" + ClienteSelected.Nome);
                    list_cliente.SetSelected(index, true);
                }
            }
        }

        private void list_cliente_DoubleClick(object sender, EventArgs e)
        {
            if (list_cliente != null)
            {
                string[] aux = list_cliente.SelectedItem.ToString().Split('|');
                
                codCliente = Convert.ToInt32(aux[0].Trim());
                nomeCliente = aux[1];

                this.Close();
            }
        }
    }
}
