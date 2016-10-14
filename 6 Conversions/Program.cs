using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //converts miles to kilometers
            ConversionUtility cov = new ConversionUtility();
            double km = cov.convertMileToKM(400);
            Console.Write("400 miles is equal to ");
            Console.Write("{0:n2}", km);
            Console.WriteLine(" Kilometers");

            //Converts feet to inches
            double inch = cov.convertFeetToInches(400);
            Console.Write("400 feet is equal to ");
            Console.WriteLine(inch + " Inches");

            //converts days to hours
            double hour = cov.convertHoursPerDay(400);
            Console.Write("400 days is equal to ");
            Console.WriteLine(hour + " Hours");

             //converts miles to feet
            double ft = cov.convertMilesToFeet(400);
            Console.Write("400 miles is equal to ");
            Console.Write("{0:N3}", ft);
            Console.WriteLine(" Feet");

            
             //converts cents to dollars
            double dollar = cov.convertCentsToDollars(400);
            Console.Write("400 cents is equal to ");
            Console.WriteLine("{0:C2}", dollar);
            

             //converts minutes to seconds
            double sec = cov.convertMinutesToSeconds(400);
            Console.Write("400 minutes is equal to ");
            Console.WriteLine(sec + " seconds");

            Console.ReadLine();
        }
    }
}
