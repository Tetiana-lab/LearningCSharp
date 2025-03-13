namespace Tania
{
    public class TheBird : DomesticatedBird
    {
        public TheBird(string breed, string color, Genders gender, int ageMonth, string name) : base(breed, color, gender, ageMonth, name)
        {
        }

        public override void DoNoise()
        {
            System.Console.WriteLine("abyr");
        }
    }
}