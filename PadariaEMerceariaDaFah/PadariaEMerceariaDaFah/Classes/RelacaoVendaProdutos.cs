using System;

namespace Comercio
{
    [Serializable]
    public class RelacaoVendaProduto
    {
        public int Codigo;
        public int CodItem;
        public int CodVenda;
        public int Quantidade;
        public RelacaoVendaProduto(int codigo, int codItem, int codVenda, int quantidade)
        {
            Codigo = codigo;
            CodItem = codItem;
            CodVenda = codVenda;
            Quantidade = quantidade;
        }
        public void AtualizarRelacaoVendaProduto(RelacaoVendaProduto Item)
        {
            this.Codigo = Item.Codigo;
            this.CodItem = Item.CodItem;
            this.CodVenda = Item.CodVenda;
            this.Quantidade = Item.Quantidade;
        }
    }
}
