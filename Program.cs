using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Collections.Benchmarks
{
    class Program
    {
        static void Main (string[] args)
        {
            var summary = BenchmarkRunner.Run<TestCollections> ();
        }
    }

    [ClrJob (baseline: true), CoreJob, CoreRtJob]
    [RPlotExporter, RankColumn]
    public class TestCollections
    {
        [Params (1000, 10000)]
        public int N;
        List<DataStruct> structCollection = new List<DataStruct> ();
        List<DataClass> objectCollection = new List<DataClass> ();
        private ImmutableList<DataStruct> structImmutableList;

        [GlobalSetup]
        public void Setup ()
        {
            Random rn = new Random ();
            for (int i = 0; i < N; i++)
            {
                structCollection.Add (new DataStruct ()
                {
                    A = rn.Next (),
                    B = rn.Next (),
                    C = rn.Next (),
                    D = rn.Next ()
                });

                objectCollection.Add (new DataClass ()
                {
                    A = rn.Next (),
                    B = rn.Next (),
                    C = rn.Next (),
                    D = rn.Next ()
                });
            }
            
            this.structImmutableList = ImmutableList.Create<DataStruct>(structCollection.ToArray());
        }

        [Benchmark]
        public int IReadOnlyList_Bench ()
        {
            return IReadOnlyListCalculation (structCollection);
        }

        [Benchmark]
        public int Immutable_Bench ()
        {
            return ImmutableListCalculation (structImmutableList);
        }

        [Benchmark]
        public int List_Bench ()
        {
            return ListCalculation (structCollection);
        }

        int IReadOnlyListCalculation (IReadOnlyList<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += item.A + item.B / item.C + item.D;
            }
            return result;
        }

        int ImmutableListCalculation (ImmutableList<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += item.A + item.B / item.C + item.D;
            }
            return result;
        }

        int ListCalculation (List<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += item.A + item.B / item.C + item.D;
            }
            return result;
        }
    }
}