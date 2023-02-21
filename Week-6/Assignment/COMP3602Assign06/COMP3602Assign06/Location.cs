﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    public abstract class Location: IComparable<Location>
    {
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCost { get; set; }
        public string Hold { get; set; }

        public Location(string companyName, string city, string province, string postalCost, string hold)
        {
            CompanyName = companyName;
            City = city;
            Province = province;
            PostalCost = postalCost;
            Hold = hold;
        }

        protected Location(string companyName, string city, string province, string hold)
        {
            CompanyName = companyName;
            City = city;
            Province = province;
            Hold = hold;
        }

        public int CompareTo(Location other)
        {
            return this.Hold.CompareTo(other.Hold);
        }
    }
}
