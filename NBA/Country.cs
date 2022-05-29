using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    internal class Country
    {
        String countryCode;
        String countryName;
        public void set(String countryName, String countryCode)
            { 
            this.countryName = countryName; 
            this.countryCode = countryCode; 
        }
    }
}
