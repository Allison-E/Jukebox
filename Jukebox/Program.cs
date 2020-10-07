using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            Task readSongsAsync = Task.Run(() =>
            {
                string path = Environment.CurrentDirectory + @"\Songs.json";
                JsonSerializer serialiser = new JsonSerializer();

                using (StreamReader stream = new StreamReader(path))
                using (JsonReader reader = new JsonTextReader(stream))
                {
                    songs = serialiser.Deserialize<List<Song>>(reader);
                }
            });

            Console.Title = "Console Jukebox";
            Console.WriteLine("Welcome to my Console Jukebox");
            Console.WriteLine("Loading songs...");

            Task.WaitAll(readSongsAsync);
            if (readSongsAsync.IsCompleted)
            {
                ConsoleColor DEFAULT = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Done Loading");
                Console.ForegroundColor = DEFAULT;
            }
                        
            foreach (Song song in songs)
            {
                Play(song);
            }
        }

        static void Play(Song song)
        {
            Console.WriteLine($"Now playing: {song.Title}\r\n");
            foreach (var note in song.Sequence)
            {
                Debug.WriteLine($"{note.Tone}: {note.Length}");
                Console.Beep((int)note.Tone, 2000 / (int)note.Length);
            }
            Thread.Sleep(1000);
        }
    }
}
