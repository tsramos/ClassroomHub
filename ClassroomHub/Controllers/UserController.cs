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
            _userService = userService;
        }
        public IActionResult Index()
        {
            User user = new User()
            {
                Email = "thiago.ramos@gmail.com", 
                Password = "password",                
            };
            _userService.Create(user);

            return View();
        }

        public IActionResult Create(UserViewModel model)
        {
            var user = _mapper.Map<User>(model);
            
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
