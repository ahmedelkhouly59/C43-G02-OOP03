using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_2
{
    internal class Hiring_date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Hiring_date(int day_, int month_, int year_)
        {
            if (!ValidDate(day_, month_, year_))
                Console.WriteLine("Invalid date provided.");
            else
            {
                day = day_;
                month = month_;
                year = year_;
            }

        }

        private static bool ValidDate(int day, int month, int year)
        {
            if (year < 1 || month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year, month))
                return false;

            return true;
        }

        public override string ToString()
        {
            return $" Day = {day} \n Month = {month} \n Year = {year}";
        }


    }
}
