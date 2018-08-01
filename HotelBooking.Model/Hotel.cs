using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Model
{
    public class Hotel : Entity
    {
        //public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int RoomsNo { get; set; }

        public bool hasAvailableRoom { get; set; }

        public IList<HotelReservation> HotelReservations { get; set; }

        public Hotel()
        {
            HotelReservations = new List<HotelReservation>();
        }
    }
}
