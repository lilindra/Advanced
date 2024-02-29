using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc03.Telephony.Modules
{
    internal class StationaryPhone : ICallable
    {
        private string number;

        public StationaryPhone(string number)
        {
            this.number = number;
        }

        public string Call()
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            else if (number.Length == 7 && number.All(char.IsDigit))
            {
                return $"Dialing... {number}";
            }

            return "Invalid number!";
        }
    }

}
