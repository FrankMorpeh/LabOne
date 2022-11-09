namespace LabOne.Warnings
{
    public interface IWarning
    {
        string Text { get; }
    }
    public class IncorrectName : IWarning
    {
        public IncorrectName() { Text = "The name is invalid!\n"; }
        public string Text { get; private set; }
    }
    public class IncorrectRecordBookNumber : IWarning
    {
        public IncorrectRecordBookNumber() { Text = "The record book number is invalid!\n"; }
        public string Text { get; private set; }
    }
    public class IncorrectYearInUniversity : IWarning
    {
        public IncorrectYearInUniversity() { Text = "The univesity year is invalid!\n"; }
        public string Text { get; private set; }
    }
    public class IncorrectGrades : IWarning
    {
        public IncorrectGrades() { Text = "Grades are invalid!\n"; }
        public string Text { get; private set; }
    }
    public class None : IWarning
    {
        public None() { Text = "No errors detected!\n"; }
        public string Text { get; private set; }
    }
}