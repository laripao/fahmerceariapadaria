using PadariaEMerceariaDaFah.Enums;
using System;

namespace Comercio
{
    [Serializable]
    public class Produto
    {
        public int Codigo;
        public string Nome, Descricao;
        public Produto_tipo Tipo;
        public double Valor;
        public int? codFuncionario;

        public Produto(int codigo, string nome, string descricao, Produto_tipo tipo,double valor, int? funcionario)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            codFuncionario = funcionario;
            Tipo = tipo;

        }
        public void AtualizarProduto(Produto Item)
        {
            this.Codigo = Item.Codigo;
            this.Nome = Item.Nome;
            this.Descricao = Item.Descricao;
            this.Valor = Item.Valor;
            this.codFuncionario = Item.codFuncionario;
            this.Tipo = Item.Tipo;
        }
    }
}
