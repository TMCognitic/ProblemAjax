using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAjax.Models
{
    public class JsonArtists
    {
        public DateTime Created { get; set; }
        public int Count { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
