using System;

namespace Comercio
{
    [Serializable]
    public class Fornecedor
    {
        public int Codigo;
        public string Nome;
        public string Description;
        public Contato Contato;
        public bool Ativo;

        public Fornecedor(int codigo, string nome, string description, Contato contato, bool ativo = true)
        {
            Codigo = codigo;
            Nome = nome;
            Description = description;
            Contato = contato;
            Ativo = ativo;
        }

        public void AtualizarFornecedor(Fornecedor Item)
        {
            this.Nome = Item.Nome;
            this.Description = Item.Description;
            this.Contato = Item.Contato;
            this.Ativo = Item.Ativo;
        }


    }
}
