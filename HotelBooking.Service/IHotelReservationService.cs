using HotelBooking.Model;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Service
{
    public interface IHotelReservationService : IService<HotelReservation>
    {
        int InsertHotelReservation(HotelReservation hotel);
        void UpdateHotelReservation(HotelReservation hotel);
        void Delete(int id);
        Hotel GetById(int id);
        IQueryable<HotelReservation> GetAll();
    }
}
