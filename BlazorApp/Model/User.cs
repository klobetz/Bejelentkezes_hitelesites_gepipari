using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage ="A felhasználó név kitöltése kötelező!")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "A jelszó mező kitöltése kötelező!")]
        [MaxLength(128)]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string Role { get; set; }
    }
}
