using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_evaluation
{
    [MemoryDiagnoser]
    public class ListBenchmark
    {
        [Benchmark]
        public void testObject()
        {
            var obj = new List<object>();
            for (int i = 0; i < 10000; i++)
            {
                obj.Add(i);
            }
            
        }
        [Benchmark]
        public void testList()
        {
            var lst = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                lst.Add(i);
            }
            int data = 0;
            foreach (var item in lst)
            {
                data = item;
            }
        }
    }
}
