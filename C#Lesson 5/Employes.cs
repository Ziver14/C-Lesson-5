using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson_5
{
    public class Employee
    {
        public string Name {  get; set; }
        public DateTime dateOfBirth {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public string Position {  get; set; }
        public decimal Salary {  get; set; }

        public Employee(string name, DateTime dateOfBirth, string phone, string email, string position, decimal salary)
        {
            Name = name;
            this.dateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Position = position;
            Salary = salary;
        }
        public static decimal operator +(Employee a,decimal salary) { return a.Salary + salary; }
        public static decimal operator -(Employee a, decimal salary) { return a.Salary - salary; }
        public static bool operator ==(Employee a, Employee b) { return a.Salary == b.Salary; }
        public static bool operator > (Employee a, Employee b) 
        { 
            if(a.Salary > b.Salary) return false;
            else return true;
        }
        public static bool operator < (Employee a, Employee b) {
            if (a.Salary < b.Salary) return false;
            else return true;
        }
        public static bool operator !=(Employee a, Employee b) { return a.Salary != b.Salary; }
        public override bool Equals(object? obj)
        {
            if(obj is Employee other)
            {
                return this.Salary==other.Salary;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name:{Name}\n DateOfBrith:{dateOfBirth}\n Phone:{Phone}\n Email:{Email}\n Position:{Position}\n Salary:{Salary}";
        }
    }
}
