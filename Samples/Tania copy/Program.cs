
using Tania;
using Tania.Extensions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new CupFactory();
            var factory2 = new CupFactory();
            factory.GetCup();
            factory.GetCup();
            factory.GetCup();
            factory.GetCup();
            factory.GetCup();
            factory.GetCup();
            factory2.GetCup();
            factory2.GetCup();
            factory2.GetCup();
            factory2.GetCup();
            factory2.GetCup();
            System.Console.WriteLine(CupFactory.cupAmount);

            var test = new CUp();
            System.Console.WriteLine(CUp.totalCupsAmount);

            var user = new User();
            user.Name = "Jack";
            user.LastName = "Jonson";
            user.GextFullName();

            var result = "Hello, my name is Tanya".ToCrAzYcAsE();
        }
    }
}