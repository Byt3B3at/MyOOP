namespace MyOOP.Company
{
    /// <summary>
    /// Base class for defined kind of Employees.
    /// </summary>
    /// <remarks>
    /// Designed abstract to provide common functionality 
    /// and to avoid unnecessary instantiation.
    /// </remarks>
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} + {LastName}";
        }

        // Should be implemented in derived classes.
        public abstract int GetMonthlySalary();
    }
}
