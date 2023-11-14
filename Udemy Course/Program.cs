using Udemy_Course.Services;

namespace Udemy_Couse
{
    //delegate
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
