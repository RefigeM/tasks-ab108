namespace _24_10_24_homeTask_lab
{
    public class StudentService : IStudentService
    {
        private Student[] students;
        public StudentService(Student[] allStudents)
        {

            students= allStudents ;

        }

        public Student GetStudentByID(int id) {
            for (int i = 0; i < students.Length; i++) {
                if (students[i].Id == id) return students[i];   
            }
            return null;
        }
        public Student[] GetAllStudents() {
            
            return students;
        }
        public Student[] GetStudentsByName(string name) {
            Student[] searchedName = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].FirstName == name) {
                    for (int j = 0; j < searchedName.Length; j++) {
                        searchedName[j] = students[i];
                    }
                }
                students = searchedName;
            }
            return students;
        }

        public void AddStudent(Student student) { 
        }
        public void UpdateStudent(int id) { 
        }
        public void RemoveStudent(int id, bool isSoftDelete) { 
        }
    }
}
