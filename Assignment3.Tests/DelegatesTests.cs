using System;
using System.Text;
using Xunit;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        // Solved using anonymous function
        [Fact]
        public void ReverseString_given_hejmeddig_returns_giddemjeh()
        {
            // Arrange
            string ReverseString(string input)
            {
                var sb = new StringBuilder();
                int length = input.Length;
                for (int i = length - 1; i >= 0; i--)
                {
                    sb.Append(input[i]);
                }

                return sb.ToString();
            }

            var input = "hejmeddig";

            // Act
            var output = ReverseString(input);

            // Assert
            Assert.Equal("giddemjeh", output);
        }

        // Solved using delegate + lambda
        [Fact]
        public void Product_given_2_point_5_and_10_returns_25()
        {
            // Arrange
            Func<decimal, decimal, decimal> product = (a, b) => a * b;
            decimal a = 2.5m;
            decimal b = 10m;

            // Act
            var output = product(a, b);

            // Assert
            Assert.Equal(25, output);
        }

        // Solved using delegate + lambda
        [Fact]
        public void NumericallyEqual_given_space_0042_and_42_returns_true()
        {
            // Arrange
            Func<string, int, bool> numericallyEqual = (s, n) => n == Int32.Parse(s);
            var stringInput = " 0042";
            var intInput = 42;

            // Act
            bool result = numericallyEqual(stringInput, intInput);

            // Assert
            Assert.True(result);
        }
    }
}
