using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Cliente.RemoveCliente
{
    public partial class RemoverCliente : Form
    {
        public int Code;
        public RemoverCliente(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void cancel_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoverCliente_Load(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var cliente = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == Code);

                cliente_nome.Text = cliente.Nome;
                cliente_documento.Text = cliente.Documento;
                cliente_celular.Text = cliente.Contato.Celular;
                cliente_telefone.Text = cliente.Contato.Telefone;
                cliente_email.Text = cliente.Contato.Email;
            }
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if (Code != 0)
            {
                var cliente = Comercio.GerenciaEmpresa.Instance.Clientes.FirstOrDefault(x => x.Codigo == Code);
                try
                {
                    Comercio.GerenciaEmpresa.Instance.Clientes.Remove(cliente);
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("delete from cliente where codigo = '" + cliente.Codigo + "'");
                    Comercio.GerenciaEmpresa.Instance.SalvarClientes(Comercio.GerenciaEmpresa.Instance.Clientes);
                    MessageBox.Show("Cliente Removido.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu Errado:" + ex.Message);
                }
                this.Close();
            }
        }
    }
}
