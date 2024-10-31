using _31_10_24_practise.Models;
using _31_10_24_practise.Models.Extensions;

namespace _31_10_24_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();

            Appointment appointment1 = new Appointment(1, "Refiqe", "dr. Ayxan", new DateTime(2024, 10, 31, 9, 0, 0), new DateTime(2024, 10, 31, 11, 0, 0));
            Appointment appointment2 = new Appointment(2, "Aygun", "dr. Ayxan", new DateTime(2024, 10, 31, 9, 0, 0), new DateTime(2024, 10, 1, 11, 50, 0));
            Appointment appointment3 = new Appointment(3, "Nurlan", "dr. Ayxan", new DateTime(2024, 10, 31, 9, 0, 0), new DateTime(2024, 11, 5, 13, 0, 0));
            Appointment appointment4 = new Appointment(4, "Ali", "dr. Ayxan", new DateTime(2024, 10, 31, 9, 0, 0), new DateTime(2025, 10, 1, 17, 0, 0));

            hospital.AddAppointment(appointment1);
            hospital.AddAppointment(appointment2);
            hospital.AddAppointment(appointment3);
            hospital.AddAppointment(appointment4);


            int click = int.Parse(Console.ReadLine());
            switch (click)
            {
                case 1:
                    hospital.AddAppointment(appointment1);
                    Console.WriteLine($"Appointment yarat.");
                    Console.ReadLine(); //pencerenin tez  baglanmasinin qarsini almaq ucun yazmisam
                    break;
                case 2:
                    hospital.EndAppointment(1);

                    Console.WriteLine($"Appointment bitdi.");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Butun appointmentler:");
                    hospital.GetAllAppointments().PrintAppointments();
                    //Console.WriteLine(hospital.GetAllAppointments());
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Bu hefteki appointmentler: ");
                    hospital.GetWeeklyAppointments().PrintAppointments();
                    //hospital.GetWeeklyAppointments().PrintAppointments();
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Bu gunki appointmentler: ");
                    hospital.GetTodaysAppointments().PrintAppointments();
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Bitmemis appointmentler: ");
                    Console.WriteLine();
                    hospital.GetAllContinuingAppointments().PrintAppointments();
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Menyudan cixildi...");
                    break;

                default:
                    Console.WriteLine("Duzgun code daxil edilmedi!\n");
                    Console.WriteLine(" 1-Appointment yarat\n 2-Appointment-i bitir\n 3-Bütün appointmentlere bax\n 4-Bu hefteki appointmentlere bax\n 5-Bugünki appointmentlere bax\n 6-Bitmemiş appointmentlere bax\n 7- Menudan çıx\n");
                    Console.ReadLine();

                    break;

            }

        }
    }
}