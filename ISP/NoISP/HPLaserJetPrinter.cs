namespace NoISP
{
    public class HPLaserJetPrinter : IPrinterTasks
    {
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Print done");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Scan content");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Fax content");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Print duplex content");
        }
    }
}
