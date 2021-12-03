using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CssScan.Types
{
    public class Scan : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public string RootUri { get; set; }

        public int LevelsToParse { get; set; }
        public bool RestrictToDomain { get; set; }

        public Dictionary<string, HtmlDocument> Pages { get; set; }
        public List<StyleSheetUsage> Stylesheets { get; set; }

        public Scan()
        {
            Id = Guid.NewGuid();
            Pages = new Dictionary<string, HtmlDocument>();
            Stylesheets = new List<StyleSheetUsage>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
