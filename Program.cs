using MyOOP.Company;
using System;

namespace MyOOP
{
    internal static class Program
    {
        internal static int Main()
        {
            var Max = new FullTimeEmployee()
            {
                FirstName = "Max",
                LastName = "Mustermann",
                AnnualSalary = 60000
            };
            Console.WriteLine($"{Max.GetFullName()} earns {Max.GetMonthlySalary()} per month.");

            var Moritz = new Freelancer()
            {
                FirstName = "Moritz",
                LastName = "Mustermann",
                HourlyWage = 200,
                HoursWorked = 160
            };
            Console.WriteLine($"{Moritz.GetFullName()} earned {Moritz.GetMonthlySalary()}.");

            Console.WriteLine("\nProgram end reached. Press the any-key to exit.");
            Console.ReadKey();
            return 0;
        }
    }
}
