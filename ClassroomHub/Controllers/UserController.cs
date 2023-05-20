using ClassroomHub.Core.Contracts;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

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
    }
}
