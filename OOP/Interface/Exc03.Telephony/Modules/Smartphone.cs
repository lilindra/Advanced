using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc03.Telephony.Modules
{
    public class Smartphone : ICallable, IBrowsable
    {
        private string input;

        public Smartphone(string number)
        {
            this.input = number;
        }
        public string Call()
        {
            if (!input.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            else if (input.Length == 10 && input.All(char.IsDigit))
            {
                return $"Calling... {input}";
            }

            return "Invalid number!";
        }

        public string Browse()
        {
            if (input.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {input}!";
        }
    }
}
