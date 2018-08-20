using System;

namespace CG_6_4_Date_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have the user type in the two dates and store them in variables called firstDate and secondDate
            //I couldn't figure out how to make this work with other user formats than xx/xx/xxxx
            Console.WriteLine("Enter two dates, and I will tell you how many days are between them.");
            Console.Write("Enter the first date in the form  XX/XX/XXXX  ");
            string firstDate = Console.ReadLine();
            Console.Write("Enter the second date in the form  XX/XX/XXXX  ");
            string secondDate = Console.ReadLine();

            //convert firstDate and secondDate to datetime variables
            DateTime date1 = DateTime.Parse(firstDate);
            DateTime date2 = DateTime.Parse(secondDate);

            //subtract the two dates and store them in a timespan variable
            TimeSpan days = date2 - date1;

            Console.WriteLine("Those dates are " + days.TotalDays + " days apart.");

            Console.ReadLine();
        }
    }
}
