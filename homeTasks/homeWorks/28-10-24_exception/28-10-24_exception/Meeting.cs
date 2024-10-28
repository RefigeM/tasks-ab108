namespace _28_10_24_exception
{
    class Meeting
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FullName { get; set; }

        public Meeting(DateTime FromDate, DateTime toDate, string fullName)
        {
            FromDate = FromDate;
            ToDate = toDate;
            FullName = fullName;

        }
    }
}
