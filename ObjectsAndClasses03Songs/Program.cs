namespace ObjectsAndClasses03Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numbersOfSong; i++)
            {
                string[] songTokens = Console.ReadLine()
                    .Split("_");

                string type = songTokens[0];
                string songName = songTokens[1];
                string songTime = songTokens[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = songName;
                song.Time = songTime;
                songs.Add(song);
            }
            string listType = Console.ReadLine();

            if (listType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song in songs)
                {
                    if (song.TypeList == listType)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            
        }
    }
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
