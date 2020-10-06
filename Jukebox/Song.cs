namespace Jukebox
{
    public class Song
    {
        public string Title { get; private set; }
        public Note[] Sequence { get; set; }

        public Song(string title)
        {
            Title = title;
        }
    }
}
