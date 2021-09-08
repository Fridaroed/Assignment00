using System;

namespace Lecture01
{
    public class Program
    {
        private bool isLeapYearBool;
            public static void Main(string[] args)
        {
            userInput_IsLeapYear(Convert.ToInt32(Console.ReadLine()));
        }


        public static bool isLeapYear(int year){

            if (year % 4 == 0)
            {
                if ((year % 100 != 0) || (year % 400 == 0))
                {
                    return true;
                } else
                {
                    return false;
                }
                
            }
            return false;

        }


        public static void userInput_IsLeapYear(int year) {

            try {

            if (year < 1582)
            {
                throw new ArgumentException("Year must be from 1582 or later");
            } 

            if (isLeapYear(year)) 
            {
                Console.WriteLine("yay");
            } else
            {
                Console.WriteLine("nay");
            }
            } catch (ArgumentException e){
                Console.WriteLine(e.Message);
            }


        }

        
    }
}



/* LeapYear LY = new LeapYear();
            try {
                int year = int.Parse(Console.ReadLine());
                LY.isLeapYear(year);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            catch (FormatException) {
                Console.WriteLine("Please type in year");
            }
 */

