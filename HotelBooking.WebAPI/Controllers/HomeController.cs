using HotelBooking.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelBooking.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new HotelBookingContext())
            {
                var hotel = new Hotel() { Name = "Bill Bill" };

                ctx.Hotels.Add(hotel);
                ctx.SaveChanges();
            }
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
