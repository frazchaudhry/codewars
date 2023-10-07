```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Linux Mint 21.2 (Victoria)
13th Gen Intel Core i7-13700K, 8 CPU, 8 logical and 8 physical cores
.NET SDK 7.0.111
  [Host]   : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2


```
| Method    | Job                | Runtime            | Mean     | Error    | StdDev   | Gen0   | Allocated |
|---------- |------------------- |------------------- |---------:|---------:|---------:|-------:|----------:|
| TestMain  | .NET 7.0           | .NET 7.0           | 11.66 ns | 0.254 ns | 0.237 ns | 0.0020 |      32 B |
| TestAlt   | .NET 7.0           | .NET 7.0           | 20.52 ns | 0.438 ns | 0.450 ns |      - |         - |
| TestThird | .NET 7.0           | .NET 7.0           | 13.28 ns | 0.249 ns | 0.233 ns | 0.0020 |      32 B |
| TestMain  | Mono with .NET 6.0 | Mono with .NET 6.0 |       NA |       NA |       NA |     NA |        NA |
| TestAlt   | Mono with .NET 6.0 | Mono with .NET 6.0 |       NA |       NA |       NA |     NA |        NA |
| TestThird | Mono with .NET 6.0 | Mono with .NET 6.0 |       NA |       NA |       NA |     NA |        NA |

Benchmarks with issues:
  StringEndsWithComparison.TestMain: Mono with .NET 6.0(Runtime=Mono with .NET 6.0)
  StringEndsWithComparison.TestAlt: Mono with .NET 6.0(Runtime=Mono with .NET 6.0)
  StringEndsWithComparison.TestThird: Mono with .NET 6.0(Runtime=Mono with .NET 6.0)
