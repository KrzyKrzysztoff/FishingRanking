using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.Models
{
    public enum KindOfFish
    {
        [Display(Name = "Brak")]
        empty,
        [Display(Name = "Szczupak")]
        pike,
        [Display(Name ="Okoń")]
        perch,
        [Display(Name = "Sum")]
        catfish,
        [Display(Name = "Sandacz")]
        zander,
        [Display(Name = "Kleń")]
        chub,
        [Display(Name = "Boleń")]
        asp,
        [Display(Name = "Pstrąg")]
        trout

    }
}
