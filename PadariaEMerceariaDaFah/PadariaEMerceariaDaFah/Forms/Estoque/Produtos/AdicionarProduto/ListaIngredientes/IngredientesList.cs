using PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes;
using PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes.AdicionarIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaProdutos
{
    public partial class IngredientesList : Form
    {
        public string nomeIngrediente;
        public int codIngrediente;
        public double qtdIngrediente;
        public IngredientesList()
        {
            InitializeComponent();
        }

        private void add_produto_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_ingrediente_Click_Click(object sender, EventArgs e)
        {
            var ingrediente = new IngredientesInicio();
            ingrediente.ShowDialog();
            UpdateForm();
        }

        private void go_addIngrediente_Click(object sender, EventArgs e)
        {
            var ingrediente = new AddIngrediente();
            ingrediente.ShowDialog();
            UpdateForm();
        }

        private void IngredientesList_Load(object sender, EventArgs e)
        {
            list_ingrediente.Items.Clear();
            var ingrediente = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("SELECT * FROM ESTOQUE_INGREDIENTE WHERE ATIVO = '" + 1 + "';");

            foreach (var item in ingrediente)
            {
                list_ingrediente.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
        }
        private void UpdateForm(int Selected = 0)
        {
            list_ingrediente.Items.Clear();
            var ingrediente = Comercio.GerenciaEmpresa.Instance.CarregarIngredientesBanco("SELECT * FROM ESTOQUE_INGREDIENTE WHERE ATIVO = '" + 1 + "';");

            foreach (var item in ingrediente)
            {
                list_ingrediente.Items.Add(item.Codigo.ToString() + "|" + item.Nome);
            }
            if (Selected != 0)
            {
                var ingredienteSelected = Comercio.GerenciaEmpresa.Instance.Ingredientes.FirstOrDefault(x => x.Codigo == Selected);
                if (ingredienteSelected != null)
                {
                    var index = list_ingrediente.Items.IndexOf(ingredienteSelected.Codigo.ToString() + "|" + ingredienteSelected.Nome);
                    list_ingrediente.SetSelected(index, true);
                }
            }
        }

        
        private void add_produto_ingrediente_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void list_ingrediente_DoubleClick(object sender, EventArgs e)
        {
            if (list_ingrediente.SelectedItem != null)
            {
                string[] aux = list_ingrediente.SelectedItem.ToString().Split('|');
                nomeIngrediente = aux[1];

                qtdIngrediente = Convert.ToDouble(quantidade_text.Text);
                codIngrediente = Convert.ToInt32(aux[0].Trim());
                this.Close();
            }
        }

        private void quantidade_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';

                if (quantidade_text.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ok_button_qtd_Click(object sender, EventArgs e)
        {
            list_ingrediente.Enabled = true;
        }
    }
}
