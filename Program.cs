using MyOOP.Company;
using System;

namespace MyOOP
{
    internal static class Program
    {
        internal static int Main()
        {
            // Using an interface makes the code more flexible
            // but ensures at the same time that the commitments
            // of an Employee are fulfilled.
            IEmployable Max = new FullTimeEmployee()
            {
                FirstName = "Max",
                LastName = "Mustermann",
                AnnualSalary = 60000
            };
            Console.WriteLine($"{Max.GetFullName()} earns {Max.GetMonthlySalary()} per month.");
            Max.WorkOn();

            Console.WriteLine();

            IEmployable Moritz = new Freelancer()
            {
                FirstName = "Moritz",
                LastName = "Mustermann",
                HourlyWage = 200,
                HoursWorked = 20
            };
            Console.WriteLine($"{Moritz.GetFullName()} worked {((Freelancer)Moritz).HoursWorked} hours and earned {Moritz.GetMonthlySalary()} last month.");
            Moritz.WorkOn();

            Console.WriteLine("\nProgram end reached. Press the any-key to exit.");
            Console.ReadKey();
            return 0;
        }
    }
}
