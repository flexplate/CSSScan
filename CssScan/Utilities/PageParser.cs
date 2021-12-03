using CssScan.Types;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CssScan.Utilities
{
    public class PageParser
    {
        HtmlWeb Web = new HtmlWeb();

        /// <summary>
        /// Parse a HTML page for its links to other pages, parse *those*, recursively up to a maximum depth.
        /// </summary>
        /// <param name="uri">Page to parse.</param>
        /// <param name="maxDepth">Depth to traverse.</param>
        /// <param name="restrictDomain">If true, will only return links from <paramref name="rootDomain"/>.</param>
        /// <param name="rootDomain">Domain to restrict results to.</param>
        /// <returns></returns>
        public Dictionary<string, HtmlDocument> GetLinkedPagesRecursive(string uri, int maxDepth, bool restrictDomain, string rootDomain)
        {
            var OutList = new Dictionary<string, HtmlDocument>();
            HtmlDocument Document = Web.Load(uri);
            OutList.Add(uri, Document);
            if (maxDepth > 0)
            {
                foreach (HtmlNode link in Document.DocumentNode.Descendants("a").Where(l => l.GetAttributeValue("href", "") != null))
                {
                    string TempAddress = link.GetAttributeValue("href", "");
                    Uri Address;

                    if (Uri.IsWellFormedUriString(TempAddress, UriKind.Relative))
                    {
                        TempAddress = Flurl.Url.Combine(rootDomain, TempAddress);
                    }

                    if (Uri.TryCreate(TempAddress,UriKind.Absolute, out Address))
                    {
                        if ((Address.Host == rootDomain) || (restrictDomain == false))
                        {
                            var NextLevel = GetLinkedPagesRecursive(Address.ToString(), maxDepth - 1, restrictDomain, rootDomain);
                            foreach (var item in NextLevel)
                            {
                                OutList.Add(item.Key, item.Value);
                            }
                        }
                    }
                }
            }
            return OutList;
        }

        public Dictionary<string, HtmlDocument> GetLinkedPagesRecursive(Scan scan)
        {
           return GetLinkedPagesRecursive(scan.RootUri, scan.LevelsToParse, scan.RestrictToDomain, scan.RootUri);
        }


    }
}
