
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parrot1 = new ParrotDomesticated("unbreakable", "white", Genders.male, 29, "Chirik", "Kesha");
         
            parrot1.Introduce();
            parrot1.LearnToSpeak();
            parrot1.Introduce();
        }
    }
}