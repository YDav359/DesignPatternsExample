using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.DesignPatterns.Strategy
{
    public class TextTranformer
    {
        public ITextTransform TextTransform { set; get; }

        public string Tranform(string text)
        {
            return TextTransform.Transform(text);
        }
    }
}
