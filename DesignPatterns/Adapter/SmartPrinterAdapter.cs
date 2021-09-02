using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.DesignPatterns.Adapter
{
    public class SmartPrinterAdapter : IPrinter
    {
        private SmartPrinter _smartPrinter;

        public SmartPrinterAdapter(SmartPrinter smartPrinter)
        {
            _smartPrinter = smartPrinter;
        }

        public void Print(string text)
        {
            _smartPrinter.Print(PaperFormat.A4, text);
        }
    }
}
