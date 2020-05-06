namespace MyOOP.Company
{
    public class FullTimeEmployee : Employee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
