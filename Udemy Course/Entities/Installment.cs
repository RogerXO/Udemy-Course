namespace Udemy_Course.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amoutn)
        {
            DueDate = dueDate;
            Amount = amoutn;
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount:F2}";
        }
    }
}
