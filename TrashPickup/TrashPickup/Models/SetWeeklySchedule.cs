using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class SetWeeklySchedule
    {
        [Key]

        public int ScheduleId { get; set; }
        //[ForeignKey("Week")]
        //public int week { get; set; }
        //public Week Week { get; set; }
        [ForeignKey("Day")]
        public int day { get; set; }
        public Day Day { get; set; }
        public string Email { get; set; }

    }
}

//public Application User {get; , set;}
//[FOreignKey("User"]
//public int UserId {get; set; }