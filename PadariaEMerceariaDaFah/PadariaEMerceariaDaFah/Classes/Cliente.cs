using System;

namespace Comercio
{
    [Serializable]
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;
        public Endereco Endereco;

        public Cliente(int codigo, string nome, Contato contato, Endereco endereco) 
        {
            Codigo = codigo;
            Nome = nome;
            Contato = contato;
            Endereco = endereco;
        }

        public void AtualizarCliente(Cliente Item) 
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Contato = Item.Contato;
            this.Endereco = Item.Endereco;

        }
    }
}
