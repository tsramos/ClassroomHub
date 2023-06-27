using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClassroomHub.Web.ViewModels;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        private readonly IMapper _mapper;

        public ClassController(IClassService classService, IMapper mapper)
        {
            _classService = classService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var classes = _classService.GetAll();
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
