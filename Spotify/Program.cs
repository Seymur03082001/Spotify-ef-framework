using Spotify.Services;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArtistService artistService = new ArtistService();
           MusicService musicService = new MusicService();
            UserService userService = new UserService();
            RoleService roleService = new RoleService();
            CategoryService categoryService = new CategoryService();
        }
    }
}