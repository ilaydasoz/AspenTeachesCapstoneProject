using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var values = _appUserService.TGetByID(id);
            return Ok(values);
        }
    }
}
