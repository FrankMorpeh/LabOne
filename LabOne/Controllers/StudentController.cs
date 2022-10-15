using LabOne.Enumerable;
using LabOne.Models;

namespace LabOne.Controllers
{
    public class StudentController
    {
        private List<Student> itsStudents;

        public StudentController() { itsStudents = new List<Student>(); }

        public int Count { get { return itsStudents.Count; } }
        public Student this[int index] { get { return itsStudents[index]; } set { itsStudents[index] = value; } }

        public void AddStudent(Student student) { itsStudents.Add(student); }
        public void RemoveStudentAt(int index) { itsStudents.RemoveAt(index); }

        public IEnumerator<Student> GetEnumerator()
        {
            return new StudentControllerIterator(itsStudents);
        }
    }
}