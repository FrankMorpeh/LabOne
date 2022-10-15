using LabOne.Models;
using System.Collections;

namespace LabOne.Enumerable
{
    public class StudentControllerIterator : IEnumerator<Student>
    {
        private readonly List<Student> itsStudents;
        private int itsCurrentIndex;

        public StudentControllerIterator(List<Student> students) { itsStudents = students; itsCurrentIndex = -1; }

        object IEnumerator.Current => throw new NotImplementedException();
        public Student Current => GetCurrent();
        private Student GetCurrent()
        {
            if (itsCurrentIndex == -1 || itsCurrentIndex == itsStudents.Count)
                throw new IndexOutOfRangeException();
            else
                return itsStudents[itsCurrentIndex];
        }

        public bool MoveNext()
        {
            if (itsCurrentIndex + 1 < itsStudents.Count)
            {
                itsCurrentIndex++;
                return true;
            }
            else
                return false;
        }

        public void Reset() { itsCurrentIndex = -1; }

        public void Dispose() { }
    }
}
