using Steda_backend.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Steda_backend.Migrations {
    public class Seed
    {
        public static async Task SeedData(AppDbContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any()) {
                var user = new AppUser
                {
                    DisplayName="Quinntrix",
                    NormalizedUserName = "stefan.timosenco",
                    Email = "stefantimosenco@gmail.com",
                    NormalizedEmail = "email@email.com",
                    EmailConfirmed = true,
                    UserName = "stefan.timosenco",
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Pa$$sword");

                await userManager.CreateAsync(user, hashed);
            }

            if (context.Photos.Count() < 10) {
                var photos = new List<Photo>{
                    new Photo {
                        Description = $"A photo {context.Photos.Count() + 1}",
                        Name = "A photo",
                        Url = "www.google.com"
                    }
                };

                foreach(var photo in photos) {
                    context.Photos.AddRange(photo);
                }
            }

            await context.SaveChangesAsync();
        }
    }
}