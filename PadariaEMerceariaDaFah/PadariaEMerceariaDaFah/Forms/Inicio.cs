using Comercio;
using PadariaEMerceariaDaFah.Forms;
using PadariaEMerceariaDaFah.Forms.Gerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void go_gerencia_Click(object sender, EventArgs e)
        {
            var gerencia = new GerenciaInicio();
            gerencia.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            var gerenciaEmpresa = new GerenciaEmpresa();
        }
    }
}
