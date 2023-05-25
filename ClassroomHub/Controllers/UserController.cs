using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Collections.Generic;
using ClassroomHub.Core.Contracts.Services;

namespace ClassroomHub.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _mapper = mapper;
            userService = _userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(UserViewModel model)
        {
            var user = _mapper.Map<User>(model);
            _userService.Create(user);
            return Ok();
        }

        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            var userViewModel = _mapper.Map<List<User>>(users); 
            return View(userViewModel);

        }
    }
}
