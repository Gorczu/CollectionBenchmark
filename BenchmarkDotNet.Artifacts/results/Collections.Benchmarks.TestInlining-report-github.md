``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2437705 Hz, Resolution=410.2219 ns, Timer=TSC
.NET Core SDK=3.0.100-preview-009812
  [Host] : .NET Core 3.0.0-preview-27122-01 (CoreCLR 4.6.27121.03, CoreFX 4.7.18.57103), 64bit RyuJIT
  Core   : .NET Core 3.0.0-preview-27122-01 (CoreCLR 4.6.27121.03, CoreFX 4.7.18.57103), 64bit RyuJIT


```
| Method |    Job | Runtime |     N |       Mean |     Error |     StdDev |     Median | Ratio | RatioSD | Rank |
|------- |------- |-------- |------ |-----------:|----------:|-----------:|-----------:|------:|--------:|-----:|
|  **calcA** |    **Clr** |     **Clr** |  **1000** |         **NA** |        **NA** |         **NA** |         **NA** |     **?** |       **?** |    **?** |
|  calcA |   Core |    Core |  1000 |  12.935 us | 0.2570 us |  0.7416 us |  12.723 us |     ? |       ? |    1 |
|  calcA | CoreRT |  CoreRT |  1000 |         NA |        NA |         NA |         NA |     ? |       ? |    ? |
|        |        |         |       |            |           |            |            |       |         |      |
|  calcB |    Clr |     Clr |  1000 |         NA |        NA |         NA |         NA |     ? |       ? |    ? |
|  calcB |   Core |    Core |  1000 |   6.760 us | 0.1923 us |  0.3213 us |   6.734 us |     ? |       ? |    1 |
|  calcB | CoreRT |  CoreRT |  1000 |         NA |        NA |         NA |         NA |     ? |       ? |    ? |
|        |        |         |       |            |           |            |            |       |         |      |
|  **calcA** |    **Clr** |     **Clr** | **10000** |         **NA** |        **NA** |         **NA** |         **NA** |     **?** |       **?** |    **?** |
|  calcA |   Core |    Core | 10000 | 134.412 us | 3.6014 us | 10.6188 us | 132.440 us |     ? |       ? |    1 |
|  calcA | CoreRT |  CoreRT | 10000 |         NA |        NA |         NA |         NA |     ? |       ? |    ? |
|        |        |         |       |            |           |            |            |       |         |      |
|  calcB |    Clr |     Clr | 10000 |         NA |        NA |         NA |         NA |     ? |       ? |    ? |
|  calcB |   Core |    Core | 10000 |  71.862 us | 3.3425 us |  9.8555 us |  67.555 us |     ? |       ? |    1 |
|  calcB | CoreRT |  CoreRT | 10000 |         NA |        NA |         NA |         NA |     ? |       ? |    ? |

Benchmarks with issues:
  TestInlining.calcA: Clr(Runtime=Clr) [N=1000]
  TestInlining.calcA: CoreRT(Runtime=CoreRT) [N=1000]
  TestInlining.calcB: Clr(Runtime=Clr) [N=1000]
  TestInlining.calcB: CoreRT(Runtime=CoreRT) [N=1000]
  TestInlining.calcA: Clr(Runtime=Clr) [N=10000]
  TestInlining.calcA: CoreRT(Runtime=CoreRT) [N=10000]
  TestInlining.calcB: Clr(Runtime=Clr) [N=10000]
  TestInlining.calcB: CoreRT(Runtime=CoreRT) [N=10000]
