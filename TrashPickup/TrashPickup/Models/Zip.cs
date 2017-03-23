using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Zip
    {
        [Key]

        public int zipCode { get; set; }
    }
}