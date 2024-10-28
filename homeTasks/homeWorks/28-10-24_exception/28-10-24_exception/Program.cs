namespace _28_10_24_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting(new DateTime(2024, 10, 14), new DateTime(2024, 10, 20), "Refiqe Mirzezade");
            Meeting meeting2 = new Meeting(new DateTime(2024, 10, 8), new DateTime(2024, 10, 22), "Aysel Aliyeva");
            Meeting meeting3 = new Meeting(new DateTime(2024, 11, 1), new DateTime(2024, 11, 6), "Eli Qasimov");


            Meeting[] Meeting = { meeting1 };
            MeetingSchedule meetingSchedule1 = new MeetingSchedule(Meeting);

            try
            {
                meetingSchedule1.SetMeeting(new DateTime(2024, 10, 13), new DateTime(2024, 10, 22), "Ferid Qurbanov");
            }
            catch (ReservedDateIntervalException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongDateIntervalException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
