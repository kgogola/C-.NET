using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasketballService.Models
{
    [DefaultValue(Active)]
    public enum StateEnum
    {
        Active, Injured, Suspended
    }

    public class Player
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        [Required(ErrorMessage = "You have to fill this field!")]
        public string PlayerName { get; set; }
        [Required(ErrorMessage = "You have to fill this field!")]
        public string PlayerSurname { get; set; }
        public DateTime PlayerBornDate { get; set; }
        public string PlayerPosition { get; set; }
        [DefaultValue("Default")]
        public string NameOfPlayerPhotoFile { get; set; }       
        public StateEnum State { get; set; }
        public bool inSquad { get; set; }

        public virtual Team Team { get; set; }
    }
}