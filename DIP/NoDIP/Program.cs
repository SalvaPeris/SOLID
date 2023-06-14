using NoDIP;

internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeDataAccessLogic employeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        Employee emp = employeeDataAccessLogic.GetEmployeeDetails(1001);

        Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        Console.ReadKey();
    }
}