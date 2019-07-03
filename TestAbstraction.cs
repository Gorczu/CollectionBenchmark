using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using System.Linq;
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
        HashSet<DataStruct> set = null;
        DataStruct[] array = null;

        DataClass [] arrayObjects = null;

        ConcurrentQueue<DataStruct> concurrent = null;
        ImmutableList<DataStruct> structImmutableList;

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
            this.set = new HashSet<DataStruct>(this.array);
            this.structImmutableList = ImmutableList.Create<DataStruct> (structList.ToArray ());
            this.concurrent = new ConcurrentQueue<DataStruct> (structList);
            this.arrayObjects = structList.Select(t =>  new DataClass(){ A = t.A, B=t.B, C=t.A, D=t.D })
                                          .ToArray();
            
        }

        [Benchmark]
        public int Array_Bench ()
        {
            return ArrayCalculation (structList);
        }

        [Benchmark]
        public int Array_NoInlining_Bench ()
        {
            return ArrayNoInlineCalculation (arrayObjects);
        }

        [Benchmark]
        public int OneLinq_Bench ()
        {
            return structList.Sum(t => Calculate(t));
        }

        [Benchmark]
        public int List_Bench ()
        {
            return ListCalculation (structList);
        }

        [Benchmark]
        public int HashSet_Bench ()
        {
            return HashSetCalculation (this.set);
        }

        [Benchmark]
        public int ISet_Bench ()
        {
            return ISetCalculation (this.set);
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
                result += Calculate(item);
            }
            return result;
        }

        private int HashSetCalculation(HashSet<DataStruct> set)
        {
            int result = 0;
            foreach (var item in concurrent)
            {
                result += Calculate(item);
            }
            return result;
        }

        private int ISetCalculation(ISet<DataStruct> set)
        {
            int result = 0;
            foreach (var item in concurrent)
            {
                result += Calculate(item);
            }
            return result;
        }
        
        private int ConcurrentQueueCalculation (ConcurrentQueue<DataStruct> queue)
        {
            int result = 0;
            foreach (var item in queue)
            {
                result += Calculate(item);
            }
            return result;
        }

        private int ArrayCalculation (List<DataStruct> structCollection)
        {
            int result = 0;
            for (int idx = 0; idx < N; idx++)
            {
                var item = array[idx];
                result += Calculate(item);
            }
            return result;
        }

        private int IReadOnlyListCalculation (IReadOnlyList<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += Calculate(item);
            }
            return result;
        }

        private int ImmutableListCalculation (ImmutableList<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += Calculate(item);
            }
            return result;
        }

        private int IImmutableListCalculation (IImmutableList<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += Calculate(item);
            }
            return result;
        }

        private int ListCalculation (List<DataStruct> items)
        {
            int result = 0;
            foreach (var item in items)
            {
                result += Calculate(item);
            }
            return result;

        }

        private int ArrayNoInlineCalculation(DataClass[] arrayObjects)
        {
            int result = 0;
            for (int idx = 0; idx < N; idx++)
            {
                var item = arrayObjects[idx];
                result += CalculateFromObj(item);
            }
            return result;
        }

        private int CalculateFromObj(DataClass data)
        {
           return (data.A + data.B) - (data.C + data.D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int Calculate(DataStruct data)
        {
            return (data.A + data.B) - (data.C + data.D);
        }
    }
}