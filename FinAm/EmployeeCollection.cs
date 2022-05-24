namespace FinAm
{
    public class EmployeeCollection
    {
        static List<Employee> employees = new List<Employee> 
        { 
            new Employee { FirstName = "Андрей", LastName = "Андреев"},
            new Employee { FirstName = "Андрей", LastName = "Андреев"},
            new Employee { FirstName = "Богдан", LastName = "Богданов"},
            new Employee { FirstName = "Вардан", LastName = "Варданов"},
            new Employee { FirstName = "Гамар", LastName = "Гамаров"},
            new Employee { FirstName = "Димон", LastName = "Димонов"}
        };

        public static List<Employee> Find(string firstName, string lastName)
        {
            return employees.Where(x => firstName == x.FirstName && lastName == x.LastName)
                .ToList();
        }
    }
}
