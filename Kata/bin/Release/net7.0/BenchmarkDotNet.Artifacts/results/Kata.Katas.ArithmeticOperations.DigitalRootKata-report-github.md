```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Linux Mint 21.2 (Victoria)
13th Gen Intel Core i7-13700K, 8 CPU, 8 logical and 8 physical cores
.NET SDK 7.0.111
  [Host]     : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2


```
| Method                             | Mean         | Error      | StdDev     | Gen0   | Allocated |
|----------------------------------- |-------------:|-----------:|-----------:|-------:|----------:|
| DigitalRootCaller                  | 1,659.832 ns | 25.5047 ns | 21.2975 ns | 0.1564 |    2456 B |
| DigitalRootAltCaller               |   778.623 ns | 15.5456 ns | 23.2680 ns | 0.0906 |    1432 B |
| DigitalRootCongruenceFormulaCaller |    15.913 ns |  0.3075 ns |  0.2876 ns |      - |         - |
| DigitalRootEfficientCaller         |     7.013 ns |  0.1793 ns |  0.4432 ns |      - |         - |
