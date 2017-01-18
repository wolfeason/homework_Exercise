using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LINQPad;
//using System.Linq.Dynamic;

namespace homework_Exercise
{
    public static class Product
    {
        /// <summary>
        /// https://msdn.microsoft.com/zh-tw/library/cc981895(v=vs.110).aspx
        /// </summary>

        public static IEnumerable<int> GroupSum<T>(this IEnumerable<T> products, int mete, Func<T, int> column)
        {
            int TotalCount = products.Count();
            if (TotalCount == 0)
                throw new InvalidOperationException("Cannot compute median for an empty set."); 

            var temp = products.Select(column);

            int counter = 0;
            while (counter < TotalCount)
            {
                int value = 0;
                var results1 = temp.Skip(counter).Take(mete);
                foreach (int v in results1) value += v;
                counter += mete;
                yield return value;
            }
        }
    }

    public class ProductItem
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
