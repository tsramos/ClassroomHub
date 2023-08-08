using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
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
        private readonly IDeliveryService _deliveryService;
        private readonly IMapper _mapper;

        public ActivityController(
            IActivityService activityService,
            ITeacherService teacherService,
            IStudentService studentService,
            IModuleService moduleService,
            IDeliveryService deliveryService,
            IMapper mapper)
        {
            _activityService = activityService;
            _teacherService = teacherService;
            _studentService = studentService;
            _moduleService = moduleService;
            _deliveryService = deliveryService;
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

        public IActionResult TeacherArea(Guid teacherId)
        {
            var modules = _moduleService.GetModulesByTeacherId(teacherId);
            var activities = _mapper.Map<List<ActivityViewModel>>( _activityService.GetAllWithModules(teacherId));            
            ViewBag.Modules = new SelectList(modules,"Id","Nome");            
            return View(activities);
        }

        public IActionResult Create(ActivityViewModel activityViewModel)
        {
            _activityService.Add(_mapper.Map<Activity>(activityViewModel));
            return RedirectToAction("TeacherArea");
        }
        
        public IActionResult GetDeliveries(Guid teacherId)
        {
            var deliveries = _moduleService.GetDeliveredActivitiesByTeacherId(teacherId);
            var deliveryViewModel = _mapper.Map<IEnumerable<DeliveryToTeacherViewModel>>(deliveries);
            return View(deliveryViewModel);
        }

        public IActionResult UpdateDelivery(DeliveryViewModel deliveryViewModel)
        {
            return RedirectToAction(nameof(GetDeliveries), new { deliveryViewModel });
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

        public IActionResult DeliveryActivity(ActivityDeltailsViewModel activityDetails)
        {
            var delivery = _mapper.Map<Delivery>(activityDetails);
            _deliveryService.Add(delivery);
            return RedirectToAction(nameof(StudentArea), new { activityDetails.StudentId });
        }

    }
}
