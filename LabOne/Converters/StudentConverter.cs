using LabOne.Models;

namespace LabOne.Converters
{
    public static class StudentConverter
    {
        public static Student ToStudent(string name, string recordBookNumber, string yearInUniversity, string algebraGrade, string geometryGrade
            , string programmingGrade, string physicsGrade, string chemistryGrade, string ukrainianGrade, string englishGrade, string literatureGrade
            , string historyGrade, string economyGrade)
        {
            return new Student(name, recordBookNumber, Convert.ToInt32(yearInUniversity), SubjectsConverter.ToSubjects(algebraGrade, geometryGrade
                , programmingGrade, physicsGrade, chemistryGrade, ukrainianGrade, englishGrade, literatureGrade, historyGrade, economyGrade));
        }
    }
}
