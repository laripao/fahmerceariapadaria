using System;

namespace Comercio
{
    [Serializable]
    public class RelacaoProdutoUtilizaIngrediente
    {
        public int Codigo;
        public int CodProduto;
        public int CodIngrediente;
        public int Quantidade;

        public RelacaoProdutoUtilizaIngrediente(int codigo, int codProduto, int codIngrediente, int quantidade)
        {
            Codigo = codigo;
            CodIngrediente = codIngrediente;
            CodProduto = codProduto;
            Quantidade = quantidade;
        }
        public void AtualizarRelacaoProdutoUtilizaIngrediente(RelacaoProdutoUtilizaIngrediente Item)
        {
            this.Codigo = Item.Codigo;
            this.CodIngrediente = Item.CodIngrediente;
            this.CodProduto = Item.CodProduto;
            this.Quantidade = Item.Quantidade;
        }
    }
}
