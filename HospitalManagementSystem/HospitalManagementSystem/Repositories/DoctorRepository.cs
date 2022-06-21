using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories
{
    public class DoctorRepository
    {
        private readonly HMS_DBContext context;

        public DoctorRepository()
        {
            context = new HMS_DBContext();

        }



        public void AddDoctor(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            context.SaveChanges();

        }





        public List<Doctor> GetDoctors()
        {
            return context.Doctors.ToList();

        }





        public Doctor GetDoctorById(string id)
        {
            Doctor doctors = context.Doctors.Find(id);
            return doctors;

        }





        public void EditDoctors(Doctor doctor)
        {
            context.Doctors.Update(doctor);
            context.SaveChanges();
        }






        public void DeleteDoctors(string id)
        {
            Doctor doctors = context.Doctors.Find(id);
            context.Doctors.Remove(doctors);
            context.SaveChanges();
        }





        public Doctor GetPatientDetalisByDoctorsName(string doctorName) //get Doctor details using doctor name

        {
            Doctor doctor = context.Doctors.SingleOrDefault(s => s.DoctorName == doctorName);
            return doctor;
        }
    }
}
