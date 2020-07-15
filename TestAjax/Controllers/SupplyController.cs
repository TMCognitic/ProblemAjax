using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TestAjax.Models;

namespace TestAjax.Controllers
{
    public class SupplyController : Controller
    {
        [HttpPost]
        public IActionResult GetArtistsCard(Artist[] artists)
        {            
            return PartialView();
        }
    }
}
