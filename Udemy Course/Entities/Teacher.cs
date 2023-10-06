namespace Udemy_Course.Entities
{
    internal class Teacher
    {
        public string Name { get; set; }
        private SortedSet<string> _courses = new() { "A", "B", "C"};
        private SortedSet<Student> _students = new();

        public Teacher(string name)
        {
            Name = name;
        }

        public void AddCourse(string courseName)
        {
            _courses.Add(courseName);
        }

        public SortedSet<string> GetCourses()
        {
            return _courses;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public int GetStudentsCount()
        {
            return _students.Count();
        }
    }
}
