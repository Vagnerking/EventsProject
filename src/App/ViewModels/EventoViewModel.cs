using App.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.ViewModels
{

    public class EventoViewModel
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "É necessário informar o Cliente")]
        [Display(Name = "Cliente")]
        public Guid ClienteId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string? Titulo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O Campo {0} deve conter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string? Descricao { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Valor { get; set; }

        [Display(Name = "Convidados")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1,5000)]
        public int Convidados { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Data Evento")]
        [RegularExpression(@"\d{2,2}/\d{2,2}/\d{4,4} \d{2,2}:\d{2,2}", ErrorMessage = "Data errada, use o Ex: 01/01/2000 01:30")]
        public string DataEvento { get; set; }

        [Display(Name = "Data Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        //Ef Relations
        [Display(Name = "Cliente")]
        public ClienteViewModel? Cliente { get; set; }

        public EnderecoEventoViewModel Endereco { get; set; }

        //To populate Create.
        [NotMapped]
        public IEnumerable<ClienteViewModel>? Clientes { get; set; }

    }
}
