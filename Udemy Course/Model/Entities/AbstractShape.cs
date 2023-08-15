using Udemy_Course.Model.Enums;

namespace Udemy_Course.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
