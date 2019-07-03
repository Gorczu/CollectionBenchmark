using BenchmarkDotNet.Attributes;

namespace Collections_Benchmarks
{
    [ClrJob (baseline: true), CoreJob, CoreRtJob]
    [RPlotExporter, RankColumn]
    public class TestConcurrency
    {
        [Params (1000, 10000)]
        public int N;
        
    }
}