using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentExtreme2.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Firm> Firms { get; set; }
        public Service() { Firms = new List<Firm>(); }
    }
}