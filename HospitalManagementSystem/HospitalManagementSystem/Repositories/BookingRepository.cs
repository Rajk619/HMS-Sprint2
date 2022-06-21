using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories
{
    public class BookingRepository
    {
        private readonly HMS_DBContext context;
        public BookingRepository()
        {
            context = new HMS_DBContext();

        }



        public void AddBooking(Booking booking)
        {
            context.Bookings.Add(booking);
            context.SaveChanges();
        }



        public void EditBookings(Booking booking)
        {
            context.Bookings.Update(booking);
            context.SaveChanges();
        }





        public List<Booking> GetAllBookings()
        {
            return context.Bookings.ToList();

        }




        public Booking GetBookings(string id)
        {
            Booking bookings = context.Bookings.Find(id);
            return bookings;
        }




        public void DeleteBookings(string id)
        {
            Booking bookings = context.Bookings.Find(id);
            context.Bookings.Remove(bookings);
            context.SaveChanges();
        }
    }
}
