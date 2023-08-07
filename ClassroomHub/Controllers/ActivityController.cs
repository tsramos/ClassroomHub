using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels.ActivityViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly IModuleService _moduleService;
        private readonly IMapper _mapper;

        public ActivityController(
            IActivityService activityService,
            ITeacherService teacherService,
            IStudentService studentService,
            IModuleService moduleService,
            IMapper mapper)
        {
            _activityService = activityService;
            _teacherService = teacherService;
            _studentService = studentService;
            _moduleService = moduleService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var teachers = _teacherService.GetAll();
            var students = _studentService.GetAll();
            ViewBag.Students = new SelectList(students, "Id", "Name");
            ViewBag.Teachers = new SelectList(teachers, "Id", "Name");
            return View(new ActivityIndexModel());
        }

        public IActionResult TeacherArea(Guid TeacherId)
        {
            var modules = _moduleService.GetModulesByTeacherId(TeacherId);
            var activities = _mapper.Map<List<ActivityViewModel>>( _activityService.GetAllWithModules());            
            ViewBag.Modules = new SelectList(modules,"Id","Nome");            
            return View(activities);
        }

        public IActionResult Create(ActivityViewModel activityViewModel)
        {
            _activityService.Add(_mapper.Map<Activity>(activityViewModel));
            return RedirectToAction("TeacherArea");
        }
        
        public IActionResult StudentArea(Guid studentId)
        {
            var student = _studentService.GetFullObjectById(studentId);
            var studentAreaViewModel = _mapper.Map<IEnumerable<StudentAreaViewModel>>(student.Class.Modules);
            foreach (var item in studentAreaViewModel)
            {
                item.StudentId = studentId;
            }

            return View(studentAreaViewModel);
        }

        public IActionResult Details(Guid studentId, Guid ActivityId)
        {            
            var activity = _activityService.GetById(ActivityId);            
            var activityViewModel = _mapper.Map<ActivityDeltailsViewModel>(activity);
            activityViewModel.StudentId = studentId;
            return View(activityViewModel);
        }

    }
}
