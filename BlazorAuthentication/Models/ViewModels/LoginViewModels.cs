using System.ComponentModel.DataAnnotations;

namespace BlazorAuthentication.Models.ViewModels
{
    public class LoginViewModels
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese el nombre de usuario")]
        public string? Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="Por favor ingrese su Password")]
        public string? Password { get; set; }

    }
}
