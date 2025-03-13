namespace Tania
{
    public class SqlClient : IDatabaseClient
    {
        public void Connect(string connectionString)
        {
            System.Console.WriteLine("I am connected.");
        }

        public string[] GetMany(string entityName, int top = 10)
        {
            return ["Masha","Katya"];
        }

        public string GetOne(string entityName)
        {
           return "Masha";
        }

        public void Insert(string entityName, string value)
        {
            throw new NotImplementedException();
        }
    }
}