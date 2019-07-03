using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

using BenchmarkDotNet.Attributes;

using Collections.Benchmarks;

namespace Collections_Benchmarks
{

    [ClrJob (baseline: true), CoreJob, CoreRtJob]
    [RPlotExporter, RankColumn]
    public class TestAbstraction
    {
        [Params (1000, 10000)]
        public int N;
        List<DataStruct> structList = new List<DataStruct> ();
        LinkedList<DataStruct> linkedList = new LinkedList<DataStruct> ();
        HashSet<DataStruct> set = new HashSet<DataStruct> ();
        DataStruct[] array = null;
        ConcurrentQueue<DataStruct> concurrent = null;
        private ImmutableList<DataStruct> structImmutableList;

        [GlobalSetup]
        public void Setup ()
        {
            Random rn = new Random ();
            for (int i = 0; i < N; i++)
            {
                structList.Add (new DataStruct ()
                {
                    A = rn.Next (),
                        B = rn.Next (),
                        C = rn.Next (),
                        D = rn.Next ()
                });
            }
            this.array = structList.ToArray ();
            this.structImmutableList = ImmutableList.Create<DataStruct> (structList.ToArray ());
            this.concurrent = new ConcurrentQueue<DataStruct> (structList);
        }

        [Benchmark]
        public int IReadOnlyList_Bench ()
        {
            return IReadOnlyListCalculation (structList);
        }

        [Benchmark]
        public int Immutable_Bench ()
        {
            return ImmutableListCalculation (structImmutableList);
        }

        [Benchmark]
        public int ImmutableInterface_Bench ()
        {
            return IImmutableListCalculation (structImmutableList);
        }

        [Benchmark]
        public int List_Bench ()
        {
            return ListCalculation (structList);
        }

        [Benchmark]
        public int Array_Bench ()
        {
            return ArrayCalculation (structList);
        }

        [Benchmark]
        public int ConcurrentQueue_Bench ()
        {
            return ConcurrentQueueCalculation (concurrent);
        }

        [Benchmark]
        public int ProdCons_Bench ()
        {
            return ProdConsCalculation (concurrent);
        }

        private int ProdConsCalculation (IProducerConsumerCollection<DataStruct> concurrent)
        {
            int result = 0;
            foreach (var item in concurrent)
            {
                result += item.A + item.B / item.C + item.D;
            }
            return result;
        }

        private int ConcurrentQueueCalculation (ConcurrentQueue<DataStruct> queue)
        {
            int result = 0;
            foreach (var item in queue)
            {
                result += item.A + item.B / item.C + item.D;
            }
            return result;
        }

        private int ArrayCalculation (List<DataStruct> structCollection)
        {
            int result = 0;
            for (int idx = 0; idx < N; idx++)
            {
                var item = array[idx];
                result += item.A + item.B / item.C + item.D;
            }
            return result;
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

        int IImmutableListCalculation (IImmutableList<DataStruct> items)
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