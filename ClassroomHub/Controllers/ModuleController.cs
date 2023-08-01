using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using System;

namespace ClassroomHub.Web.Controllers
{
    public class ModuleController : Controller
    {
        private  readonly IModuleService _moduleService;
        private readonly ITeacherService _teacherService;
        private readonly IClassService _classService;
        private readonly IMapper _mapper;

        public ModuleController(IModuleService moduleService, IMapper mapper, ITeacherService teacherService, IClassService classService)
        {
            _moduleService = moduleService;
            _teacherService = teacherService;
            _classService = classService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var teachers = _mapper.Map<IEnumerable<TeacherViewModel>>(_teacherService.GetAll());
            var classes = _mapper.Map<IEnumerable<ClassViewModel>>(_classService.GetAll());
            ViewBag.Teachers = new SelectList(teachers, "Id", "Name");
            ViewBag.Classes = new SelectList(classes, "Id", "Name");
            var modules = _moduleService.GetAll();
            var modulesViewModels = _mapper.Map<IEnumerable<ModuleViewModel>>(modules);
            return View(modulesViewModels);
        }

        public IActionResult Create(ModuleViewModel model)
        {
            var module = _mapper.Map<Module>(model);
            _moduleService.Add(module);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(Guid id)
        {
            var module = _mapper.Map<ModuleViewModel>(_moduleService.GetById(id));
            return View(module);
        }
    }
}
