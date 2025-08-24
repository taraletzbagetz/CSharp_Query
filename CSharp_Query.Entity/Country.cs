using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Query.Entity
{
    public class Country
    {
        public Country(String country, String ISOCode, string validCode = "")
        {
            this.Name = country;
            this.Code = ISOCode;
            this.ValidCode = validCode;

        }

        public String Code { get; set; }
        public String Name { get; set; }
        public String ValidCode { get; set; }
    }
}
