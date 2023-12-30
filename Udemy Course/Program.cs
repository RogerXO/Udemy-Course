using System.Globalization;
using Udemy_Course.Entities;

List<Employee> employees = new();

Console.Write("Enter full file path: ");
string path = Console.ReadLine()!;

Console.Write("Enter salary: ");
double minSalary = double.Parse(Console.ReadLine()!);

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(", ");
        string name = fields[0];
        string email = fields[1];
        double salary = double.Parse(fields[2]);

        employees.Add(new Employee(name, email, salary));
    }
}

Console.WriteLine($"Email of people whose salary is more than {minSalary.ToString("F2", CultureInfo.InvariantCulture)}:");

IEnumerable<string> emails = employees.Where(emp => emp.Salary > minSalary).OrderBy(emp => emp.Email).Select(emp => emp.Email);

foreach(string email in emails)
{
    Console.WriteLine(email);
}

Console.WriteLine();

double salarySum = employees.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);
Console.WriteLine($"Sum of salary of people whose name starts with 'M': {salarySum.ToString("F2", CultureInfo.InvariantCulture)}");