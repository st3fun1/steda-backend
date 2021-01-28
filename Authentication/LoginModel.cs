using System.ComponentModel.DataAnnotations;

namespace Steda_backend.Authentication {
    public class LoginModel {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set;}
    }
}