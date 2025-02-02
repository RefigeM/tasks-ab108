﻿using System;
using System.Collections.Generic;

public class Appointment
    {
    public int No { get; set; }
    //public Patient Patient { get; set; }
    //public Doctor Doctor { get; set; }
    public string Patient { get; set; }
    public string Doctor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Appointment(int no, string patient, string doctor, DateTime startTime, DateTime endTime)
    {
        No = no;    
        Patient = patient;
        Doctor = doctor;
        StartDate = startTime;
        EndDate = endTime;
    }
}
