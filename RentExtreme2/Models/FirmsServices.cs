using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentExtreme2.Models
{
    public class FirmsServices
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public int ServiceId { get; set; } 
        public Firm Firms { get; set; }
        public Service Serices { get; set; }
    }
}