using Spotify.DAL;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class RoleService
    {
        public void Create(string type)
        {
            Role role = new Role();
            role.Type = type;
        
            using(AddDbContext dbContext = new AddDbContext())
            {
                dbContext.Roles.Add(role);
                dbContext.SaveChanges();
            }
        }

    }
}
