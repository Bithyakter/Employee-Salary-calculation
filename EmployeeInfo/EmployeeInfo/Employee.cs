using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public sealed class Employee:Person, IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override string Email { get => email; set => email = value; }
        public override string Phone {get => phone; set => phone = value; }
        public override DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime JoiningDateTime { get; set; }
        public string Designation { get; set; }

        public Employee(string id, string firstName, string lastName, string email, string phone, DateTime DOB, DateTime joiningDateTime, int designation)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = DOB;
            this.JoiningDateTime = joiningDateTime;
            this.Designation = Enum.GetName(typeof(Designation), designation);
        }

        public override string GetFullName()
        {
            return firstName + "   " + lastName;
        }

        /*----------Calculate Over time---------*/
        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - dateOfBirth;
            int years = age.Days / 365;
            int months = (age.Days - years * 365) / 30;
            int days = (age.Days - years * 365 - months * 30);

            return years.ToString() + "Years" + months.ToString() + " Months " +
             days.ToString() + " Days";
        }

        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }
    }
}
