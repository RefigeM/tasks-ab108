namespace _24_10_24_homeTask_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[] {

                new Student { FirstName = "REF", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890", GPA = 3.5, Status = StudentStatus.Active, Major = "Computer Science" },
                new Student { FirstName = "GUNAY", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890", GPA = 3.5, Status = StudentStatus.Active, Major = "Computer Science" },
                new Student { FirstName = "AYDIN", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890", GPA = 3.5, Status = StudentStatus.Active, Major = "Computer Science" },
                new Student { FirstName = "NURAY", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890", GPA = 3.5, Status = StudentStatus.Active, Major = "Computer Science" }

        };
            Console.WriteLine(students[3]);
            IStudentService studentService = new StudentService(students);

            //GetStudentByID(5)
            Student foundStudent = studentService.GetStudentByID(5);
            if (foundStudent != null) Console.WriteLine($"FirstName:{foundStudent.FirstName},LastName:{foundStudent.LastName},id:{foundStudent.Id}");
            else Console.WriteLine("telebe tapilmadi");

            //GetAllStudents()
            Student[] allStudents = studentService.GetAllStudents();
            if (allStudents.Length > 0)
                foreach (var student in allStudents) Console.WriteLine($"Student name:{student.FirstName},surname:{student.LastName},id:{student.Id}");

            else Console.WriteLine("there isn't any student.");


            //GetStudentsByName
            Student[] foundName = studentService.GetStudentsByName("GUNAY");
            if (foundName.Length > 0)
            {

                for (int i = 0; i < foundName.Length; i++)
                {
                    if (foundName.Length > 0) Console.WriteLine($"Student name:{foundName[i].FirstName},surname:{foundName[i].LastName},id:{foundName[i].Id},email:{foundName[i].Email}");
                }
            }
            else { Console.WriteLine("telebe tapilmadi"); }




        }
    }
}
 