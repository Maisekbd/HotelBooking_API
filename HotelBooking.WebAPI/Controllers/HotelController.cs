using HotelBooking.Model;
using HotelBooking.Service;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HotelBooking.WebAPI.Controllers
{
    public class HotelController : ApiController
    {
        //private HotelBookingContext db = new HotelBookingContext();
        private readonly IHotelService _hotelService;
        //private readonly IUnitOfWork _unitOfWork;

        public HotelController(
            IHotelService hotelService
           /* IUnitOfWork unitOfWork*/)
        {
            _hotelService = hotelService;
            //_unitOfWork = unitOfWork;
        }

        public HotelController()
        {

        }

        // GET: api/Hotels  
        public IQueryable<Hotel> GetHotels()
        {
            return _hotelService.Queryable();
        }


        public Hotel GetHotel(int hotelId)
        {
            return _hotelService.Queryable().Where(c=>c.Id == hotelId).FirstOrDefault();
        }



        // PUT: api/Employees/5  

        public IHttpActionResult PutHotel(Hotel hotel)
        {
            ModelState["hotel.CreatedBy"].Errors.Clear();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            //db.Entry(hotel).State = EntityState.Modified;

            try
            {
                _hotelService.UpdateHotel(hotel);
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees  
        //[System.Web.Http.HttpPost]
        public IHttpActionResult PostHotel(Hotel hotel)
        {
            hotel.CreatedBy = Convert.ToString("0");
            hotel.CreationDate = DateTime.Now;
            ModelState["hotel.CreatedBy"].Errors.Clear();
            if (ModelState.IsValid)
            {
                //db.Hotels.Add(hotel);
                //db.SaveChanges();
                _hotelService.InsertHotel(hotel);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, hotel);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = hotel.Id }));
                return CreatedAtRoute("DefaultApi", new { id = hotel.Id }, hotel);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        // DELETE: api/Employees/5  

        public IHttpActionResult DeleteHotel(int hotelId)
        {
            //Hotel remove_hotel = db.Hotels.Find(hotelId);
            Hotel remove_hotel = _hotelService.Queryable().Where(c=>c.Id == hotelId).FirstOrDefault();
            //bool remove_hotel_result =
                _hotelService.Delete(remove_hotel.Id);

            if (remove_hotel == null)
            {
                return NotFound();
            }

            //db.Hotels.Remove(remove_hotel);
            //try
            //{
            //   // db.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    return BadRequest(ex.Message);
            //}

            return Ok(remove_hotel);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}


    }
}