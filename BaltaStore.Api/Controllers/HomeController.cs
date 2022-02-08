using Microsoft.AspNetCore.Mvc;
using System;

namespace BaltaStore.Api.Controllers
{    
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public object Get()
        {
            return new { version = "Version 0.0.1" };
        }

        [HttpGet]
        [Route("home")]
        public string Home() => "Welcome";

        [HttpGet]
        [Route("error")]
        public string Error()
        {
            //throw new Exception("Algum erro ocorreu");
            return "erro";
        }
    }
}
