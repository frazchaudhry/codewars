using System;
using System.Collections.Generic;
using System.Linq;
using Kata.Katas;
using Kata.Katas.StringOperations;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = StopSpinningMyWords.SpinWords("This is another test");
            var betterResult = StopSpinningMyWords.BetterSpinWords("This is another test");
            Console.WriteLine(result);
            Console.WriteLine(betterResult);
        }
    }
}