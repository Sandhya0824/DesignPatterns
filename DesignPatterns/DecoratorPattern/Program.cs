namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBlackCoffee coffee = new NormalCoffee();
            Console.WriteLine($"Cost: ${coffee.GetCost()}, Description: {coffee.GetDescription()}");

            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"Cost: ${coffee.GetCost()}, Description: {coffee.GetDescription()}");

            IBlackCoffee coffee2 = new NormalCoffee();
            coffee2 = new SugarDecorator(coffee2);
            Console.WriteLine($"Cost: ${coffee2.GetCost()}, Description: {coffee2.GetDescription()}");
        }
    }
}