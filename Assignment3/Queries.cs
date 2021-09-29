using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public static IEnumerable<string> GetWizardsInventedByRowlingExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;
            var wizardsFiltered = wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name); 
            return wizardsFiltered;
        }
        
        public static IEnumerable<string> GetWizardsInventedByRowlingLinq()
        {
            var wizards = Wizard.Wizards.Value;
            var wizardsFiltered = from w in wizards where w.Creator.Contains("Rowling") select w.Name;
            return wizardsFiltered;
        }

        public static int? GetYearTheFirstSithLordWasIntroducedExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;
            var firstYear = wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).First().Year;
            return firstYear;
        }
        
        public static int? GetYearTheFirstSithLordWasIntroducedLinq()
        {
            var wizards = Wizard.Wizards.Value;
            var firstYear = (from w in wizards where w.Name.Contains("Darth") orderby w.Year select w.Year).First();
            return firstYear;
        }
        
        public static IEnumerable<(string,int?)> GetUniqueListOfWizardsFromHarryPotterExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;
            var filteredWizards = wizards.Where(w => w.Medium.Contains("Harry Potter"))
                .Select(w => (w.Name, w.Year)).Distinct();
            return filteredWizards;
        }
        
        public static IEnumerable<(string,int?)> GetUniqueListOfWizardsFromHarryPotterLinq()
        {
            var wizards = Wizard.Wizards.Value;
            var filteredWizards = (from w in wizards where w.Medium.Contains("Harry Potter") select (w.Name, w.Year)).Distinct();
            return filteredWizards;
        }
        
        public static IEnumerable<string> GetGroupedByCreatorInReverseOrderByCreatorNameAndThenWizardNameExtensionMethod()
        {
            var wizards = Wizard.Wizards.Value;
            var filteredWizards = wizards.GroupBy(w => (w.Creator, w.Name)).OrderBy(w => w.Key.Creator)
                .ThenBy(w => w.Key.Name).Reverse().Select(w => w.Key.Name);
            return filteredWizards;
        }
        
        public static IEnumerable<string> GetGroupedByCreatorInReverseOrderByCreatorNameAndThenWizardNameLinq()
        {
            var wizards = Wizard.Wizards.Value;
            var filteredWizards = (from w in wizards
                group w by (w.Creator, w.Name)
                into newGroup
                orderby (newGroup.Key.Creator, newGroup.Key.Name)
                select newGroup.Key.Name).Reverse();
            return filteredWizards;
        }
    }
}
