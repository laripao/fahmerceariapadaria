using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    [Serializable]
    public class Endereco
    {
        public string Rua, Cidade, Estado, Pais, CEP, Numero;

        public Endereco(string rua,string cidade,string estado,string pais,string cep,string numero) 
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            CEP = cep;
            Numero = numero;
        }
        public void AtualizarEndereco(Endereco Item) 
        {
            this.Rua = Item.Rua;
            this.Cidade = Item.Cidade;
            this.Estado = Item.Estado;
            this.Pais = Item.Pais;
            this.CEP = Item.CEP;
            this.Numero = Item.Numero;
        }
    }
}
