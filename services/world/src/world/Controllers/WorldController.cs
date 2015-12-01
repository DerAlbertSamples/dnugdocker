using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FooBar.Controllers
{
    [Route("api/[controller]")]
    public class WorldController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "World";
        }

    }
}
