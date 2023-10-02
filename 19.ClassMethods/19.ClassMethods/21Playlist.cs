using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ClassMethods
{
    public class Playlist
    {
        public List<string> PlaylistLib { get; set; } = new List<string>();
        public void AddSong(string song)
        {
            PlaylistLib.Add(song);
        }
        public void RemoveSong(string song)
        {
            PlaylistLib.Remove(song);
        }
        public void PrintPlaylist(List<string> Playlist)
        {
            int count = 1;
            foreach (var song in Playlist)
            {
                Console.WriteLine($"{count}.{song}");
                count++;
            }
        }
    }
   
}
