namespace MyOOP.Company
{
    class Freelancer : Employee
    {
        public int HourlyWage { get; set; }
        public int HoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return HourlyWage * HoursWorked;
        }
    }
}
