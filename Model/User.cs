using System.ComponentModel.DataAnnotations;

namespace Autenticacion.Model
{
    public class User
    {
        [Required] //Verificar que se importo using System.ComponentModel.DataAnnotations;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
