using PadariaEMerceariaDaFah.Forms.Estoque.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque
{
    public partial class EstoqueInicio : Form
    {
        public EstoqueInicio()
        {
            InitializeComponent();
        }

        private void show_produtos_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoInicio();
            produto.ShowDialog();
        }
    }
}
