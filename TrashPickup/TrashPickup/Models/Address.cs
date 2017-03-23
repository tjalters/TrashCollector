using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string StreetAddress { get; set; }
        [ForeignKey("city")]
        public int City { get; set; }
        //public City city { get; set; }
        [ForeignKey("zipcode")]
        public int Zipcode { get; set; }
        public Zip Zip { get; set; }


    }
}