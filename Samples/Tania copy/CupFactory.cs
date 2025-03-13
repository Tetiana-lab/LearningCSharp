namespace Tania
{
    public class CupFactory
    {
        public static int cupAmount = 0;
        public CUp GetCup()
        {
            cupAmount++;
            return new CUp();
        }
    }
}