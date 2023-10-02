namespace Udemy_Course.Devices
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing {document}...");
        }

        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice printed {document}");
        }

        public string Scan()
        {
            return "ComboDevice just scanned something";
        }
    }
}
