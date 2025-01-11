using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_2 {
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        public int id { get; set; }
        public string? name { get; set; }
        public SecurityLevel sclvl { get; set; }
        private double salary { get; set; }
        public string hiredate;
        private char gender;

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Wrong gender input");
            }
        }

        public Employee(int id_, string? name_, SecurityLevel sclvl_, double salary_, string hireDate_, char gender_)
        {
            id = id_;
            name = name_ ;
            sclvl = sclvl_;
            salary = salary_;
            hiredate = ValidateDate(hireDate_);
            Gender = gender_;
        }

        private string ValidateDate(string date)
        {
            if (DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return date;
            }
            else
            {
                Console.WriteLine("Date must be in format YYYY-MM-DD");
                return "0";
            }

        }



        public override string ToString()
        {
            return $" ID = {id} \n NAME = {name} \n Securtity Level = {sclvl} \n Salary = {salary:c} \n HireDate = {hiredate} \n Gender = {gender}";
        }
    } 
}
 
