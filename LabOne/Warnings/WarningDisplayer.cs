namespace LabOne.Warnings
{
    public static class WarningDisplayer
    {
        public static void ShowWarning(IWarning errorType)
        {
            Console.WriteLine(errorType.Text);
        }
    }
}