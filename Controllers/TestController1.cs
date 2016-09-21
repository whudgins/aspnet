using System;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers {
    public class TestTwoController : Controller {
        [HttpGet]
        public string Test() {
            return "This is a test method";
        }

        [HttpGet]
        public string Index() {
            return "This is a test index method -- BOOM 2";
        }

        [HttpGet]
        public string Index2() {
            return "new method";
        }

        [HttpGet]
        public string Index3() {
            //Console.WriteLine("Something");

            return "REALLY new method in new controller";
        }
    }
} 