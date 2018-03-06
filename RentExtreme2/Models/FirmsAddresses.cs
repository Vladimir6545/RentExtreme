using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentExtreme2.Models
{
    public class FirmsAddresses
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public int AddressId { get; set; }
        public string Phone { get; set; }
        public Firm Firm { get; set; }
        public Address Address { get; set; }
    }
}