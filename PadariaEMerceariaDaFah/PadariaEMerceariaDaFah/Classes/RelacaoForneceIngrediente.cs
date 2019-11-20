using System;

namespace Comercio
{
    [Serializable]
    public class RelacaoForneceIngrediente
    {
        public int Codigo;
        public int CodFornecedor;
        public int CodIngrediente;
        public RelacaoForneceIngrediente(int codigo, int codFornecedor, int codIngrediente)
        {
            Codigo = codigo;
            CodFornecedor = codFornecedor;
            CodIngrediente = codIngrediente;
        }
        public void AtualizarRelacaoFornece(RelacaoForneceIngrediente Item)
        {
            this.Codigo = Item.Codigo;
            this.CodIngrediente = Item.CodIngrediente;
            this.CodFornecedor = Item.CodFornecedor;
        }
    }
}
