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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AmmountOfPoints { get; set; }
        public DateTime RecentActivity { get; set; }
        public string PhotoPath { get; set; }
        public KindOfFish LastCaughtFish { get; set; }
        public virtual ICollection<Fish> Fishes { get; set; }

    }
}
