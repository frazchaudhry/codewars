using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Kata.Katas.ArithmeticOperations;

[MemoryDiagnoser]
public class DigitalRootKata
{
    public static int DigitalRoot(long n)
    {
        if (n < 10) return (int)n;

        var numAsString = n.ToString();
        var characters = numAsString.ToCharArray();

        var numbers = characters.Select(num => int.Parse(num.ToString())).ToArray();

        var total = numbers.Sum();

        return DigitalRoot(total);
    }

    public static int DigitalRootAlt(long n)
    {
        if (n < 10) return (int)n;

        var digits = new List<int>();

        while (n > 0)
        {
            digits.Add((int)(n % 10));
            n /= 10;
        }

        return DigitalRoot(digits.Sum());
    }

    public static int DigitalRootCongruenceFormula(long n)
    {
        // See: https://en.wikipedia.org/wiki/Digital_root#Congruence_formula
        if (n == 0)
            return 0;
        if (n % 9 == 0)
            return 9;
        return (int)(n % 9);
    }
    
        //method by hand: https://www.youtube.com/watch?v=YX9Fd6kxLsA
        //efficient method: https://stackoverflow.com/questions/1057072/calculating-digital-root-is-there-a-better-way
        public static int DigitalRootEfficient(long n)
        {
            return (int)((n - 1) % 9 + 1);
        }

        [Benchmark]
    public void DigitalRootCaller()
    {
        ReadOnlySpan<long> numbers = stackalloc [] { 0, 10, 16, 195, 992, 167346, 999999999999 };

        foreach (var number in numbers)
        {
            DigitalRoot(number);
        }
    }

    [Benchmark]
    public void DigitalRootAltCaller()
    {
        ReadOnlySpan<long> numbers = stackalloc [] { 0, 10, 16, 195, 992, 167346, 999999999999 };

        foreach (var number in numbers)
        {
            DigitalRootAlt(number);
        }
    }
    
        [Benchmark]
        public void DigitalRootCongruenceFormulaCaller()
        {
            ReadOnlySpan<long> numbers = stackalloc [] { 0, 10, 16, 195, 992, 167346, 999999999999 };
    
            foreach (var number in numbers)
            {
                DigitalRootCongruenceFormula(number);
            }
        }
        
        [Benchmark]
        public void DigitalRootEfficientCaller()
        {
            ReadOnlySpan<long> numbers = stackalloc [] { 0, 10, 16, 195, 992, 167346, 999999999999 };
    
            foreach (var number in numbers)
            {
                DigitalRootEfficient(number);
            }
        }
}