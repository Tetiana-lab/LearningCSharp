namespace Tania
{
    
    public class CUp
    {
        public static int totalCupsAmount = 0;
        string name;
        public CUp()
        {
            totalCupsAmount++;
        }

        public bool Equals(object other)
        {
            return this.name == ((CUp)other).name;
        }

        public static bool Equals(object one, object two)
        {
            return ((CUp)one).Equals((CUp)two);
        }
    }
}