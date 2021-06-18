using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public abstract class Person
    {
        internal string firstName = string.Empty;
        internal string lastName = string.Empty;
        internal string email = string.Empty;
        internal string phone = string.Empty;
        internal DateTime dateOfBirth;

        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string Email { get; set; }
        public abstract string Phone { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract string GetFullName();
        public abstract string GetAge();

    }

}
