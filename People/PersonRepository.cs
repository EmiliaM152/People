using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PeopleEM.Models;



namespace People
{
    public class PersonRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<PeopleEM>();
        }

        public PersonRepository(string dbPath)
        {
            _dbPath = dbPath;                        
        }

        public void AddNewPerson(string name)
        {            
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                // TODO: Insert the new person into the database
                result = 0;
                result = conn.Insert(new PeopleEM {Name = name });

                //StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public List<PeopleEM> GetAllPeople()
        {
            // TODO: Init then retrieve a list of Person objects from the database into a list
            try
            {
                Init();
                return conn.Table<PeopleEM>().ToList();

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<PeopleEM>();
        }
    }

}
