```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Linux Mint 21.2 (Victoria)
13th Gen Intel Core i7-13700K, 8 CPU, 8 logical and 8 physical cores
.NET SDK 7.0.111
  [Host]     : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2


```
| Method               | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------------- |---------:|----------:|----------:|-------:|----------:|
| DigitalRootCaller    | 2.020 μs | 0.0398 μs | 0.0676 μs | 0.1793 |   2.79 KB |
| DigitalRootAltCaller | 1.952 μs | 0.0383 μs | 0.0498 μs | 0.1793 |   2.79 KB |
