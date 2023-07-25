using System.Globalization;
using Udemy_Course.Entities;
using Udemy_Course.Services;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string carModel = Console.ReadLine();

Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm): ");
DateTime finishDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double pricePerHour = double.Parse(Console.ReadLine());
Console.Write("Enter price per day: ");
double pricePerDay = double.Parse(Console.ReadLine());

CarRental carRental = new(startDate, finishDate, new Vehicle(carModel));

RentalService rentalService = new RentalService(pricePerHour, pricePerDay);
rentalService.ProcessInvoice(carRental);

Console.WriteLine(carRental.Invoice);