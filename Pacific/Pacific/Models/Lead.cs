using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Models
{
    public class Lead
    {
        public int ID { get; set; }
        
        public string Name { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string Comment { get; set; }
    }
}
