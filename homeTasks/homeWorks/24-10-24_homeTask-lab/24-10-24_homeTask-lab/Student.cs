namespace _24_10_24_homeTask_lab
{
    public enum StudentStatus
    {
        Active,
        Graduate,
        Pending,
        Removed

    }
    public class Student 
    {
        public static int counter { get; set; }
        public  int Id { get; }
        public Student()
        {
            Id=++counter;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double GPA { get; set; }
        public StudentStatus Status { get; set; }
        public string Major { get; set; }


    }
}
