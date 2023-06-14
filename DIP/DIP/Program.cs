﻿using DIP;

internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);

        Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        Console.ReadKey();
    }
}