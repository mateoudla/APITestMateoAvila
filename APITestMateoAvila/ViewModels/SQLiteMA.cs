using System.Collections.Generic;
using System.Threading.Tasks;
using APITestMateoAvila.Models;
using SQLite;

namespace APITestMateoAvila.ViewModels
{
    public class SQLiteMA
    {
        private SQLiteConnection _database;

        public SQLiteMA(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<UsersMA>();
        }

        public List<UsersMA> GetAll()
        {
            return _database.Table<UsersMA>().ToList();
        }

        public UsersMA Get(int id)
        {
            return _database.Table<UsersMA>().FirstOrDefault(t => t.Id == id);
        }

        public List<UsersMA> GetBurgers()
        {
            return _database.Table<UsersMA>().ToList();
        }

        public void Insert(UsersMA user)
        {
            _database.Insert(user);
        }

        public void Update(UsersMA user)
        {
            _database.Update(user);
        }

        public void Delete(UsersMA user)
        {
            _database.Delete(user);
        }
    }
}


