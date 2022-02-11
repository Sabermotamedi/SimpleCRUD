using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.API.Entity
{
    public class Product : EntityBase
    {      
        public string Name { get; set; }
        public int Count { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
    }
}
