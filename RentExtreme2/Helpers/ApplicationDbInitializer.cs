using RentExtreme2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace RentExtreme2.Helpers
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Person persone1 = new Person { Id = 1, Login = "Егор", Password = "123456", PasswordConfirm = "123456", Email = "kvvitshag@gmail.com", FootSize = 40, Growth = 170, Telephone = 0683980468, TermsAccepted = true };
            Person persone2 = new Person { Id = 2, Login = "Михаил", Password = "178456", PasswordConfirm = "178456", Email = "kvv@gmail.com", FootSize = 35, Growth = 159, Telephone = 0983980468, TermsAccepted = true };
            Person persone3 = new Person { Id = 3, Login = "Владимир", Password = "321456", PasswordConfirm = "321456", Email = "itshag@gmail.com", FootSize = 43, Growth = 165, Telephone = 0783980468, TermsAccepted = true };
            Person persone4 = new Person { Id = 4, Login = "Светик", Password = "785963", PasswordConfirm = "785963", Email = "shag@gmail.com", FootSize = 42, Growth = 180, Telephone = 0503980468, TermsAccepted = true };

            context.Persons.Add(persone1);
            context.Persons.Add(persone2);
            context.Persons.Add(persone3);
            context.Persons.Add(persone4);

             Firm firm1 = new Firm
             {
                 Id = 1, Name = "Unisport",
                 Addresses = new List<Address>()
                 {
                     new Address { Id = 1,
                     AddressName = "Харьков, ул. Сумская 13",
                     Coordinates = DbGeography.FromText("POINT(49.9957694 36.2324444)", 4326)
                 }
                 },
                 Services = new List<Service> { new Service { Id = 1, ServiceName = "Snowbord" } },
                 UniqueName = "Go_Unisport1", Url = "www.unisport.com.ua" };

            context.Firms.Add(firm1);

            Address adress = new Address
            {
                Id = 1,
                AddressName = "Харьков, ул. Сумская 13",
                Coordinates = DbGeography.FromText("POINT(49.9957694 36.2324444)", 4326),
                Firms = new List<Firm>() { firm1 }
            };

            context.Addresses.Add(adress);

            Service snoubord = new Service { Id = 1, ServiceName = "Snowbord", Firms = new List<Firm>() { firm1 } };

            context.Services.Add(snoubord);
        }
    }
}