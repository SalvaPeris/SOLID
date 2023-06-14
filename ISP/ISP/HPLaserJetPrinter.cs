namespace ISP
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Fax(string content)
        {
            Console.WriteLine("Fax done");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print done");
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine("Print duplex done");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan done");
        }
    }
}
