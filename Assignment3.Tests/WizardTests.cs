using System.Collections.Generic;
using Xunit;

namespace Assignment3.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Harry Potter","Harry Potter and the Philosopher's Stone",2001,"J.K. Rowling")]
        [InlineData("Ron Weasley","Harry Potter and the Philosopher's Stone",2001,"J.K. Rowling")]
        [InlineData("Albus Dumbledore","Harry Potter and the Chamber of Secrets",2002,"J.K. Rowling")]
        [InlineData("Draco Malfoy","Harry Potter and the Chamber of Secrets",2002,"J.K. Rowling")]
        [InlineData("Darth Maul","Star Wars",1977,"George Lucas")]
        [InlineData("Frodo","The Fellowship of the Ring",1954,"J.R.R. Tolkien")]
        [InlineData("Darth Sidious","Star Wars Episode 5",1980,"George Lucas")]
        [InlineData("Sam","The Fellowship of the Ring",1954,"J.R.R. Tolkien")]
        [InlineData("Doctor Strange","Doctor Strange",2016,"Scott Derrickson")]
        [InlineData("Merlin","Merlin",1998,"Steve Barron")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }

        [Fact]
        public void WizardsInventedByRowlingUsingLinq_Return_Harry_Potter_Ron_Weasley_Albus_Dumbledore_Draco_Malfoy()
        {
            // act
            var actual = Queries.GetWizardsInventedByRowlingLinq();

            // assert
            var expected = new []{"Harry Potter","Ron Weasley","Albus Dumbledore","Draco Malfoy"};
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void WizardsInventedByRowlingUsingExtensionMethod_Return_Harry_Potter_Ron_Weasley_Albus_Dumbledore_Draco_Malfoy()
        {
            // act
            var actual = Queries.GetWizardsInventedByRowlingExtensionMethod();

            // assert
            var expected = new []{"Harry Potter","Ron Weasley","Albus Dumbledore","Draco Malfoy"};
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void FirstYearSithLordWasIntroduced_Return_1977_UsingLinq()
        {
            // act
            var actual = Queries.GetYearTheFirstSithLordWasIntroducedLinq();

            // assert
            var expected = 1977;
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void FirstYearSithLordWasIntroduced_Return_1977_UsingExtensionMethod()
        {
            // act
            var actual = Queries.GetYearTheFirstSithLordWasIntroducedExtensionMethod();

            // assert
            var expected = 1977;
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void GetUniqueListOfWizardsFromHarryPotterExtensionMethod_Return_4_wizards_as_tuple()
        {
            // act
            var actual = Queries.GetUniqueListOfWizardsFromHarryPotterExtensionMethod();

            // assert
            var expected = new (string,int?)[]{("Harry Potter",2001),("Ron Weasley",2001),("Albus Dumbledore",2002),("Draco Malfoy",2002)};
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void GetUniqueListOfWizardsFromHarryPotterLinq_Return_4_wizards_as_tuple()
        {
            // act
            var actual = Queries.GetUniqueListOfWizardsFromHarryPotterLinq();

            // assert
            var expected = new (string,int?)[]{("Harry Potter",2001),("Ron Weasley",2001),("Albus Dumbledore",2002),("Draco Malfoy",2002)};
            Assert.Equal(expected,actual);
        }
    }
}

