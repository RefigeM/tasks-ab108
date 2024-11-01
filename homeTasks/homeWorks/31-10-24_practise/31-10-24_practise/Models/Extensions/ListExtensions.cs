using System;
using System.Collections.Generic;
using _31_10_24_practise.Models;

namespace _31_10_24_practise.Models.Extensions
{
    public static class ListExtensions
    {
        public static void PrintAppointments(this List<Appointment> appointments)
        {
            foreach (var item in appointments)
            {
                Console.WriteLine($"appointment no:{item.No},{item.Patient},{item.Doctor},{item.StartDate}, {item.EndDate}");
            }
        }
    }
}
