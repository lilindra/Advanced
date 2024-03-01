/*
0882134215 0882134333 0899213421 0558123 3333123
http://softuni.bg http://youtube.com http://www.g00gle.com
 */

using Exc03.Telephony.Modules;

namespace Exc03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                ICallable phone;
                if (phoneNumber.Length == 10)
                {
                    phone = new Smartphone(phoneNumber);
                }
                else if (phoneNumber.Length == 7)
                {
                    phone = new StationaryPhone(phoneNumber);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                Console.WriteLine(phone.Call());
            }

            foreach (var website in websites)
            {
                Smartphone smartphone = new Smartphone(website);
                if (smartphone is IBrowseable)
                {
                    Console.WriteLine(smartphone.Browse());
                }
            }
        }
    }
}