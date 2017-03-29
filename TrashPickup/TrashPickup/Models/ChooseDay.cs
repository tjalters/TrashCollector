using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class ChooseDay
    {
        [Key]

        public int ChooseDayId { get; set; }

        [ForeignKey("DayOfWeek")]

        public int DayId { get; set; }
        public  Day DayOfWeek { get; set; }

    }
}