namespace LabOne.Models
{
    public class Student
    {
        private string itsName;
        private string itsRecordBookNumber;
        private int itsYearInUniversity;
        private Subjects itsSubjects;

        public Student()
        {
            itsName = string.Empty;
            itsRecordBookNumber = string.Empty;
            itsYearInUniversity = 0;
            itsSubjects = null;
        }
        public Student(string name, string recordBookNumber, int yearInUniversity, Subjects subjects)
        {
            itsName = name;
            itsRecordBookNumber = recordBookNumber;
            itsYearInUniversity = yearInUniversity;
            itsSubjects = subjects;
        }


        // Properties
        public string Name { get { return itsName; } set { itsName = value; } }
        public string RecordBookNumber { get { return itsRecordBookNumber; } set { itsRecordBookNumber = value; } }
        public int YearInUniversity { get { return itsYearInUniversity; } set { itsYearInUniversity = value; } }
        public double AverageGrade { get { return itsSubjects.GetAverageGrade(); } }


        // Methods
        public void SetGrade(SubjectName subjectName, double grade) { itsSubjects.SetGrade(subjectName, grade); }
        public double GetGrade(SubjectName subjectName) { return itsSubjects.GetGrade(subjectName); }
        public Dictionary<SubjectName, double> CompareGradesTo(Student rhs)
        {
            return itsSubjects.CompareGradesOf(this, rhs);
        }


        // Override
        public override string ToString()
        {
            return "Name: " + itsName + "\nRecord book number: " + itsRecordBookNumber + "\nYear in university: " + itsYearInUniversity
                + "\nAverage grade: " + itsSubjects.GetAverageGrade() + "\n" + "\n\nAll grades:\n" + itsSubjects;
        }
    }
}