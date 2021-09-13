using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.DesignPatterns.Strategy
{
    public class UpperTranform : ITextTransform
    {
        public string Transform(string text)
        {
            return text.ToUpper();
        }
    }
}
