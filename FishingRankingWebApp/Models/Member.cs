using FishingRankingWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    
    [Table("Members")]
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        public int? AmmountOfPoints { get; set; }
        public DateTime RecentActivity { get; set; }
        public string PhotoPath { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        public KindOfFish? LastCaughtFish { get; set; }
        public virtual ICollection<Fish> Fishes { get; set; }
        

    }
}
