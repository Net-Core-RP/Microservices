using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBookingNumber(int bookingNumber)
        {
            return new ReservationDTO
            {
                BookingNumber = bookingNumber,
                Amount = new Random().Next(1, 1000),
                CheckInDate = DateTime.Now.AddDays(-3),
                CheckOutDate = DateTime.Now.AddDays(30),
                BookingDate = DateTime.Now,
                Id = new Random().Next(1, 100),
            };
        }
    }
}
