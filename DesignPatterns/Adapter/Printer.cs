using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.DesignPatterns.Adapter
{
    public class Printer : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
