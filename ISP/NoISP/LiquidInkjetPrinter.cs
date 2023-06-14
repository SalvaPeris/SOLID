namespace NoISP
{
    public class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print done");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
