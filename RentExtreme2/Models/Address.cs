using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Spatial;

namespace RentExtreme2.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public DbGeography Coordinates { get; set; }

        public virtual ICollection<Firm> Firms { get; set; }
        public Address() { Firms = new List<Firm>(); }
    }
}