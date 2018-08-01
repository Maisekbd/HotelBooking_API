using HotelBooking.Model;
using HotelBooking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HotelBooking.WebAPI.Controllers
{
    public class StatisticsController : ApiController
    {
        private readonly IHotelService _hotelService;
        private readonly IHotelReservationService _hotelReservationService;

        public StatisticsController(
            IHotelService hotelService,
            IHotelReservationService hotelReservationService
          )
        {
            _hotelService = hotelService;
            _hotelReservationService = hotelReservationService;
        }

        public StatisticsController()
        {

        }

        [System.Web.Http.Route("api/Statistics/GetHotelsCount")]
        [System.Web.Http.HttpGet]
        public int GetHotelsCount()
        {
            return _hotelService.Queryable().Count();
        }

        [System.Web.Http.Route("api/Statistics/GetHotelReservationsCount")]
        [System.Web.Http.HttpGet]
        public int GetHotelReservationsCount()
        {
            return _hotelReservationService.Queryable().Count();
        }

    }
}