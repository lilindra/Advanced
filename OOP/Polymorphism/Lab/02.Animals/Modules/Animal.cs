namespace Animals
{
    public class Animal
    {
        private string name;

        private string favouriteFood;

        public string Name;

        public string FavouriteFood;

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
