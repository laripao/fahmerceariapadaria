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
        public string Nome, Funcao, CPF;
        public Contato Contato;
        public Endereco Endereco;
        public bool Ativo;

        public Funcionario(int codigo, string nome, string funcao, string cpf, Contato contato, Endereco endereco, bool ativo = true) 
        {
            Codigo = codigo;
            Nome = nome;
            Funcao = funcao;
            Contato = contato;
            Endereco = endereco;
            CPF = cpf;
            Ativo = ativo;
        }

        public void AtualizarFuncionario(Funcionario Item) 
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Funcao = Item.Funcao;
            this.CPF = Item.CPF;
            this.Contato = Item.Contato;
            this.Endereco = Item.Endereco;
            this.Ativo = Item.Ativo;

        }
    }
}
