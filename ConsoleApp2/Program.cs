using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace TryCatchBenchmarking
{
    [SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [RPlotExporter]
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Calculator>();

            Console.ReadLine();
        }

    }
}
