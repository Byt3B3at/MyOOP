namespace MyOOP.Company
{
    public class FullTimeEmployee : Employee
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }

        public override void WorkOn()
        {
            System.Console.WriteLine("I work FullTime on ProjectXY.");
        }
    }
}
