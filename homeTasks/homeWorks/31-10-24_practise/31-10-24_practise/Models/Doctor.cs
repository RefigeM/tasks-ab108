namespace _31_10_24_practise.Models;
    class Doctor
    {
    public string DoctorName { get; set; }
    public string DoctorSurname{ get; set; }
    public Doctor(string name,string surname)
    {
        DoctorName = name;
        DoctorSurname = surname;
    }
}

