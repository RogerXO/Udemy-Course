using System.Globalization;
using Udemy_Course.Entities;
using Udemy_Course.Services;

Console.WriteLine("Enter contract data");

Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());

Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

Contract contract = new(contractNumber, contractDate, contractValue);
ContractService contractService = new(new PaypalService());

contractService.ProcessContract(contract, numberOfInstallments);

Console.WriteLine("Installments:");

 foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}