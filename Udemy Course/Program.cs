using Udemy_Course.Entities;

string path = @"C:\Users\User\Documents\poc.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new();

        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();

        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
}

catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}