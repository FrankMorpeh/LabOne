namespace LabOne.Models
{
    public class Subjects
    {
        Dictionary<SubjectName, double> itsSubjects;

        public Subjects()
        {
            itsSubjects = new Dictionary<SubjectName, double>();
            SetGrades();
        }
        public Subjects(double algebraGrade, double geometryGrade, double programmingGrade, double physicsGrade, double chemistryGrade
            , double ukrainianGrade, double englishGrade, double literatureGrade, double historyGrade, double economyGrade) : this()
        {
            itsSubjects = new Dictionary<SubjectName, double>();
            SetGrades(algebraGrade, geometryGrade, programmingGrade, physicsGrade, chemistryGrade, ukrainianGrade, englishGrade, literatureGrade
                , historyGrade, economyGrade);
        }
        private void SetGrades(double algebraGrade = 0.0, double geometryGrade = 0.0, double programmingGrade = 0.0, double physicsGrade = 0.0
            , double chemistryGrade = 0.0, double ukrainianGrade = 0.0, double englishGrade = 0.0, double literatureGrade = 0.0, double historyGrade = 0.0
            , double economyGrade = 0.0)
        {
            itsSubjects[SubjectName.Algebra] = algebraGrade;
            itsSubjects[SubjectName.Geometry] = geometryGrade;
            itsSubjects[SubjectName.Programming] = programmingGrade;
            itsSubjects[SubjectName.Physics] = physicsGrade;
            itsSubjects[SubjectName.Chemistry] = chemistryGrade;
            itsSubjects[SubjectName.Ukrainian] = ukrainianGrade;
            itsSubjects[SubjectName.English] = englishGrade;
            itsSubjects[SubjectName.Literature] = literatureGrade;
            itsSubjects[SubjectName.History] = historyGrade;
            itsSubjects[SubjectName.Economy] = economyGrade;
        }


        // Methods
        public void SetGrade(SubjectName subjectName, double grade) { itsSubjects[subjectName] = grade; }
        public double GetGrade(SubjectName subjectName) { return itsSubjects[subjectName]; }
        public double GetAverageGrade()
        {
            double averageGrade = 0.0;
            foreach (double grade in itsSubjects.Values)
                averageGrade += grade;
            return averageGrade / itsSubjects.Count;
        }


        // Static methods
        public static Dictionary<SubjectName, double> CompareGradesOf(Student lhs, Student rhs)
        {
            Dictionary<SubjectName, double> differenceInGrades = new Dictionary<SubjectName, double>();

            differenceInGrades[SubjectName.Algebra] = GetDifferenceInSubject(lhs, rhs, SubjectName.Algebra);
            differenceInGrades[SubjectName.Geometry] = GetDifferenceInSubject(lhs, rhs, SubjectName.Geometry);
            differenceInGrades[SubjectName.Programming] = GetDifferenceInSubject(lhs, rhs, SubjectName.Programming);
            differenceInGrades[SubjectName.Physics] = GetDifferenceInSubject(lhs, rhs, SubjectName.Physics);
            differenceInGrades[SubjectName.Chemistry] = GetDifferenceInSubject(lhs, rhs, SubjectName.Chemistry);
            differenceInGrades[SubjectName.Ukrainian] = GetDifferenceInSubject(lhs, rhs, SubjectName.Ukrainian);
            differenceInGrades[SubjectName.English] = GetDifferenceInSubject(lhs, rhs, SubjectName.English);
            differenceInGrades[SubjectName.Literature] = GetDifferenceInSubject(lhs, rhs, SubjectName.Literature);
            differenceInGrades[SubjectName.History] = GetDifferenceInSubject(lhs, rhs, SubjectName.History);
            differenceInGrades[SubjectName.Economy] = GetDifferenceInSubject(lhs, rhs, SubjectName.Economy);

            return differenceInGrades;
        }
        private static double GetDifferenceInSubject(Student lhs, Student rhs, SubjectName subjectName)
        {
            return lhs.GetGrade(subjectName) - rhs.GetGrade(subjectName);
        }


        // Override
        public override string ToString()
        {
            return "Algebra: " + itsSubjects[SubjectName.Algebra] + "\nGeometry: " + itsSubjects[SubjectName.Geometry]
                + "\nProgramming: " + itsSubjects[SubjectName.Programming] + "\nPhysics: " + itsSubjects[SubjectName.Physics]
                + "\nChemistry: " + itsSubjects[SubjectName.Chemistry] + "\nUkrainian: " + itsSubjects[SubjectName.Ukrainian]
                + "\nEnglish: " + itsSubjects[SubjectName.English] + "\nLiterature: " + itsSubjects[SubjectName.Literature]
                + "\nHistory: " + itsSubjects[SubjectName.History] + "\nEconomy: " + itsSubjects[SubjectName.Economy];
        }
    }
}