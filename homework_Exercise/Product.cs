using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQPad;
using System.Linq.Dynamic;

namespace homework_Exercise
{
    public static class Product
    {
        /// <summary>
        /// https://msdn.microsoft.com/zh-tw/library/cc981895(v=vs.110).aspx
        /// </summary>

        public static IEnumerable<int> GroupSum(this IEnumerable<ProductModel> ProductModel, int GroupCount, string column)
        {
            int AllCount = ProductModel.Count();
            if (AllCount == 0) 
                throw new InvalidOperationException("Cannot compute median for an empty set.");

            var sortedList = ProductModel.Select(column);

            int cont = 0;            
            while (cont < AllCount)
            {
                int value = 0;
                var results1 = sortedList.Skip(cont).Take(GroupCount);
                foreach (int v in results1) value += v;
                cont += GroupCount;
                yield return value;
            }
        }
    }

    public class ProductModel
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
