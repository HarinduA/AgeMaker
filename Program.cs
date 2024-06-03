using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth :");
            string input = Console.ReadLine();
            DateTime dob = DateTime.ParseExact(input, "yyyy-MM-dd", null);

            int age = CalculateAge(dob);
            Console.WriteLine("Your age is: " + age);

            static int CalculateAge(DateTime dob)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - dob.Year;

                
                int daysDifference = (today - dob).Days;

                
                age = daysDifference / 365;

                return age;
            }

        }

        
    }
}
