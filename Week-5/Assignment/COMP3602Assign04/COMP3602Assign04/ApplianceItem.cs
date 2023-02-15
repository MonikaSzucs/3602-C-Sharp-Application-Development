// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ApplianceItem : Item
    {
        public enum ApplianceTypeEnum
        {
            Washer,
            Dryer,
            Dishwasher,
            Oven,
            Range,
            Refrigerator
        }

        public ApplianceTypeEnum ApplianceType { get; }

        public ApplianceItem(string description, float price, string sku, ApplianceTypeEnum applianceType)
            : base(description, price, sku)
        {
            ApplianceType = applianceType;
        }

        public override string[] toString()
        {
            // output -> desc, price, expiry date
            string[] data = new string[4];

            data[0] = this.Description;
            data[1] = this.Price.ToString();
            data[2] = "";
            data[3] = "<N/A>";

            return data;
        }
    }
}

/*class Student {
    public enum Gender {
        Male,
        Female
    }
    public studentName;
    public studentID;


}*/

// Gender.Female

/**

        C#
        |
      Student
     /  |  \
Gender Name ID
 | |
 M F
*/

//