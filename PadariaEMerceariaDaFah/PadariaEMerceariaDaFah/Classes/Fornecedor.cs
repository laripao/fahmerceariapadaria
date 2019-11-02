using Comercio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    [Serializable]
    public class Fornecedor
    {
        public int Codigo;
        public string Nome;
        public string Description;
        public Contato Contato;

        public Fornecedor(int codigo, string nome, string description, Contato contato)
        {
            Codigo = codigo;
            Nome = nome;
            Description = description;
            Contato = contato;
        }

        public void AtualizarFornecedor(Fornecedor Item)
        {
            this.Nome = Item.Nome;
            this.Description = Item.Description;
            this.Contato = Item.Contato;
        }


    }
}
