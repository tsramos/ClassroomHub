using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClassroomHub.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<StudentViewModel> studentViewModels = new List<StudentViewModel>()
        {
            new StudentViewModel()
            {
                Name = "João", 
                Surname ="Emanuel", 
                Email = "jaozindolol@gamail.com"
            }, 
            new StudentViewModel()
            {
                Name = "Danilo", 
                Surname = "Alves", 
                Email = "danilinreidossd@gmail.com"
            }
        };
        public IActionResult Index()
        {
            return View(studentViewModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            studentViewModels.Add(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id) {
            //GUID uuid
            //87932D11-AF2A-4D23-8F8A-6CD7BF33DF61
            return Ok();
        }
    }
}
