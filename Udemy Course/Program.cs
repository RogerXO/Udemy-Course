using Udemy_Course.Entities;

try
{
    Teacher teacher = new("Alex");
    SortedSet<string> courses = teacher.GetCourses();

    teacher.AddCourse("A");
    teacher.AddCourse("B");
    teacher.AddCourse("C");

    foreach (string course in courses)
    {
        Console.Write($"How many students for course {course}? ");
        int studentsQuantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsQuantity; i++)
        {
            int studentCode = int.Parse(Console.ReadLine());
            teacher.AddStudent(new Student(studentCode));
        }
    }
    Console.WriteLine($"Total students: {teacher.GetStudentsCount()}");
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}