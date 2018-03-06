using RentExtreme2.Helpers;
using RentExtreme2.Models;
using RentExtreme2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentExtreme2.Controllers
{
    public class CoordinatesController : Controller
    {
        private FirmsRepository _firmsRepo;
        public CoordinatesController()
        {
            _firmsRepo = new FirmsRepository();
        }

        // GET: Coordinates
        public ActionResult Index(int? id = null)
        {
            //1 - DataAccessLayer - Repository, DbContext - Cache, DB
            //2 - BusinessLayer - Managers, Services - Try-catch (own)
            //3 - API OR MVC - Controllers - public try-catch (public == error responses)

            var rezult = new
             {
                Name = _firmsRepo.GetNames(id)
              //  Addresses = _firmAddressesRepo.GetAddresses()
            };

            return View(rezult.Name);
        }
        public ActionResult GoogleMapsCoordinates()
        {
            return View();
        }
        public ActionResult DetermineMyCoordinates()
        {
            return View();
        }

        //Не реализовано
        //public ActionResult AddressCoordinates()
        //{
        //    return View();
        //}
    }
}