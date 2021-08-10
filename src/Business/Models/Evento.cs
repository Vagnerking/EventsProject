using System;

namespace Business.Models
{

    public class Evento : Entity
    {

        public Guid ClienteId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public int Convidados { get; set; }

        public DateTime DataEvento { get; set; }

        public DateTime DataCadastro { get; set; }


        //Ef Relations
        public Cliente Cliente { get; set; }

        public EnderecoEvento Endereco { get; set; }

    }
}
