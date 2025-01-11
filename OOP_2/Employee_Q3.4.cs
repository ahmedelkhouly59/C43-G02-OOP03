using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_2
{
    enum Positions
    {
        DBA,
        Guest,
        Security_Officer
    }
    internal class Employee_Q3
    {
        public string Name { get; set; }
        public Positions Position { get; set; }
        public DateTime HireDate { get; set; }
        public string Permission { get; set; }

        public Employee_Q3(string name, Positions position, DateTime hireDate, string perm_)
        {
            Name = name;
            Position = position;
            HireDate = hireDate;
            Permission = perm_;
        }

        public override string ToString()
        {
            return $"NAME = {Name} \n Position = {Position} \n HireDate = {HireDate} \n Permission = {Permission}";
        }
    }
}
