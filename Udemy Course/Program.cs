using Udemy_Course.Entities;

try
{
    Teacher teacher = new("Alex");

    teacher.AddCourse("A");
    teacher.AddCourse("B");
    teacher.AddCourse("C");

    HashSet<Course> courses = teacher.GetCourses();

    foreach (Course course in courses)
    {
        Console.Write($"How many students for course {course.Name}? ");
        int studentsQuantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsQuantity; i++)
        {
            int studentCode = int.Parse(Console.ReadLine());
            teacher.AddStudentToCourse(course.Name,new Student(studentCode));
        }
    }
    Console.WriteLine($"Total students: {teacher.GetStudentsCount()}");
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}