namespace _24_10_24_homeTask_lab
{
    internal interface IStudentService
    {
       public Student GetStudentByID(int id);
       public Student[] GetAllStudents();
        public Student[] GetStudentsByName(string name);
        void AddStudent(Student student);
        void UpdateStudent(int id);
        void RemoveStudent(int id, bool isSoftDelete);



    }
}
