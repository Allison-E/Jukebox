using System;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            Song Mary = new Song("Mary had a little lamb")
            {
                Sequence = new Note[] {
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.G4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.G4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Crotchet }
                }
            };

            Song birthday = new Song("Happy birthday to you")
            {
                Sequence = new Note[] {
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.A3, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.B3, Length = NoteLength.Minim },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.A3, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Minim },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.G3, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.G4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.B3, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.A3, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.F4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.F4, Length = NoteLength.Quaver },
                new Note { Tone = SoundFrequency.E4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.D4, Length = NoteLength.Crotchet },
                new Note { Tone = SoundFrequency.C4, Length = NoteLength.Minim },
                }
            };

            Play(Mary);
            Play(birthday);
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
