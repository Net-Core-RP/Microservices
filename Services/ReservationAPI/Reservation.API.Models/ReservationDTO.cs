using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BookingNumber { get; set; }
        public float Amount {  get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? BookingDate{ get; set; }
    }
}
