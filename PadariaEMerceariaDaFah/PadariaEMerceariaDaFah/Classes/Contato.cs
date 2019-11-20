using System;

namespace Comercio
{
    [Serializable]
    public class Contato
    {
        public string Telefone, Celular, Email;

        public Contato(string telefone, string celular, string email) 
        {
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }
        public void AtualizarContato(Contato Item)
        {
            this.Telefone = Item.Telefone;
            this.Celular = Item.Celular;
            this.Email = Item.Email;
        }
    }
}
