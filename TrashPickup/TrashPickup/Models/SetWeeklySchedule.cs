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
        [ForeignKey("Week")]
        public int Week { get; set; }
        [ForeignKey("Day")]
        public int Day { get; set; }
    }
}