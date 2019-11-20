using System;

namespace Comercio
{
    [Serializable]
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public string Documento;
        public Contato Contato;

        public Cliente(int codigo, string nome,string documento, Contato contato) 
        {
            Codigo = codigo;
            Nome = nome;
            Contato = contato;
            Documento = documento;
        }

        public void AtualizarCliente(Cliente Item) 
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Contato = Item.Contato;
            this.Documento = Item.Documento;

        }
    }
}
