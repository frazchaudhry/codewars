```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Linux Mint 21.2 (Victoria)
13th Gen Intel Core i7-13700K, 8 CPU, 8 logical and 8 physical cores
.NET SDK 7.0.111
  [Host]     : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42501), X64 RyuJIT AVX2


```
| Method               | Mean     | Error   | StdDev  | Gen0   | Allocated |
|--------------------- |---------:|--------:|--------:|-------:|----------:|
| ValidBracesCaller    | 278.2 ns | 5.56 ns | 8.65 ns | 0.0381 |     600 B |
| ValidBracesAltCaller | 131.3 ns | 2.66 ns | 3.82 ns | 0.0041 |      64 B |
