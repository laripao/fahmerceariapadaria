using System;
using System.Collections.Generic;
using PadariaEMerceariaDaFah.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    [Serializable]
    public class Produto
    {
        public int Codigo;
        public string Nome, Descricao;
        public Produto_tipo Tipo;
        public double Valor;
        public int? codFornecedor;
        public List<string> Ingredientes = new List<string>();

        public Produto(int codigo, string nome, string descricao, Produto_tipo tipo,double valor, int? fornecedor, List <string> ingredientes)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            codFornecedor = fornecedor;
            Tipo = tipo;

            foreach(var item in ingredientes)
            {
                Ingredientes.Add(item.ToString());
            }


        }
        public void AtualizarProduto(Produto Item)
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Descricao = Item.Descricao;
            this.Valor = Item.Valor;
            this.codFornecedor = Item.codFornecedor;
            this.Tipo = Item.Tipo;

            foreach(var itens in Item.Ingredientes)
            {
                this.Ingredientes.Add(itens.ToString());
            }
        }
    }
}
