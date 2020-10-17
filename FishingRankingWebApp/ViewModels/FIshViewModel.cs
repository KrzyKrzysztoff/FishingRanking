
using FishingRankingWebApp.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.ViewModels
{
    public class FishViewModel
    {
        [Required(ErrorMessage ="Pole wymagane!")]
        public KindOfFish? KindOfFish { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        [MaxLength(25, ErrorMessage = "Maksymalna liczba znaków to 25!")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        public int? Lenght { get; set; }
    
        public int? Point { get; set; }
        [Required(ErrorMessage = "Zdjęcie wymagane!")]
        public IFormFile FishImage { get; set; }

    }
}
