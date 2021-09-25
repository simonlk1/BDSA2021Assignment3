using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public static IEnumerable<string> GetWizardsInventedByAuthorExtensionMethod(string author, IEnumerable<Wizard> wizards)
        {
            var wizardsFiltered = wizards.Where(w => w.Creator.Contains(author)).Select(w => w.Name); 
            return wizardsFiltered;
        }
        
        public static IEnumerable<string> GetWizardsInventedByAuthorLinq(string author, IEnumerable<Wizard> wizards)
        {
            var wizardsFiltered = from w in wizards where w.Creator.Contains(author) select w.Name;
            return wizardsFiltered;
        }

        public static int? GetYearTheFirstSithLordWasIntroducedExtensionMethod(IEnumerable<Wizard> wizards)
        {
            var firstYear = wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).First().Year;
            return firstYear;
        }
        
        public static int? GetYearTheFirstSithLordWasIntroducedLinq(IEnumerable<Wizard> wizards)
        {
            var firstYear = (from w in wizards where w.Name.Contains("Darth") orderby w.Year select w.Year).First();
            return firstYear;
        }
        
    }
}
