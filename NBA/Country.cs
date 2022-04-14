using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    internal class Country
    {
        string countryCode;
        string countryName;
        public void set(string countryName, string countryCode)
            { 
            this.countryName = countryName; 
            this.countryCode = countryCode; 
        }
    }
}
