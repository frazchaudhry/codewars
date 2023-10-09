using BenchmarkDotNet.Running;
using Kata.Katas.ArithmeticOperations;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DigitalRootKata>();
        }
    }
}