using LabOne.Warnings;

namespace LabOne.Validators
{
    public static class SubjectsValidator
    {
        public static IWarning CheckGrades(string algebraGrade, string geometryGrade, string programmingGrade, string physicsGrade, string chemistryGrade
            , string ukrainianGrade, string englishGrade, string literatureGrade, string historyGrade, string economyGrade)
        {
            List<string> grades = new List<string>() { algebraGrade, geometryGrade, programmingGrade, physicsGrade, chemistryGrade, ukrainianGrade
                , englishGrade, literatureGrade, historyGrade, economyGrade };

            IWarning errorType = new None();

            foreach (string grade in grades)
            {
                if (!GradeIsValid(grade))
                {
                    errorType = new IncorrectGrades();
                    break;
                }
            }

            return errorType;
        }
        private static bool GradeIsValid(string strGrade)
        {
            bool gradeIsValid = true;
            double grade;

            try
            {
                grade = Convert.ToDouble(strGrade);
                if (grade < 0 || grade > 100)
                    gradeIsValid = false;
            }
            catch (Exception)
            {
                gradeIsValid = false;
            }

            return gradeIsValid;
        }
    }
}