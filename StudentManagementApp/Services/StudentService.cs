using StudentManagementApp.Models;

namespace StudentManagementApp.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
    
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new()
        {
            new Student 
            { 
                Id = 1, 
                FirstName = "สมชาย", 
                LastName = "ใจดี", 
                Email = "somchai@email.com", 
                Age = 20, 
                Major = "วิทยาการคอมพิวเตอร์",
                EnrollmentDate = DateTime.Now.AddDays(-30)
            },
            new Student 
            { 
                Id = 2, 
                FirstName = "สมหญิง", 
                LastName = "รักเรียน", 
                Email = "somying@email.com", 
                Age = 19, 
                Major = "เทคโนโลยีสารสนเทศ",
                EnrollmentDate = DateTime.Now.AddDays(-25)
            },
            new Student 
            { 
                Id = 3, 
                FirstName = "วิชัย", 
                LastName = "เก่งมาก", 
                Email = "wichai@email.com", 
                Age = 21, 
                Major = "วิศวกรรมซอฟต์แวร์",
                EnrollmentDate = DateTime.Now.AddDays(-20)
            }
        };
        
        private static int _nextId = 4;
        
        public List<Student> GetAllStudents()
        {
            return _students.OrderBy(s => s.Id).ToList();
        }
        
        public Student? GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
        
        public void AddStudent(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
        }
        
        public void UpdateStudent(Student student)
        {
            var existingStudent = GetStudentById(student.Id);
            if (existingStudent != null)
            {
                var index = _students.IndexOf(existingStudent);
                _students[index] = student;
            }
        }
        
        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
