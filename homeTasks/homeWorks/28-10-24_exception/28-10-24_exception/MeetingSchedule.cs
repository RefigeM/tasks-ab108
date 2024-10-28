namespace _28_10_24_exception
{
    class MeetingSchedule
    {
        public Meeting[] Meetings { get; set; }

        public MeetingSchedule(Meeting[] meetings)
        {
            this.Meetings = meetings;
        }

        public void SetMeeting(DateTime fromDate, DateTime toDate, string fullName)
        {

            foreach (Meeting meeting in Meetings)
            {
                if (meeting != null)
                {
                    if ((meeting.FromDate <= toDate && fromDate <= meeting.ToDate && fromDate < toDate))
                    {
                        Console.WriteLine("Meeting var");
                        throw new ReservedDateIntervalException("Gosterilen tarix intervalında gorus artıq mövcuddur.");
                        break;
                    }
                    else if (fromDate.Date >= toDate.Date)
                    {
                        Console.WriteLine("yalnis interval");
                        throw new WrongDateIntervalException("Yalnis interval daxil edilib.");
                    }
                    else
                    {
                        Meeting[] newMeetings = new Meeting[Meetings.Length + 1];
                        for (int i = 0; i < Meetings.Length; i++)
                        {
                            newMeetings[i] = Meetings[i];
                            newMeetings[^1] = new Meeting(new DateTime(), new DateTime(), fullName);
                            Meetings = newMeetings;
                        }
                        Console.WriteLine("Yeni gorus teyin edildi.");




                    }
                }
            }


        }
    }
}