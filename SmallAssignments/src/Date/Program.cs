//Given a date string ("dd-mm-yyyy")
//add 20 days to it
//and print it in yyyy-mm-dd format
//along with its day (Monday, Tuesday, ...)

using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year in the format dd-mm-yyyy");
            try
            {
                var dateString = Console.ReadLine()?.Split('-');
                //By default it is trying to read the string in mm-dd-yyyy format
                var convertedCorrectDateString = $"{dateString[1]}-{dateString[0]}-{dateString[2]}";
                var date = Convert.ToDateTime(convertedCorrectDateString);
                PrintTheDateInPredefinedFormat(date);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Invalid date format");
                Console.ReadKey();
            }
        }


        /// <summary>
        /// Adds the specified number of days into date and print along with day
        /// </summary>
        /// <param name="date"></param>
        /// <param name="days">no. of days to be added</param>
        private static void PrintTheDateInPredefinedFormat(DateTime date, int days = 20)
        {
            var newDate = date.AddDays(days);
            Console.WriteLine();
            Console.WriteLine("Date after adding {0} days", days);
            Console.WriteLine(newDate.ToString("yyyy-mm-dd") + " " + newDate.DayOfWeek);
        }
    }
}
