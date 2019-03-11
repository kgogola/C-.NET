using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasketballService.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        [Required(ErrorMessage = "You have to fill this field!")]
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }

        [DefaultValue("Default")]
        public string NameOfLogoFile { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}