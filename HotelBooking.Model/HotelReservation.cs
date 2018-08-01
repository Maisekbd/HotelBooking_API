using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Model
{
    public class HotelReservation : Entity
    {
        //public int Id { get; set; }

        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNo { get; set; }

        //[ForeignKey("Customer")]
        //public int CustomerId { get; set; }

        //public Customer Customer { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
