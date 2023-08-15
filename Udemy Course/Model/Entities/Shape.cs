using Udemy_Course.Model.Enums;

namespace Udemy_Course.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
