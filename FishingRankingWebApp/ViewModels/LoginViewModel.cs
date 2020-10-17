using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishingRankingWebApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Nazwa użytkownika wymagana!")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Hasło wymagane!")]
        [DataType(DataType.Password)]
        public string Passowrd { get; set; }
        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }
}
