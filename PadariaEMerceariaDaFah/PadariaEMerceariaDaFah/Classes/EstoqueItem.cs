using System;

namespace PadariaEMerceariaDaFah.Classes
{
    [Serializable]
    public class EstoqueItem
    {
        public int Codigo;
        public int CodProduto;
        public DateTime Validade;
        public int Quantidade;

        public EstoqueItem(int codigo, int codProduto, DateTime validade, int quantidade)
        {
            Codigo = codigo;
            CodProduto = codProduto;
            Validade = validade;
            Quantidade = quantidade;
        }

        public void AtualizarEstoque(EstoqueItem item)
        {
            this.CodProduto = item.CodProduto;
            this.Validade = item.Validade;
            this.Quantidade = item.Quantidade;
        }
    }
}
