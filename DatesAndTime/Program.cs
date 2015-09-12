using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime myValue = DateTime.Now;

            //  This is the simplest way to show the current date & time
            /*
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            Console.ReadLine();
            */

            //  This shows the date & time in a longer (more user friendly) format
            /*
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToLongDateString());

            Console.ReadLine();
            */

            //  Here we are calculating with the dates by adding 3 more days to the current date
            /*
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.ReadLine();
            */

            //  Here we are calculating with hours by adding 3 more hours to the current time
            /*
            Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
            Console.ReadLine();
            */

            //  Here we are calculating with the dates by substracting 3 days to the current date
            /*
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.ReadLine();
            */

            //  Here we are just showing the current month
            /*
            Console.WriteLine(myValue.Month.ToString());
            Console.ReadLine();
            */

            // Here my total days on this planet are counted

            DateTime myBirthDay = DateTime.Parse("07/15/1976");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
