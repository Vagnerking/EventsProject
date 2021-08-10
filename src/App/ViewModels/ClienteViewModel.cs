using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{

    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string? NomeCompleto { get; set; }

        [Required(ErrorMessage = "O Tipo é necessário")]
        [Range(0, 1, ErrorMessage = "Tipo Inválido!")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O Campo {0} está incorreto", MinimumLength = 14)]
        public string? Documento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(15, ErrorMessage = "O Campo {0} deve conter o DDD + 9 dígitos", MinimumLength = 15)]
        public string? Telefone { get; set; }

        [DisplayName("Gênero")]
        [Required(ErrorMessage = "O Gênero é necessário")]
        [Range(0, 2, ErrorMessage = "Gênero Inválido!")]
        public int Genero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayName("Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Cadastrado Em")]
        public DateTime DataCadastro { get; set; }


        public bool Ativo { get; set; }

        //Ef Relations

        public IEnumerable<EventoViewModel>? Eventos { get; set; }

        public EnderecoViewModel Endereco { get; set; }

    }
}
