using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentExtreme2.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        [MaxLength(25)]
        [Index(IsUnique = true)]
        public string UniqueName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public Firm()
        {
            Addresses = new List<Address>();
            Services = new List<Service>();
        }
    }
}