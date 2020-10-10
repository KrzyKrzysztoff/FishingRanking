using FishingRankingWebApp.Abstractions;
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
        public void AddFish(Fish fish, string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetMembers()
        {
            var list = context.Members;
            return list;
        }
    }
}
