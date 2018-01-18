using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Models
{
    public class CompanyInfo
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }   
        public string Mission { get; set; }

        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public int Phone { get; set; }
    }
}
