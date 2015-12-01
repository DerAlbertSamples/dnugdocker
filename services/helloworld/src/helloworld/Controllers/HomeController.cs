using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using helloworld.Services;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace helloworld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<ServiceOptions> options;
        static HttpClient httpClient = new HttpClient();
        public HomeController(IOptions<ServiceOptions> options) {
            this.options = options;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            var helloTask =  httpClient.GetStringAsync(options.Value.Hello);
            var worldTask =  httpClient.GetStringAsync(options.Value.World);
            Task.WaitAll(helloTask,worldTask);
            ViewData["Message"] = $"Vom Server: {helloTask.Result} {worldTask.Result}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
