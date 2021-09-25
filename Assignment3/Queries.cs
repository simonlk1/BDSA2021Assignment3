using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public static IEnumerable<string> GetWizardsInventedByAuthorLinq(string author, IEnumerable<Wizard> wizards)
        {
            var wizardsFiltered = wizards.Where(w => w.Creator.Contains(author)).Select(w => w.Name); 
            return wizardsFiltered;
        }
        
        public static IEnumerable<string> GetWizardsInventedByAuthorExtensionMethod(string author, IEnumerable<Wizard> wizards)
        {
            var wizardsFiltered = from w in wizards where w.Creator.Contains(author) select w.Name;
            return wizardsFiltered;
        }
        
    }
}
