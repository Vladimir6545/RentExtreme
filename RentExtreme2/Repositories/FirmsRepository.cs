using RentExtreme2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentExtreme2.Repositories
{
    public class FirmsRepository
    {
        public IEnumerable<string> GetNames(int? id = null)
        {
            using (var db = ApplicationDbContext.Create())
                return db.Database
                    .SqlQuery<string>("SELECT [Name] FROM [dbo].[Firms] WHERE [Id]="+" " + id)
                    .ToList();
        }
    }
}