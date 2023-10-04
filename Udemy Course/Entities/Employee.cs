using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Udemy_Course.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1]);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (obj is not Employee)
            {
                throw new ArgumentException("Argument is not an Employee");
            }

            Employee other = obj as Employee;

            return Name.CompareTo(other.Name);
        }
    }
}
