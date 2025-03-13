using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tania
{
    public class MongoClient: IDatabaseClient
    {
        public void Connect(string connectionString)
        {
            System.Console.WriteLine("I am connected.");
        }

        public string[] GetMany(string entityName, int top = 10)
        {
            return ["Ira","Vasya"];
        }

        public string GetOne(string entityName)
        {
           return "Petya";
        }

        public void Insert(string entityName, string value)
        {
            throw new NotImplementedException();
        }
    }
}