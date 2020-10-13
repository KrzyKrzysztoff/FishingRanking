using FishingRankingWebApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    public class HomeRepository : IHomeRepository
    {
        private readonly AppDbContext context;

        public HomeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Fish> DeleteFish(int id)
        {
            var fish = context.Fishes.FirstOrDefault(s => s.Id == id);
            var userId = fish.MemberId;
            var user = context.Members.FirstOrDefault(s => s.Id == userId);
            user.AmmountOfPoints -= fish.Point;
            context.Fishes.Remove(fish);
            context.SaveChanges();
            return GetListOfFishes();
        }

        public IEnumerable<Fish> GetListOfFishes()
        {
            var list = context.Fishes;
            return list;
        }
    }
}
