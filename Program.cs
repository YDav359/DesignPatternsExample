using DesignPatternsExample.DesignPatterns.Adapter;
using System;

namespace DesignPatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer, smartPrinterA;

            printer = new Printer();
            smartPrinterA = new SmartPrinterAdapter(new SmartPrinter());

            printer.Print("hello");
            smartPrinterA.Print("hello");

            Console.ReadLine();
        }
    }
}
