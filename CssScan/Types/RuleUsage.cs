using System.Collections.Generic;

namespace CssScan.Types
{
    public class RuleUsage
    {
        public bool IsError { get; set; }
        public bool HasBeenChecked { get; set; }
        public ExCSS.StyleRule StyleRule { get; set; }
        public List<string> Pages { get; set; }

        public RuleUsage()
        {
            Pages = new List<string>();
        }

        public RuleUsage(ExCSS.IStyleRule rule)
        {
            StyleRule = (ExCSS.StyleRule)rule;
            Pages = new List<string>();
        }
    }
}