
/*
Peter=11;George=4
Bread=10;Milk=2;
Peter Bread
George Milk
George Milk
Peter Milk
END
 */
namespace _03._Shopping_Spree
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();

            List<Product> products = new List<Product>();

            try
            {
                string[] inputPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] inputProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (var personData in inputPeople)
                {
                    string[] personInfo = personData.Split('=');
                    string personName = personInfo[0];
                    int personMoney = int.Parse(personInfo[1]);
                    persons.Add(new Person(personName, personMoney));
                }

                foreach (var productData in inputProducts)
                {
                    string[] productInfo = productData.Split('=');
                    string productName = productInfo[0];
                    int productCost = int.Parse(productInfo[1]);
                    products.Add(new Product(productName, productCost));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split();
                string personName = input[0];
                string productName = input[1];

                Person person = persons.FirstOrDefault(x => x.Name == personName);
                Product product = products.FirstOrDefault(x => x.Name == productName);

                try
                {
                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                    }
                    else
                    {
                        Console.WriteLine("Invalid person or product.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                if (person.Bag.Any())
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(p => p.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}