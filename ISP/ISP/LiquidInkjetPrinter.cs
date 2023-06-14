namespace ISP
{
    public class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print content");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
