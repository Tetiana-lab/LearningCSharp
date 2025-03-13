namespace Tania
{
  
    public interface IDatabaseClient
    {
        public void Connect(string connectionString);
        public string GetOne(string entityName);
        public string[] GetMany(string entityName, int top =10);
        public void Insert(string entityName, string value);
    }
}