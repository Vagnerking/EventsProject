using System;
using System.Collections.Generic;

namespace Business.Models
{

    public class Cliente : Entity
    {

        public string NomeCompleto { get; set; }

        public int Tipo { get; set; }

        public string Documento { get; set; }

        public string Telefone { get; set; }

        public int Genero { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        //Ef Relations

        public IEnumerable<Evento> Eventos { get; set; }

        public Endereco Endereco { get; set; }

    }
}
