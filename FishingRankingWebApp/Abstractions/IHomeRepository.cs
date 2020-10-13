using FishingRankingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Abstractions
{
    public interface IHomeRepository
    {
        IEnumerable<Fish> GetListOfFishes();
        IEnumerable<Fish> DeleteFish(int id);
    }
}
