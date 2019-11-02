using System;
using System.Collections.Generic;
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
        public double Valor;

        public Produto(int codigo, string nome, string descricao, double valor)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }
        public void AtualizarProduto(Produto Item)
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Descricao = Item.Descricao;
            this.Valor = Item.Valor;
        }
    }
}
