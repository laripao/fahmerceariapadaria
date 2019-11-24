using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Estoque.Itens.RemoverItem
{
    public partial class RemoverItem : Form
    {
        public int Code;
        public RemoverItem(int code)
        {
            InitializeComponent();
            Code = code;
        }

        private void cancel_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acc_remove_Click(object sender, EventArgs e)
        {
            if(Code != 0)
            {
                var item = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == Code);

                try
                {
                    Comercio.GerenciaEmpresa.Instance.EstoqueItens.Remove(item);
                    Comercio.GerenciaEmpresa.Instance.Banco.Delete("DELETE FROM ITEM_ESTOQUE WHERE COD_ITEM = " + item.Codigo );
                    Comercio.GerenciaEmpresa.Instance.SalvarEstoqueItens(Comercio.GerenciaEmpresa.Instance.EstoqueItens);
                    MessageBox.Show("Item Removido");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu errado: " + ex.Message);
                }
                finally
                {
                    this.Close();
                }
            }
        }

        private void RemoverItem_Load(object sender, EventArgs e)
        {
            if(Code != 0)
            {
                var item = Comercio.GerenciaEmpresa.Instance.EstoqueItens.FirstOrDefault(x => x.Codigo == Code);
                var produto = Comercio.GerenciaEmpresa.Instance.Produtos.FirstOrDefault(x => x.Codigo == item.CodProduto);

                produto_nome.Text = produto.Nome;
                data_validade.Value = item.Validade;
                qtd_text.Text = item.Quantidade.ToString();
            }
        }
    }
}
