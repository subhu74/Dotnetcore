using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GITWEBFIRST.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Method data type is string and return type should be string";
        }
    }
}
