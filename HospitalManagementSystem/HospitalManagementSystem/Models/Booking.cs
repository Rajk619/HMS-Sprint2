using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalManagementSystem.Models
{
    public partial class Booking
    {
        public string BookingId { get; set; }
        public string PatientName { get; set; }
        public int PatientAge { get; set; }
        public string PatientGender { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhoneNo { get; set; }
        public string PatientDisease { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
