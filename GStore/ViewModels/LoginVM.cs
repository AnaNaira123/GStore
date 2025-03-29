using System.ComponentModel.DataAnnotations;
namespace GStore.ViewModels;

public class LoginVM
{
     [Display(Name = "Email ou Nome de Usuario", Prompt = "Informe seu Email ou Nome de Usuário")]   
     [Required(ErrorMessage = "Por Favor, informe seu email e nome de usuário")]

     public string Email {get; set; }

     [Display(Name = "Senha de Acesso", Prompt = "********")]
     [Required(ErrorMessage = "Por Favor, informe sua senha")]
     [DataType(DataType.Password)]

     public string Senha {get; set;}

     [Display(Name = "Manter Conectado?")]

     public bool Lembrar {get; set;} = false;

     public string UrlRetorno {get; set; }
    }

