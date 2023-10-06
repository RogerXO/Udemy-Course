namespace Udemy_Course.Entities
{
    internal class Teacher
    {
        public string Name { get; set; }
        private HashSet<Course> _courses = new();
        private HashSet<Student> _students = new();

        public Teacher(string name)
        {
            Name = name;
        }

        public void AddCourse(string courseName)
        {
            _courses.Add(new Course(courseName));
        }

        public HashSet<Course> GetCourses()
        {
            return _courses;
        }

        public void AddStudentToCourse(string courseName,Student student)
        {
            Course course= _courses.First(x => x.Name == courseName);

            if (course != null)
            {
                course.AddStudent(student);
            }
        }

        public int GetStudentsCount()
        {
            foreach(Course course in _courses)
            {
                _students.UnionWith(course.GetStudents());
            }

            return _students.Count;
        }
    }
}
