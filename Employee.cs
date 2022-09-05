using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    internal class Employee : Person, IRole
    {
        private object designation;
        private DateTime dateOfBarth;
        private int deg;

        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override string Phone { get => phone; set => phone = value; }
        public override DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        internal override string Email { get => email; set => email = value; }

        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - dateOfBirth;
            int years = age.Days / 365;
            int months = (age.Days - years * 365) / 30;
            int days = (age.Days - years * 365) / 30;
            throw new NotImplementedException();
            return years.ToString() + "Years" + months.ToString() + "Months" + days.ToString() + "Days";
        }

        public override string GetFullName()
        {
            return firstName + " " + lastName;
            throw new NotImplementedException();
        }

        public string[] GetRole(string role)
        {
            throw new NotImplementedException();
            string[] roles = role.Split(',');
            return roles;
        }

        public DateTime JoiningDateTime { get; set; }
        public string Designation { get; set; }

        public Employee(string iD, string firstName, string lastName, string phone, DateTime dateOfBirth, string email, DateTime joiningDateTime, string designationring)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            Email = email;
            JoiningDateTime = joiningDateTime;
            Designation = Enum.GetName(typeof(Designation), designation);
        }

        public Employee(string? id, string? firstName, string? lastName, string? email, string? phone, DateTime dateOfBarth, DateTime joiningDateTime, int deg)
        {
            ID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.dateOfBarth = dateOfBarth;
            JoiningDateTime = joiningDateTime;
            this.deg = deg;
        }
    }
}
