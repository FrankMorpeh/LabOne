using LabOne.Controllers;
using LabOne.Models;

namespace LabOne.View
{
    public class StudentView
    {
        private StudentController itsStudentController;

        public StudentView() { itsStudentController = null; }
        public StudentView(StudentController studentController) { itsStudentController = studentController; }

        public void AddStudent(Student student)
        {
            itsStudentController.AddStudent(student);
            Console.WriteLine("Student has been successfully added!\n");
        }
        public void RemoveStudentAt(int index)
        {
            itsStudentController.RemoveStudentAt(index);
            Console.WriteLine("Student has been successfully removed!\n");
        }
        public void ShowStudents()
        {
            Console.WriteLine("Students:\n");

            for (int i = 0; i < itsStudentController.Count; i++)
            {
                int currentNumber = i + 1;
                Console.WriteLine(Convert.ToString(currentNumber) + ":\n\n" + itsStudentController[i] + "\n");
            }
        }
        public void ShowDifferenceInGrades(int lhsIndex, int rhsIndex)
        {
            Dictionary<SubjectName, double> subjects = Subjects.CompareGradesOf(itsStudentController[lhsIndex], itsStudentController[rhsIndex]);

            Console.WriteLine("Difference in grades:\n");

            foreach (var subject in subjects.Keys)
                Console.WriteLine(subject + ": " + subjects[subject]);

            Console.WriteLine();
        }
    }
}