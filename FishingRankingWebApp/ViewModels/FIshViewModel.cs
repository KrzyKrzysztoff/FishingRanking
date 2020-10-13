
using FishingRankingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.ViewModels
{
    public class FishViewModel
    {
      
        public KindOfFish KindOfFish { get; set; }
        public string Location { get; set; }
        public int Lenght { get; set; }
        public int Point { get; set; }

    }
}
