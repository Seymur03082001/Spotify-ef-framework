using Spotify.DAL;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class CategoryService
    {
        public void Create(string name)
        {
            Category category = new Category();
            category.Name = name;
            
            using(AddDbContext dbContext= new AddDbContext())
            {
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
            }
        }
    }
}
