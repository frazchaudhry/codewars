using BenchmarkDotNet.Running;
using Kata._6Kyu;

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