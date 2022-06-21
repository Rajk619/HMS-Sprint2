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
    public class DoctorController : ControllerBase
    {
        private DoctorRepository DoctorRepository;
        public DoctorController()
        {
            DoctorRepository = new DoctorRepository();
        }



        [HttpGet, Route("GetAllDoctor")]
        public IActionResult Getall()
        {
            return StatusCode(200, DoctorRepository.GetDoctors());
        }







        [HttpPost, Route("AddDoctor")]
        public IActionResult Add(Doctor doctor)
        {
            DoctorRepository.AddDoctor(doctor);
            return StatusCode(200, "Doctor Added");
        }







        [HttpPut, Route("EditDoctor")]
        public IActionResult Edit(Doctor doctor)
        {
            DoctorRepository.EditDoctors(doctor);
            return StatusCode(200, "Data Edited");
        }








        [HttpDelete, Route("DeleteDoctor/{id}")]
        public IActionResult Delete(string id)
        {
            DoctorRepository.DeleteDoctors(id);
            return StatusCode(200);
        }




        [HttpGet, Route("GetDoctorById/{id}")]
        public IActionResult Get(string id)
        {
            return StatusCode(200, DoctorRepository.GetDoctorById(id));

        }
    }
}
