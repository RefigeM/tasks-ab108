namespace hometask
{
    internal class Singer
    {
        public string _singerName;
        public string SingerName {
            get { return _singerName; }
            set { if (value.Length < 0 || value.Length > 100) return;
                SingerName = value;
            }
        }
        public string _singerSurname;
        public string SingerSurname
        {
            get { return _singerSurname; }
            set
            {
                if (value.Length < 0 || value.Length > 100) return;
                SingerSurname = value;
            }
        }
        public int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value<0 || value>170) return;
                Age = value;
            }
        }
        public Singer(string _singerName, string _brandName, double _price)
        {
            Singerame = _singerName;
            SingerSurname = _brandName;
            Age = _age;

        }

    }
}
