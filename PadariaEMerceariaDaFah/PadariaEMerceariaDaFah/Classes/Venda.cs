using System;

namespace Comercio
{
    [Serializable]
    public class Venda
    {
        public int Codigo;
        public int Funcionario;
        public int Cliente;
        public DateTime Data;

        public Venda(int codigo, DateTime data, int funcionario, int cliente)
        {
            Codigo = codigo;
            Funcionario = funcionario;
            Cliente = cliente;
            Data = data;
        }

        public void AtualizarVenda(Venda Item)
        {
            this.Codigo = Item.Codigo;
            this.Funcionario = Item.Funcionario;
            this.Cliente = Item.Cliente;
            this.Data = Item.Data;
        
        }
    }
}
