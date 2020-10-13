using FishingRankingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Abstractions
{
  public  interface IAdminRepository
    {
        IEnumerable<Member> ListOfMembers();
        Member GetMember(int id);
        void DeleteMember(int id);
        void EditMember(Member user);
        Member AddMember(Member user);
    }
}
