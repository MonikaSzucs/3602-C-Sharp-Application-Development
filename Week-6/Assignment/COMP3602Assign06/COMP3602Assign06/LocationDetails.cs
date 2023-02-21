using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    class LocationDetails : Location
    {
        public LocationDetails(string companyName, string city, string province, string postalCode, string hold)
            :base(companyName, city, province, postalCode, hold)
        { 
        
        }

        public LocationDetails(string companyName, string city, string province, string hold)
            : base(companyName, city, province, hold)
        {

        }
    }
}
