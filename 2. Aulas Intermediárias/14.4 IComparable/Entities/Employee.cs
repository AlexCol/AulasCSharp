using System;
using System.Globalization;
namespace Course
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            string firstField = vect[0];

            if (firstField[0] >= '0' && firstField[0] <= '9')
            {
                Name = vect[1];
                Salary = double.Parse(vect[0], CultureInfo.InvariantCulture);
            }
            else
            {
                Name = vect[0];
                Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
            }
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}