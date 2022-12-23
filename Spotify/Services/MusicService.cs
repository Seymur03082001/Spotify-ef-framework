using Spotify.DAL;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class MusicService
    {
        public void Create(string name, TimeSpan Duration)
        {
            Music music = new Music();
            music.Name = name;
            music.Duration = Duration;

            using (AddDbContext dbContext = new AddDbContext())
            {
                dbContext.Musics.Add(music);
                dbContext.SaveChanges();
            }
        }
    }
}
