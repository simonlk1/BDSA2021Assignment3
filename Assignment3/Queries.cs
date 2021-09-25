using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public static IEnumerable<string> GetWizardsInventedByAuthor(string author, IEnumerable<Wizard> wizards)
        {
            var wizardsFiltered = wizards.Where(w => w.Creator.Contains(author)).Select(w => w.Name); 
            return wizardsFiltered;
        }
        
    }
}
