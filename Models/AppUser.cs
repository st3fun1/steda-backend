using Microsoft.AspNetCore.Identity;


namespace Steda_backend.Models {
    public class AppUser : IdentityUser {
        public string DisplayName { get; set; }
    }
}