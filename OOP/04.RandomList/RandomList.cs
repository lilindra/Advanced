using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            if (this.Count > 0)
            {
                int randomIndex = random.Next(0, this.Count);
                string randomElement = this[randomIndex];
                this.RemoveAt(randomIndex);
                return randomElement;
            }
            else
            {
                return null;
            }
        }
    }
}
