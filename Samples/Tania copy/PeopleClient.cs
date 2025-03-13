using System.ComponentModel.DataAnnotations.Schema;

namespace Tania
{
    public class PeopleClient
    {
        IDatabaseClient database;
        public PeopleClient(IDatabaseClient database, string connString)
        {
            this.database = database;
            database.Connect(connString);
        }

        public string[] GetPeople()
        {
            return database.GetMany("people");
        }

        public string GetPerson()
        {
            return database.GetOne("people");
        }
    }
}