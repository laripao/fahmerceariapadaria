using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    [Serializable]
    public class Venda
    {
        public int Codigo;
        public Funcionario Funcionario;
        public Cliente Cliente;
        public Produto Produto;
        public string Data;

        public Venda(int codigo, Funcionario funcionario, Cliente cliente, Produto produto, string data)
        {
            Codigo = codigo;
            Funcionario = funcionario;
            Cliente = cliente;
            Produto = produto;
            Data = data;
        }

        public void AtualizarVenda(Venda Item)
        {
            this.Codigo = Item.Codigo;
            this.Funcionario = Item.Funcionario;
            this.Cliente = Item.Cliente;
            this.Produto = Item.Produto;
            this.Data = Item.Data;
        
        }
    }
}
