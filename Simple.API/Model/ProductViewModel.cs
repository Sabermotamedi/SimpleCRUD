using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.API.Model
{
    public class ProductViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
    }
}
