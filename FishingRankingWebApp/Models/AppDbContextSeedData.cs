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
            var user_3 = new IdentityUser
            {
                UserName = "Marcin",
                NormalizedUserName = "Marcin",
                Email = "simple@wp.pl",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            var user_4 = new IdentityUser
            {
                UserName = "Bartek",
                NormalizedUserName = "Bartek",
                Email = "simple@wp.pl",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            var user_5 = new IdentityUser
            {
                UserName = "Norbert",
                NormalizedUserName = "Norbert",
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
                var hashed_2 = password.HashPassword(user_2, "Admin123!");
                var hashed_3 = password.HashPassword(user_3, "Siema1!");
                var hashed_4 = password.HashPassword(user_4, "Elo1!");
                var hashed_5 = password.HashPassword(user_5, "Witam1!");
                user_1.PasswordHash = hashed_1;
                user_2.PasswordHash = hashed_2;
                user_3.PasswordHash = hashed_3;
                user_4.PasswordHash = hashed_4;
                user_5.PasswordHash = hashed_5;
                var userStore_1 = new UserStore<IdentityUser>(context);
                var userStore_2 = new UserStore<IdentityUser>(context);
                var userStore_3 = new UserStore<IdentityUser>(context);
                var userStore_4 = new UserStore<IdentityUser>(context);
                var userStore_5 = new UserStore<IdentityUser>(context);
                await userStore_1.CreateAsync(user_1);
                await userStore_2.CreateAsync(user_2);
                await userStore_3.CreateAsync(user_3);
                await userStore_4.CreateAsync(user_4);
                await userStore_5.CreateAsync(user_5);
                await userStore_1.AddToRoleAsync(user_1, "admin");
                await userStore_2.AddToRoleAsync(user_2, "admin");
                await userStore_3.AddToRoleAsync(user_3, "normalUser");
                await userStore_4.AddToRoleAsync(user_4, "normalUser");
                await userStore_5.AddToRoleAsync(user_5, "normalUser");
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
