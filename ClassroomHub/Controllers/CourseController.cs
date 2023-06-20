using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var entityCourses = _courseService.GetAll().ToList();
            var courses = _mapper.Map<List<CourseViewModel>>(entityCourses);
            return View(courses);
        }

        public IActionResult Create(CourseViewModel model)
        {
            _courseService.Add(_mapper.Map<Course>(model));
            return RedirectToAction(nameof(Index));
        }
    }
}
