using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBooking.Model;
using Service.Pattern;

namespace HotelBooking.Service
{
    public interface IHotelService : IService<Hotel>
    {
        int InsertHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void Delete(int id);
        Hotel GetById(int id);
        IQueryable<Hotel> GetAll();
    }
}
