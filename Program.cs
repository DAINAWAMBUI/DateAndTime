using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
             Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.DayOfWeek.ToString());
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(4).ToShortTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-6).ToShortTimeString());
            Console.WriteLine(myValue.Year.ToString());
            Console.WriteLine(myValue.Month.ToString());
            Console.WriteLine(myValue.Subtract(myValue).ToString());
            Console.ReadLine();


            /*DateTime myBirthday = new DateTime(1999, 04, 18);
            Console.WriteLine(myBirthday.ToShortDateString());
            Console.ReadLine();*/

            DateTime myBirthday = DateTime.Parse("1999/04/18");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();

        }
    }
}

