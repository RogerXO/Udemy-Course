using System;
using Udemy_Course;

List<Employee> employees = new();

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 0; i < n; i ++ )
{
    Console.WriteLine($"Employee #{i + 1}");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Employee repeatingId = employees.Find(x => x.Id == id);

    while(repeatingId != null)
    {
        Console.WriteLine("This id is not available, please select other!");
        Console.Write("id: ");
        id = int.Parse(Console.ReadLine());
        repeatingId = employees.Find(x => x.Id == id);
    }

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    Console.WriteLine();

    Employee employee = new(id, name, salary);
    employees.Add(employee);
}

Console.Write("Enter the employee id that will have salary increase: ");
int employeeId = int.Parse(Console.ReadLine());
Employee employeeToIncreaseSalary = employees.Find(x => x.Id == employeeId);

if(employeeToIncreaseSalary == null)
{
    Console.WriteLine("This id do not exist!");
}
else
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine());
    employeeToIncreaseSalary.IncreaseSalary(percentage);
}

Console.WriteLine();

Console.WriteLine("Updated list of employees:");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}