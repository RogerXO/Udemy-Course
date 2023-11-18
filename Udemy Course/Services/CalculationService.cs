namespace Udemy_Course.Services
{
    internal class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            Console.WriteLine((x>y) ? x : y);   
        }

        public static void ShowSum(double x, double y)
        {
            Console.WriteLine(x + y);
        }
    }
}
