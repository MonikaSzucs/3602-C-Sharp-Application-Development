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
    }
}
