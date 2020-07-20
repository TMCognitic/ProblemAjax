using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        public IActionResult GetArtistsCard([FromBody] Artist[] artists)
        {
            return PartialView();
        }
    }
}
