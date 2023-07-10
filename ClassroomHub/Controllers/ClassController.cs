using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClassroomHub.Web.ViewModels;
using ClassroomHub.Core.Entities;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClassroomHub.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public ClassController(IClassService classService, IMapper mapper, ICourseService courseService)
        {
            _classService = classService;
            _mapper = mapper;
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");        
            return View(new List<ClassViewModel>());
        }

        [HttpPost]
        public IActionResult Index(Guid id)
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            var classes = _classService.GetAllByCourseId(id);
            var classesViewModel = _mapper.Map<IEnumerable<ClassViewModel>>(classes);
            return View(classesViewModel);
        }

        public IActionResult Create(ClassViewModel model)
        {            
            var classEntity = _mapper.Map<Class>(model);
            _classService.Add(classEntity);
            return RedirectToAction(nameof(Index));
        }
    }
}
