using aaaa.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace aaaa.Controllers
{
    [EnableCors("AllowOrigin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {

            return "Hello!";
        }


        [HttpGet]
        public Dictionary<string,dynamic> Hey( )
        {

            Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
            map["status"] = "Hello!,  ,You are Years old.";
            map["nested"] = new Dictionary<string, dynamic>();
            map["nested"]["A"] = new int[]{ 1,2,3};
            map["nested"]["B"] = new string[] {"Anop", "asus" };
            map["nested"]["C"] = new Dictionary<string, dynamic>();
            map["nested"]["C"]["YO"] = "AHHAHAHAHA";
            return map;
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
