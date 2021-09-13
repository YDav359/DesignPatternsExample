using DesignPatternsExample.DesignPatterns.Adapter;
using DesignPatternsExample.DesignPatterns.Strategy;
using System;

namespace DesignPatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------> Adapter <--------------
            IPrinter printer, smartPrinterA;

            printer = new Printer();
            smartPrinterA = new SmartPrinterAdapter(new SmartPrinter());

            printer.Print("hello");
            smartPrinterA.Print("hello");

            string sourceText = "Hello Strategy!";
            TextTranformer tranformer = new TextTranformer();

            // --------------> Strategy <--------------
            ITextTransform upperTransform, replaceTranform;
            upperTransform = new UpperTranform();
            replaceTranform = new ReplaceTranform("e", "*");

            tranformer.TextTransform = upperTransform;
            Console.WriteLine(tranformer.Tranform(sourceText));

            tranformer.TextTransform = replaceTranform;
            Console.WriteLine(tranformer.Tranform(sourceText));


            Console.ReadLine();
        }
    }
}
