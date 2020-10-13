
using FishingRankingWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.ViewModels
{
    public class FishViewModel
    {
      [Required]
        public KindOfFish KindOfFish { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Lenght { get; set; }
        [Required]
        public int Point { get; set; }

    }
}
