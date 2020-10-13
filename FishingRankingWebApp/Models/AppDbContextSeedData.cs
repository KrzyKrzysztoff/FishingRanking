using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    public class AppDbContextSeedData
    {
        private readonly AppDbContext context;

        public AppDbContextSeedData(AppDbContext context)
        {
            this.context = context;
        }
        public async void SeedUsersWithRoles()
        {
            var user_1 = new IdentityUser
            {
                UserName = "Krzysztof",
                NormalizedUserName = "Krzysztof",
                Email = "simple@wp.pl",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            var user_2 = new IdentityUser
            {
                UserName = "Radek",
                NormalizedUserName = "Radek",
                Email = "simple@wp.pl",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            var role_1 = new RoleStore<IdentityRole>(context);
            var role_2 = new RoleStore<IdentityRole>(context);
            if (!context.Roles.Any(s=>s.Name == "admin" || s.Name == "normalUser"))
            {
                await role_2.CreateAsync(new IdentityRole { Name = "normalUser", NormalizedName = "normalUser" });
                await role_1.CreateAsync(new IdentityRole { Name = "admin", NormalizedName = "admin" });
            }
            if (!context.Users.Any(s=>s.UserName == user_1.UserName || s.UserName == user_2.UserName))
            {
                var password = new PasswordHasher<IdentityUser>();
                var hashed_1 = password.HashPassword(user_1, "Admin1!");
                var hashed_2 = password.HashPassword(user_2, "User1!");
                user_1.PasswordHash = hashed_1;
                user_2.PasswordHash = hashed_2;
                var userStore_1 = new UserStore<IdentityUser>(context);
                var userStore_2 = new UserStore<IdentityUser>(context);
                await userStore_1.CreateAsync(user_1);
                await userStore_2.CreateAsync(user_2);
                await userStore_1.AddToRoleAsync(user_1, "admin");
                await userStore_2.AddToRoleAsync(user_2, "normalUser");
            }
            await context.SaveChangesAsync();
        }

        public async void SeedMembers()
        {
            var user_1 = new Member()
            {
                AmmountOfPoints = 0,
                FirstName = "Krzysztof",
                Fishes = null,
                LastCaughtFish = KindOfFish.empty,
                LastName = "Jaworski",
                PhotoPath = String.Empty,
                RecentActivity = DateTime.Now,
            };
            var user_2 = new Member()
            {
                AmmountOfPoints = 0,
                FirstName = "Tomek",
                Fishes = null,
                LastCaughtFish = KindOfFish.empty,
                LastName = "Przykład",
                PhotoPath = String.Empty,
                RecentActivity = DateTime.Now,
            };
            var user_3 = new Member()
            {
                AmmountOfPoints = 0,
                FirstName = "Karol",
                Fishes = null,
                LastCaughtFish = KindOfFish.empty,
                LastName = "Przykład",
                PhotoPath = String.Empty,
                RecentActivity = DateTime.Now,
            };
            if (!context.Members.Any(s=>s.FirstName == user_1.FirstName || s.FirstName == user_2.FirstName || s.FirstName == user_2.FirstName))
            {
                await context.AddRangeAsync(user_1, user_2, user_3);
            }
            await context.SaveChangesAsync();


        }
    }
}
