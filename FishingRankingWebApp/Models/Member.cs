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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int AmmountOfPoints { get; set; }
        [Required]
        public DateTime RecentActivity { get; set; }
        public string PhotoPath { get; set; }
       
        public KindOfFish LastCaughtFish { get; set; }
        public virtual ICollection<Fish> Fishes { get; set; }

    }
}
