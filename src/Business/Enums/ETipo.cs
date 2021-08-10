using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Business.Enums
{
    public enum ETipo
    {
        [Display(Name = "Pessoa Física")]
        PessoaFisica = 0,
        [Display(Name = "Pessoa Jurídica")]
        PessoaJuridica = 1
    }

}
