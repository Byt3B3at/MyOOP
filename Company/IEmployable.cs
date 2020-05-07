namespace MyOOP.Company
{
    interface IEmployable
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string GetFullName();
        int GetMonthlySalary();
        void WorkOn();
    }
}
