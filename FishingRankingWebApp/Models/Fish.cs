using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    [Table("Fishes")]
    public class Fish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public KindOfFish KindOfFish { get; set; }
        public string Location { get; set; }
        public int Lenght { get; set; }

        [ForeignKey("Members")]
        public int MemberId { get; set; }
        public virtual Member Members { get; set; }
    }
}
