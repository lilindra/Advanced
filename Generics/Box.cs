using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box<T>
        where T : IComparable
    {
         public List<T> Items {  get; set; }

        public Box()
        {
            this.Items = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }

        public void Swap(int firstIndex, int secondIndex)
        =>
            (Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex]);

        public int ComparedToo(T itemToCompare)
        {
            int counter = 0;

            foreach (var item in Items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
