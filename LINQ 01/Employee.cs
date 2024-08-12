using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_01
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name}, Salary: {Salary}";
        }

    }
}
