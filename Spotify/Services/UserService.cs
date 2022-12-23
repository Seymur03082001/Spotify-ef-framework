using Spotify.DAL;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class UserService
    {
        public void Create(string name,string surname,string username, string password,string gender)
        {
            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.Username = username;
            user.Password = password;
            user.Gender = gender;

            using(AddDbContext dbContext =new AddDbContext())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }
    }
}
