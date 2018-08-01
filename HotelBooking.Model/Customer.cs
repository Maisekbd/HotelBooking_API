using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Model
{
    public class Customer : Entity
    {
        //public int ID { get; set; }

        public string Name { get; set; }

        public string PhoneNo { get; set; }

        public IList<HotelReservation> HotelReservations { get; set; }

        public Customer()
        {
            HotelReservations = new List<HotelReservation>();
        }
    }
}
