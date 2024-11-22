using E_commerce.Data;
using E_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            // If you're using a database, this is where you'd fetch doctors from ApplicationDbContext.
            var doctors = new List<Doctor>
            {
                new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
                new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
                new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" }
            };

            return View(doctors); // Pass the list of doctors to the view
        }

        public IActionResult Appointment(int doctorId)
        {
            // Here you can fetch the doctor by ID, assuming you're using the list or a database.
            var doctors = new List<Doctor>
            {
                new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
                new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
                new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" }
            };

            var doctor = doctors.FirstOrDefault(d => d.Id == doctorId);
            if (doctor == null)
            {
                return NotFound(); // If the doctor is not found
            }

            return View(doctor); // Pass the selected doctor to the Appointment view
        }
    }
}
