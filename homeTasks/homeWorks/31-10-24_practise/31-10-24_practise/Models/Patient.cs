namespace _31_10_24_practise.Models;
     class Patient
    {
    public string PatientName { get; set; }
    public string PatientSurname { get; set; }
    public Patient(string name, string surname)
    {
        PatientName = name;
        PatientSurname = surname;
    }
}
