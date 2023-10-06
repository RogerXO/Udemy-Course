namespace Udemy_Course.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        private HashSet<Student> _students = new();

        public Course(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public HashSet<Student> GetStudents()
        {
            return _students;
        }
    }
}
