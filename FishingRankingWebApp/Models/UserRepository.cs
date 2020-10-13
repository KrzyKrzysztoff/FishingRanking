using FishingRankingWebApp.Abstractions;
using FishingRankingWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void AddFish(FishViewModel fish, string userName)
        {
            var user = context.Members.FirstOrDefault(s => s.FirstName == userName);
            
            switch (fish.KindOfFish)
            {
                case KindOfFish.empty:
                    fish.Point = 0;
                    break;
                case KindOfFish.pike:
                    fish.Point = 5;
                    break;
                case KindOfFish.perch:
                    fish.Point = 1;
                    break;
                case KindOfFish.catfish:
                    fish.Point = 25;
                    break;
                case KindOfFish.zander:
                    fish.Point = 7;
                    break;
                case KindOfFish.chub:
                    fish.Point = 5;
                    break;
                case KindOfFish.asp:
                    fish.Point = 7;
                    break;
                case KindOfFish.trout:
                    fish.Point = 25;
                    break;
                default:
                    break;
            }
            Fish newFish = new Fish()
            {
                KindOfFish = fish.KindOfFish,
                Lenght = fish.Lenght,
                Location = fish.Location,
                Point = fish.Point,
                MemberId = user.Id,
               
            };
            user.AmmountOfPoints += fish.Point;
            context.Fishes.Add(newFish);
            user.Fishes.Add(newFish);
            user.RecentActivity = DateTime.Now;
            user.LastCaughtFish = newFish.KindOfFish;
            context.SaveChanges();

        }

        public IEnumerable<Member> GetMembers()
        {
            var list = context.Members;
            return list;
        }

    }
}
