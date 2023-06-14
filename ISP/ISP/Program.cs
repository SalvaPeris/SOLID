﻿using ISP;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is Interface Segregation Principle!");

        //Using HPLaserJetPrinter we can access all Printer Services
        HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
        hPLaserJetPrinter.Print("Printing");
        hPLaserJetPrinter.Scan("Scanning");
        hPLaserJetPrinter.Fax("Faxing");
        hPLaserJetPrinter.PrintDuplex("PrintDuplex");
        
        //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
        LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
        liquidInkjetPrinter.Print("Printing");
        liquidInkjetPrinter.Scan("Scanning");

        Console.ReadKey();
    }
}