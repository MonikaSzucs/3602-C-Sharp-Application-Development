using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStringFormatting
{
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
