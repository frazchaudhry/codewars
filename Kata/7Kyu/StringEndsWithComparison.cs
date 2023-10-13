using System;
using BenchmarkDotNet.Attributes;

namespace Kata._7Kyu;

[MemoryDiagnoser]
public class StringEndsWithComparison
{
    /*
     * Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

        Examples:
        solution('abc', 'bc') // returns true
        solution('abc', 'd') // returns false
     */
    public static bool IsFirstStringContainsSecondStringAtTheEnd(string first, string second)
    {
        return first.Substring(Math.Max(0, first.Length - second.Length)) == second;
    }

    public static bool IsFirstStringContainsSecondStringAtTheEndAlt(string first, string second)
    {
        return first.EndsWith(second);
    }

    [Benchmark(Baseline = true)]
    public bool TestMain()
    {
        return IsFirstStringContainsSecondStringAtTheEnd("abcdefg", "efg");
    }

    [Benchmark]
    public bool TestAlt()
    {
        return IsFirstStringContainsSecondStringAtTheEndAlt("abcdefg", "efg");
    }

    [Benchmark]
    public bool TestThird()
    {
        return IsFirstStringContainsSecondStringAtTheEndThird("abcdefg", "efg");
    }
    
    public static bool IsFirstStringContainsSecondStringAtTheEndThird(string first, string second) => first[Math.Max(0, first.Length - second.Length)..] == second;
}