﻿using FishingRankingWebApp.Models;
using FishingRankingWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Abstractions
{
    public  interface IUserRepository
    {
        IEnumerable<Member> GetMembers();
        void AddFish(FishViewModel fish, string userName);
   
    }
}
