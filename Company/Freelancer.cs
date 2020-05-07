namespace MyOOP.Company
{
    class Freelancer : Employee
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public int HourlyWage { get; set; }
        public int HoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return HourlyWage * HoursWorked;
        }

        public override void WorkOn()
        {
            System.Console.WriteLine("I work as a Freelancer on ProjectXY.");
        }
    }
}
