using LabOne.Warnings;

namespace LabOne.Validators
{
    public class StudentValidator
    {
        public static IWarning CheckStudent(string name, string recordBookNumber, string yearInUniversity, string algebraGrade, string geometryGrade
            , string programmingGrade, string physicsGrade, string chemistryGrade, string ukrainianGrade, string englishGrade, string literatureGrade
            , string historyGrade, string economyGrade)
        {
            if (!NameIsValid(name))
                return new IncorrectName();
            else if (!RecordBookNumberIsValid(recordBookNumber))
                return new IncorrectRecordBookNumber();
            else if (!YearInUniversityIsValid(yearInUniversity))
                return new IncorrectYearInUniversity();
            else if (SubjectsValidator.CheckGrades(algebraGrade, geometryGrade, programmingGrade, physicsGrade, chemistryGrade, ukrainianGrade, englishGrade
                , literatureGrade, historyGrade, economyGrade).GetType() == typeof(IncorrectGrades))
                return new IncorrectGrades();
            else
                return new None();
        }

        // Name
        private static bool NameIsValid(string name)
        {
            return name != string.Empty && name.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)); // if name is not empty, and has only letters
        }

        // Record book number
        private static bool RecordBookNumberIsValid(string recordBookNumber)
        {
            return recordBookNumber != string.Empty && recordBookNumber.All(r => Char.IsDigit(r)); // if it is not empty, and all characters are digits 
        }

        // Year in university
        private static bool YearInUniversityIsValid(string yearInUniversity)
        {
            bool yearInUniversityIsValid = true;

            try
            {
                int year = Convert.ToInt32(yearInUniversity);
                if (year < 1 || year > 6)
                    yearInUniversityIsValid = false;
            }
            catch (Exception)
            {
                yearInUniversityIsValid = false;
            }

            return yearInUniversityIsValid;
        }
    }
}