using System;

namespace Comercio
{
    [Serializable]
    public class RelacaoForneceProduto
    {
        public int Codigo;
        public int CodFornecedor;
        public int CodProduto;
        public double Valor;
        public RelacaoForneceProduto(int codigo, int codFornecedor, int codProduto, double valor)
        {
            Codigo = codigo;
            CodFornecedor = codFornecedor;
            CodProduto = codProduto;
            Valor = valor;
        }
        public void AtualizarRelacaoForneceProduto(RelacaoForneceProduto Item)
        {
            this.Codigo = Item.Codigo;
            this.CodProduto = Item.CodProduto;
            this.CodFornecedor = Item.CodFornecedor;
            this.Valor = Item.Valor;
        }
    }
}
