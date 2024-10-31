using System.Data;

namespace _31_10_24_practise.Models;
   public  class Hospital
    {
    public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }
    public void EndAppointment(int no)
    {
        Appointments.FindAll(x => x.No == no).ForEach(x =>
        {
            Console.WriteLine(x.EndTime);
        });
    }
    public Appointment GetAppointment(int no)
    {
        return Appointments.Find(x => x.No == no);

    }
    public List<Appointment> GetAllAppointments()
    { 
        return Appointments;
    }

    public List<Appointment> GetWeeklyAppointments() 
    {
        return Appointments.FindAll(x => (DateTime.Now.Day - x.EndTime.Day) < 8);
       
    }
    public List<Appointment> GetTodaysAppointments()
    {
        return Appointments.FindAll(x => (DateTime.Now.Date == x.StartTime.Date));

    }
    public List<Appointment> GetAllContinuingAppointments()
    {
        return Appointments.FindAll(x => x.StartTime <= DateTime.Now && x.EndTime >= DateTime.Now);
    }



}
