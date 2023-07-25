namespace Udemy_Course.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double CalculateTax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
