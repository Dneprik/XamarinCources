using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static int CountWords(this string sentence)
        {
         int count = Regex.Matches(sentence, @"([-]?[A-Za-z])+").Count;
         return count;
        }
    }
}
