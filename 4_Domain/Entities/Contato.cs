using System;

namespace NovaAgendaTelefonica.4_Domain.Entities
{
    public class Contato
    {

        public Contato()
        {
            ContatoId = Guid.NewGuid();
        }

        public Guid ContatoId { get; set; }

        public string Nome {get;set;}

        public string Endereço { get; set; }

        public string Cep { get; set; } 

        public string Bairro { get; set; }

        public string Cidade { get; set; }  

        public string Uf { get; set; }

        public string Email { get; set; }   

        public 	string Instagram { get; set; } 

        public string Facebook { get; set; }

        public bool Ativo { get; set; }     
    }
}