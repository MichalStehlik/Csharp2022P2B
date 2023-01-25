using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc07Delegates
{
    internal static class MyExtensions
    {
        public static List<T> Selection<T>(this List<T> source, int from, int to)
        {
            int lo = from;
            int hi = to;
            if (from > to)
            {
                hi = from;
                lo = to;
            }
            if (hi > source.Count - 1)
            {
                hi = source.Count - 1;
            }
            List<T> result = new List<T>();
            for (int i = lo; i <= hi; i++)
            {
                result.Add(source[i]);
            }
            return result;
        }

        public static List<string> Contains(this List<string> source, string txt)
        {
            List<string> result = new List<string>();
            foreach(var x in source)
            {
                if (x.Contains(txt)) result.Add(x);
            }
            return result;
        }
    }
}
