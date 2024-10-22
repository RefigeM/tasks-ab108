namespace hometask
{
    internal class Song:Singer
    {
        public string _songName;
        public string SongName
        {
            get { return _songName; }
            set
            {
                if (value.Length < 0 || value.Length > 100) return;
                _songName = value;
            }
        }
        public string _genre;
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (value== "Pop" || value == "Rock"|| value== "Jazz" || value == "Techno"|| value == "pop" || value == "rock" || value == "jazz" || value == "techno") _genre = value;
                return;
            }
        }
        public Song(string _songName, string _genre, string _singerName)
        {
            this.SongName = _songName;
            this.Genre = _genre;
            this.SingerName = _singerName;
        }
       


    }
}
