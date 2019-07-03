using System;

using BenchmarkDotNet.Running;
using Collections_Benchmarks;

namespace Collections.Benchmarks
{
    class Program
    {
        static void Main (string[] args)
        {
            var summary = BenchmarkRunner.Run<TestAbstraction> ();
        }
    }

   
}