using LabOne.Models;

namespace LabOne.Converters
{
    public static class SubjectsConverter
    {
        public static Subjects ToSubjects(string algebraGrade, string geometryGrade, string programmingGrade, string physicsGrade, string chemistryGrade
            , string ukrainianGrade, string englishGrade, string literatureGrade, string historyGrade, string economyGrade)
        {
            return new Subjects(Convert.ToDouble(algebraGrade), Convert.ToDouble(geometryGrade), Convert.ToDouble(programmingGrade)
                , Convert.ToDouble(physicsGrade), Convert.ToDouble(chemistryGrade), Convert.ToDouble(ukrainianGrade), Convert.ToDouble(englishGrade)
                , Convert.ToDouble(literatureGrade), Convert.ToDouble(historyGrade), Convert.ToDouble(economyGrade));
        }
    }
}