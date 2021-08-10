using System.ComponentModel.DataAnnotations;

namespace Business.Enums
{
    public enum EGeneros
    {
        [Display(Name = "Masculino")]
        Masculino = 0,
        [Display(Name = "Feminino")]
        Feminino = 1,
        [Display(Name = "Empresarial")]
        Empresarial = 2
    }
}
