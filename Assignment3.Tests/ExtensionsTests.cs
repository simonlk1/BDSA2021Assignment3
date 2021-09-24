using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_uri_has_https()
        {
            // Arrange
            var uri = new Uri("https://www.itu.dk");

            // Act
            bool actual = uri.IsSecure();

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsSecure_uri_has_https_with_uppercase()
        {
            // Arrange
            var uri = new Uri("hTtpS://www.itu.dk");

            // Act
            bool actual = uri.IsSecure();

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsSecure_uri_not_https()
        {
            // Arrange
            var uri = new Uri("http://www.itu.dk");

            // Act
            bool actual = uri.IsSecure();

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void WordCount_given_5_words_returns_5()
        {
            // Arrange
            var input = "Hej med dig og dig";

            // Act
            var output = input.WordCount();

            // Assert
            Assert.Equal(5, output);
        }

        [Fact]
        public void WordCount_given_5_words_with_withspace_returns_5()
        {
            // Arrange
            var input = "word\n \n hej   her   \n Rasmus  Simon ";

            // Act
            var output = input.WordCount();

            // Assert
            Assert.Equal(5, output);
        }

        [Fact]
        public void WordCount_given_5_words_and_punctuation_returns_5()
        {
            // Arrange
            var input = "hej.der.,,,--tal-: ; abc moo";

            // Act
            var output = input.WordCount();

            // Assert
            Assert.Equal(5, output);
        }

        [Fact]
        public void WordCount_given_5_words_foreign_characters_returns_5()
        {
            // Arrange
            var input = "æøå, . , \n abcåøabc   -.ol  jeg  hej";
            // Act
            var output = input.WordCount();

            // Assert
            Assert.Equal(5, output);
        }
    }
}
