using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories;

namespace HospitalManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingRepository BookingRepository;
        public BookingController()
        {
            BookingRepository = new BookingRepository();
        }



        [HttpPost, Route("AddBooking")] //create or book an appointment

        public IActionResult Add(Booking booking)
        {
            BookingRepository.AddBooking(booking);
            return StatusCode(200, "Patient Added");
        }



        [HttpPut, Route("EditBooking")]//update the bookings details

        public IActionResult Edit(Booking booking)
        {
            BookingRepository.EditBookings(booking);
            return StatusCode(200, "Record Edited");

        }




        [HttpGet]
        // Route("GetAllBookings")

        public IActionResult Get()
        {
            return StatusCode(200, BookingRepository.GetAllBookings());

        }





        [HttpGet, Route("GetBookingById/{id}")]
        public IActionResult Get(string id)
        {
            return StatusCode(200, BookingRepository.GetBookings(id));

        }

        [HttpDelete, Route("DeleteBookings/{id}")]

        public IActionResult Delete(string id)
        {
            BookingRepository.DeleteBookings(id);
            return StatusCode(200);

        }

    }
}
