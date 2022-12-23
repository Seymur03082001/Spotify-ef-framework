using Spotify.DAL;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class ArtistService
    {
        public void Create(string name,string surname,string gender,DateTime birthday)
        {
            Artist artist= new Artist();
            artist.Name = name;
            artist.Surname = surname;
            artist.Birtday= birthday;
            artist.Gender = gender;

            using(AddDbContext dbContext = new AddDbContext())
                {
                dbContext.Artists.Add(artist);
                dbContext.SaveChanges();
                }
        }
    }
}
