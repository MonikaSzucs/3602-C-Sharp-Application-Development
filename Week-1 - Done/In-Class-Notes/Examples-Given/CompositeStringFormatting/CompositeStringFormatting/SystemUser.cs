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
        private string name;
        private double averageLoginsPerWeek;
        private UserType type;

        public SystemUser(string name, double averageLoginsPerWeek, UserType type)
        {
            this.name = name;
            this.averageLoginsPerWeek = averageLoginsPerWeek;
            this.type = type;
        }

        public string Name
        {
            get { return name; }
        }

        public double AverageLoginsPerWeek
        {
            get { return averageLoginsPerWeek; }
        }

        public UserType Type
        {
            get { return type; }
        }
    }
}
