using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace LinkGenTest {

    public class HomeController : Controller {
        

        [HttpGet]
        public IActionResult Index() => View("~/Home.cshtml");

        [HttpGet]
        public IActionResult About() => View("~/About.cshtml");

    }
}
