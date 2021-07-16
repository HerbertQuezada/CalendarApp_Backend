using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarApp_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        // api/Auth/      Para Loguearse              -POST
        /*
            {
                "name" : "Herbert",
                "email" : "herber-1995@hotmacil.com",
                "password" : "123456789"
            }
        */
        // api/Auth/new   Para registrarse            -POST
        // api/Auth/renew   Para actualizar el token  -GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
