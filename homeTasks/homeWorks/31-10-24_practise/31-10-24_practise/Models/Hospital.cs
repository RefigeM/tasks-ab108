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
            Console.WriteLine(x.EndDate);
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
        return Appointments.FindAll(x => (x.StartDate.Day - x.EndDate.Day) >=7);
       
    }
    public List<Appointment> GetTodaysAppointments()
    {
       var appointment = Appointments.FindAll(x => (DateTime.Now.Date == x.StartDate.Date));
        if (appointment.Count>0) return appointment;
        else {
            Console.WriteLine("Bu gun ucun appointment yoxdur");
        }
        return appointment;
    }
    public List<Appointment> GetAllContinuingAppointments()
    {
        return Appointments.FindAll(x => x.StartDate <= DateTime.Now && x.EndDate >= DateTime.Now);
    }



}
