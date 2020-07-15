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
            //string bodyStr = "";
            
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8, true, 1024, true))
            //{
            //    bodyStr = reader.ReadToEndAsync().Result;
            //}

            //Artist[] artists = JsonConvert.DeserializeObject<Artist[]>(bodyStr);

            return PartialView();
        }
    }
}
