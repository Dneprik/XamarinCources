using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            Console.WriteLine("The number words in the sentence is {0}", Console.ReadLine().CountWords());
        }
    }
}
