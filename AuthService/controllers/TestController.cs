using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelClassLibrary.area.user;

namespace AuthService.controllers
{
    [Route("api/auth")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpPost("abc")]
        public dynamic login([FromBody]Users user)
        {
            return "sdfasdf";
        }
    }
}