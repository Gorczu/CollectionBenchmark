``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2437705 Hz, Resolution=410.2219 ns, Timer=TSC
.NET Core SDK=3.0.100-preview-009812
  [Host] : .NET Core 3.0.0-preview-27122-01 (CoreCLR 4.6.27121.03, CoreFX 4.7.18.57103), 64bit RyuJIT
  Core   : .NET Core 3.0.0-preview-27122-01 (CoreCLR 4.6.27121.03, CoreFX 4.7.18.57103), 64bit RyuJIT


```
|                   Method |    Job | Runtime |     N |       Mean |      Error |     StdDev |     Median | Ratio | RatioSD | Rank |
|------------------------- |------- |-------- |------ |-----------:|-----------:|-----------:|-----------:|------:|--------:|-----:|
|              **Array_Bench** |    **Clr** |     **Clr** |  **1000** |         **NA** |         **NA** |         **NA** |         **NA** |     **?** |       **?** |    **?** |
|              Array_Bench |   Core |    Core |  1000 |   2.243 us |  0.0632 us |  0.1865 us |   2.230 us |     ? |       ? |    1 |
|              Array_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|   Array_NoInlining_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|   Array_NoInlining_Bench |   Core |    Core |  1000 |   2.606 us |  0.0513 us |  0.0611 us |   2.594 us |     ? |       ? |    1 |
|   Array_NoInlining_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|            OneLinq_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|            OneLinq_Bench |   Core |    Core |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|            OneLinq_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|               List_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|               List_Bench |   Core |    Core |  1000 |   4.822 us |  0.2133 us |  0.6289 us |   4.564 us |     ? |       ? |    1 |
|               List_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|              IList_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|              IList_Bench |   Core |    Core |  1000 |   9.172 us |  0.1805 us |  0.4112 us |   9.050 us |     ? |       ? |    1 |
|              IList_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|              Queue_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|              Queue_Bench |   Core |    Core |  1000 |   6.841 us |  0.3381 us |  0.9970 us |   7.184 us |     ? |       ? |    1 |
|              Queue_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|        ICollection_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|        ICollection_Bench |   Core |    Core |  1000 |  16.329 us |  0.5283 us |  1.5072 us |  15.944 us |     ? |       ? |    1 |
|        ICollection_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|            HashSet_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|            HashSet_Bench |   Core |    Core |  1000 |  12.644 us |  0.2192 us |  0.1943 us |  12.679 us |     ? |       ? |    1 |
|            HashSet_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|               ISet_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|               ISet_Bench |   Core |    Core |  1000 |  12.179 us |  0.2377 us |  0.3006 us |  12.227 us |     ? |       ? |    1 |
|               ISet_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|      IReadOnlyList_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|      IReadOnlyList_Bench |   Core |    Core |  1000 |   9.683 us |  0.2886 us |  0.8235 us |   9.416 us |     ? |       ? |    1 |
|      IReadOnlyList_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|          Immutable_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|          Immutable_Bench |   Core |    Core |  1000 |  75.939 us |  1.7229 us |  2.4153 us |  74.993 us |     ? |       ? |    1 |
|          Immutable_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
| ImmutableInterface_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
| ImmutableInterface_Bench |   Core |    Core |  1000 |  87.071 us |  1.7410 us |  4.2708 us |  85.939 us |     ? |       ? |    1 |
| ImmutableInterface_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|    ConcurrentQueue_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|    ConcurrentQueue_Bench |   Core |    Core |  1000 |  13.482 us |  0.4575 us |  1.3199 us |  13.191 us |     ? |       ? |    1 |
|    ConcurrentQueue_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|           ProdCons_Bench |    Clr |     Clr |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|           ProdCons_Bench |   Core |    Core |  1000 |  12.255 us |  0.2412 us |  0.2962 us |  12.176 us |     ? |       ? |    1 |
|           ProdCons_Bench | CoreRT |  CoreRT |  1000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|              **Array_Bench** |    **Clr** |     **Clr** | **10000** |         **NA** |         **NA** |         **NA** |         **NA** |     **?** |       **?** |    **?** |
|              Array_Bench |   Core |    Core | 10000 |  21.745 us |  0.8839 us |  2.5361 us |  20.869 us |     ? |       ? |    1 |
|              Array_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|   Array_NoInlining_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|   Array_NoInlining_Bench |   Core |    Core | 10000 |  27.375 us |  0.6854 us |  1.9992 us |  26.839 us |     ? |       ? |    1 |
|   Array_NoInlining_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|            OneLinq_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|            OneLinq_Bench |   Core |    Core | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|            OneLinq_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|               List_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|               List_Bench |   Core |    Core | 10000 |  48.828 us |  1.3085 us |  3.7120 us |  48.340 us |     ? |       ? |    1 |
|               List_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|              IList_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|              IList_Bench |   Core |    Core | 10000 |  99.111 us |  3.3646 us |  9.7613 us |  96.564 us |     ? |       ? |    1 |
|              IList_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|              Queue_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|              Queue_Bench |   Core |    Core | 10000 |  60.461 us |  1.2584 us |  3.4660 us |  59.717 us |     ? |       ? |    1 |
|              Queue_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|        ICollection_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|        ICollection_Bench |   Core |    Core | 10000 | 162.593 us |  3.7201 us | 10.5532 us | 161.496 us |     ? |       ? |    1 |
|        ICollection_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|            HashSet_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|            HashSet_Bench |   Core |    Core | 10000 | 124.799 us |  2.4744 us |  5.0545 us | 125.239 us |     ? |       ? |    1 |
|            HashSet_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|               ISet_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|               ISet_Bench |   Core |    Core | 10000 | 123.999 us |  2.4662 us |  6.7511 us | 121.941 us |     ? |       ? |    1 |
|               ISet_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|      IReadOnlyList_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|      IReadOnlyList_Bench |   Core |    Core | 10000 |  89.339 us |  1.7649 us |  2.2320 us |  89.952 us |     ? |       ? |    1 |
|      IReadOnlyList_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|          Immutable_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|          Immutable_Bench |   Core |    Core | 10000 | 755.086 us | 14.2619 us | 16.9777 us | 752.604 us |     ? |       ? |    1 |
|          Immutable_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
| ImmutableInterface_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
| ImmutableInterface_Bench |   Core |    Core | 10000 | 796.312 us | 15.8455 us | 16.9545 us | 791.655 us |     ? |       ? |    1 |
| ImmutableInterface_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|    ConcurrentQueue_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|    ConcurrentQueue_Bench |   Core |    Core | 10000 | 123.041 us |  2.8235 us |  5.6389 us | 121.700 us |     ? |       ? |    1 |
|    ConcurrentQueue_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|                          |        |         |       |            |            |            |            |       |         |      |
|           ProdCons_Bench |    Clr |     Clr | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |
|           ProdCons_Bench |   Core |    Core | 10000 | 120.933 us |  2.4047 us |  2.8627 us | 120.776 us |     ? |       ? |    1 |
|           ProdCons_Bench | CoreRT |  CoreRT | 10000 |         NA |         NA |         NA |         NA |     ? |       ? |    ? |

Benchmarks with issues:
  TestAbstraction.Array_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.Array_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.Array_NoInlining_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.Array_NoInlining_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.OneLinq_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.OneLinq_Bench: Core(Runtime=Core) [N=1000]
  TestAbstraction.OneLinq_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.List_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.List_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.IList_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.IList_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.Queue_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.Queue_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.ICollection_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.ICollection_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.HashSet_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.HashSet_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.ISet_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.ISet_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.IReadOnlyList_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.IReadOnlyList_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.Immutable_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.Immutable_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.ImmutableInterface_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.ImmutableInterface_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.ConcurrentQueue_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.ConcurrentQueue_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.ProdCons_Bench: Clr(Runtime=Clr) [N=1000]
  TestAbstraction.ProdCons_Bench: CoreRT(Runtime=CoreRT) [N=1000]
  TestAbstraction.Array_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.Array_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.Array_NoInlining_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.Array_NoInlining_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.OneLinq_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.OneLinq_Bench: Core(Runtime=Core) [N=10000]
  TestAbstraction.OneLinq_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.List_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.List_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.IList_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.IList_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.Queue_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.Queue_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.ICollection_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.ICollection_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.HashSet_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.HashSet_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.ISet_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.ISet_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.IReadOnlyList_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.IReadOnlyList_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.Immutable_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.Immutable_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.ImmutableInterface_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.ImmutableInterface_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.ConcurrentQueue_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.ConcurrentQueue_Bench: CoreRT(Runtime=CoreRT) [N=10000]
  TestAbstraction.ProdCons_Bench: Clr(Runtime=Clr) [N=10000]
  TestAbstraction.ProdCons_Bench: CoreRT(Runtime=CoreRT) [N=10000]
