using Udemy_Course.Devices;

Printer printer = new Printer() { SerialNumber = 123 };
printer.ProcessDoc("document");
printer.Print("A4 paper");

Scanner scanner = new Scanner() { SerialNumber = 456 };
scanner.ProcessDoc("pdf");
Console.WriteLine(scanner.Scan());

ComboDevice comboDevice = new ComboDevice();
comboDevice.ProcessDoc("Nubank Bill");
Console.WriteLine(comboDevice.Scan());
comboDevice.Print("papel pro baseado");