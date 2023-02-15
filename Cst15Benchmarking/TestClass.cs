using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst15Benchmarking
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net50)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class TestClass
    {
        [Benchmark(Baseline = true)]
        public string GetFullStringNormally()
        {
            string output = "";
            for (int i = 0; i < 100; i++)
            {
                output += i + " ";
            }
            return output;
        }

        [Benchmark]
        public string GetFullStringUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i + " ");
            }
            return sb.ToString();
        }
    }
}
