using System;
using System.Collections.Generic;

#nullable disable

namespace HospitalManagementSystem.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Bookings = new HashSet<Booking>();
        }

        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorDept { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
