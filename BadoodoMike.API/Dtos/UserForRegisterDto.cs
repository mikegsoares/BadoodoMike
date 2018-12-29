using System.ComponentModel.DataAnnotations;

namespace BadoodoMike.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        public string Password { get; set; }
    }
}