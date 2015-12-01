using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Runtime;
namespace FooBar.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Hello (on " + DateTime.Now + ")";
        }
    }
}
