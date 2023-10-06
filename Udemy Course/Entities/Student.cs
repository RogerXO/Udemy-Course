namespace Udemy_Course.Entities
{
    internal class Student : IComparable
    {
        public int Code { get; set; }  

        public Student(int code)
        {
            Code = code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals (object? obj)
        {
            if (obj is not Student) return false;

            Student other = obj as Student;

            return Code.Equals(other.Code);
        }

        public int CompareTo(object obj)
        {
            if (obj is not Student)
            {
                throw new ArgumentException("Argument is not an Student");
            }

            Student other = obj as Student;

            return Code.CompareTo(other.Code);
        }
    }
}
