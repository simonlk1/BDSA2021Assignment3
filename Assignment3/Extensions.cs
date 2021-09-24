using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri)
        {
            var scheme = uri.Scheme;
            return scheme == "https";
        }

        public static int WordCount(this string input)
        {
            string delimiter = @"\P{L}+";

            var trimmedInput = input.Trim();
            return Regex.Split(trimmedInput, delimiter).Count();
        }
    }
}
