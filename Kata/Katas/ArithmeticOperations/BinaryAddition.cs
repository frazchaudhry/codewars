using System;

namespace Kata.Katas.ArithmeticOperations
{
    public static class BinaryAddition
    {
        //Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
        //The binary number returned should be a string.
        public static string GetBinaryAddition(int first, int second)
        {
            var sum = first + second;
            return Convert.ToString(sum, 2);
        }
    }
}