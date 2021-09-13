using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.DesignPatterns.Strategy
{
    public class ReplaceTranform : ITextTransform
    {
        public string OldText { set; get; }
        public string NewText { set; get; }

        public ReplaceTranform(string oldStr, string newStr)
        {
            OldText = oldStr;
            NewText = newStr;
        }

        public string Transform(string text)
        {
            return text.Replace(OldText, NewText);
        }
    }
}
