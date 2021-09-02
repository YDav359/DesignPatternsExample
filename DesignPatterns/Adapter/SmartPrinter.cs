using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.DesignPatterns.Adapter
{
    public class SmartPrinter
    {
        public void Print(PaperFormat paperF, string text)
        {
            Console.WriteLine(text);
        }
    }

    public enum PaperFormat
    {
        A2,
        A3,
        A4
    }
}
