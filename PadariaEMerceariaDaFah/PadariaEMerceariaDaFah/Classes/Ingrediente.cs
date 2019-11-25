using System;

namespace Comercio
{
    [Serializable]
    public class Ingrediente
    {
        public int Codigo;
        public string Nome;
        public DateTime Validade;
        public double Valor;
        public int Quantidade;
        public bool Ativo;
        public Ingrediente(int codigo, string nome, DateTime validade, double valor, int quantidade, bool ativo = true)
        {
            Codigo = codigo;
            Nome = nome;
            Valor = valor;
            Validade = validade;
            Quantidade = quantidade;
            Ativo = ativo;
        }
        public void AtualizarIngrediente(Ingrediente Item)
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Valor = Item.Valor;
            this.Validade = Item.Validade;
            this.Quantidade = Item.Quantidade;
            this.Ativo = Item.Ativo;
        }
    }
}
