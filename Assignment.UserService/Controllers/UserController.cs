using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.UserService.IService;
using Assignment.UserService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.UserService.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IFetchUserService _fetchUserService;

        public UserController(IFetchUserService fetchUserService)
        {
            _fetchUserService = fetchUserService;
        }

        [HttpGet("{id}")]
        public ActionResult<UserDto> Get(int id)
        {
            var result = new UserDto();
            var fetchedUser = _fetchUserService.GetUser();
            if (fetchedUser != null)
            {
                result.Name = fetchedUser.Name;
                result.Age = fetchedUser.Age.GetValueOrDefault();
                result.Email = fetchedUser.Email;
            }
            return result;
        }
    }
}