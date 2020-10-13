using FishingRankingWebApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext context;

        public AdminRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Member AddMember(Member user)
        {
            context.Add(user);
            context.SaveChanges();
            return user;
        }

       
        public void DeleteMember(int id)
        {
            var user = context.Members.FirstOrDefault(s => s.Id == id);
            context.Remove(user);
            context.SaveChanges();
        }

        public void EditMember(Member member)
        {
            var newUser = GetMember(member.Id);
            newUser.FirstName = member.FirstName;
            newUser.AmmountOfPoints = member.AmmountOfPoints;
            newUser.LastName = member.LastName;
            context.SaveChanges();
        }

        public Member GetMember(int id)
        {
            var member = context.Members.FirstOrDefault(s => s.Id == id);
            return member;
        }

        public IEnumerable<Member> ListOfMembers()
        {
            var list = context.Members;
            return list;
        }
    }
}
