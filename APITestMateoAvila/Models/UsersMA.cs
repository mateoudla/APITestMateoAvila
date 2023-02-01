using System;
using SQLite;

namespace APITestMateoAvila.Models
{

    public class UsersMA
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
    }

}

