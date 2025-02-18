using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GStore.Models;

public class Usuario : IdentityUser
{
    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }
    [Display(Name = "Data de nascimento")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }
    [StringLength(200)]
    public string Foto { get; set; }
}
