using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStringFormatting
{
    // use types and status's
    // behind this is 0,1,2 etc 0 = Administrator, 1 = PowerUser etc
    enum UserType
    {
        Administrator,
        PowerUser,
        User
    }

    class SystemUser
    {
        public string Name { get; }
        public double AverageLoginsPerWeek { get; }
        public UserType Type { get; }

        public SystemUser(string name, double averageLoginsPerWeek, UserType type)
        {
            Name = name;
            AverageLoginsPerWeek = averageLoginsPerWeek;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name}, {AverageLoginsPerWeek}, {Type}";
        }
    }
}
