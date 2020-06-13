using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;

namespace TryCatchBenchmarking
{

	[SimpleJob(RuntimeMoniker.NetCoreApp30)]
	[RPlotExporter]
	public class Calculator
    {

		[Benchmark]
		[BenchmarkCategory("Run")]
		public double GetDivision() => Division();

		[Benchmark]
		[BenchmarkCategory("Run")]
		public double GetDivisionDivisionException() => DivisionException();

		[Params(0, 1, 2, 3)]
		public int number1 { get; set; }

		[Params(0, 1, 2, 3)]
		public int number2 { get; set; }

		public double Division()
		{
			if (number2 == 0) return double.NaN;
			
			return number1 / number2;
		}

		public double DivisionException()
        {
			try
			{
				return number1 / number2;
			}
			catch (Exception)
			{

				return double.NaN;
			}
        }
    }
}
