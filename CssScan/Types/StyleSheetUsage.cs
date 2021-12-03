using System.Collections.Generic;

namespace CssScan.Types
{
    public class StyleSheetUsage
    {
        public string Uri { get; set; }
        public int HttpStatusCode { get; set; }
        public List<RuleUsage> Rules { get; set; }

        public StyleSheetUsage()
        {
            Rules = new List<RuleUsage>();
        }
    }
}