using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestApI.Models
{
    public class Cars
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }
        public int Price { get; set; }
        public string ProductionYear { get; set; }
    }
}
