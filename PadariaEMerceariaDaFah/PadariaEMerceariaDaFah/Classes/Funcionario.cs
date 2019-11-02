using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    [Serializable]
    public class Funcionario
    {
        public int Codigo;
        public string Nome, Funcao;
        public Contato Contato;
        public Endereco Endereco;

        public Funcionario(int codigo, string nome, string funcao, Contato contato, Endereco endereco) 
        {
            Codigo = codigo;
            Nome = nome;
            Funcao = funcao;
            Contato = contato;
            Endereco = endereco;
        }

        public void AtualizarFuncionario(Funcionario Item) 
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Funcao = Item.Funcao;
            this.Contato = Item.Contato;
            this.Endereco = Item.Endereco;

        }
    }
}
