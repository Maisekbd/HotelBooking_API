using HotelBooking.Model;
using HotelBooking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HotelBooking.WebAPI.Controllers
{
    public class HotelReservationController : ApiController
    {
        //private HotelBookingContext db = new HotelBookingContext();
        private readonly IHotelReservationService _hotelReservationService;
        //private readonly IUnitOfWork _unitOfWork;

        public HotelReservationController(
            IHotelReservationService hotelReservationService
           /* IUnitOfWork unitOfWork*/)
        {
            _hotelReservationService = hotelReservationService;
            //_unitOfWork = unitOfWork;
        }

        public HotelReservationController()
        {

        }

        // GET: api/Hotels  
        public IQueryable<HotelReservation> GetHotelReservations()
        {
            return _hotelReservationService.Queryable();
        }



        // PUT: api/Employees/5  

        public IHttpActionResult PutHotelReservation(HotelReservation hotelReservation)
        {
            //ModelState["hotelReservation.CreatedBy"].Errors.Clear();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _hotelReservationService.UpdateHotelReservation(hotelReservation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees  

        public IHttpActionResult PostHotelReservation(HotelReservation hotelReservation)
        {
            hotelReservation.CreatedBy = Convert.ToString("0");
            hotelReservation.CreationDate = DateTime.Now;
            //ModelState["hotelReservation.CreatedBy"].Errors.Clear();
            if (ModelState.IsValid)
            {
                //db.Hotels.Add(hotel);
                //db.SaveChanges();
                _hotelReservationService.InsertHotelReservation(hotelReservation);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, hotelReservation);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = hotelReservation.Id }));
                return CreatedAtRoute("DefaultApi", new { id = hotelReservation.Id }, hotelReservation);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        // DELETE: api/Employees/5  

        public IHttpActionResult DeleteHotelReservation(int hotelReservationId)
        {
            //Hotel remove_hotel = db.Hotels.Find(hotelId);
            HotelReservation remove_hotel = _hotelReservationService.Queryable().Where(c => c.Id == hotelReservationId).FirstOrDefault();
            //bool remove_hotel_result =
            _hotelReservationService.Delete(remove_hotel.Id);

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