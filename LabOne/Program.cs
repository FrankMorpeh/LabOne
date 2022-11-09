using LabOne.Controllers;
using LabOne.Converters;
using LabOne.Validators;
using LabOne.View;
using LabOne.Warnings;

namespace LabOne
{
    class Program
    {
        private static StudentController itsStudentController;
        private static StudentView itsStudentView;

        static Program()
        {
            itsStudentController = new StudentController();
            itsStudentView = new StudentView(itsStudentController);
        }

        public static void Main()
        {
            ShowMainMenu();

            Console.ReadLine();
        }
        private static void ShowMainMenu()
        {
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Remove student");
            Console.WriteLine("3. Show students");
            Console.WriteLine("4. Compare two students");
            Console.WriteLine("5. Clear console");
            Console.WriteLine("6. Exit");

            Console.Write("\nYour choice: ");
            string choice = Console.ReadLine();
            MoveToSubMenu(choice);
        }
        private static void MoveToSubMenu(string choice)
        {
            switch(choice)
            {
                case "1":
                    ShowAddStudentMenu();
                    break;
                case "2":
                    ShowRemoveStudentMenu();
                    break;
                case "3":
                    ShowStudents();
                    break;
                case "4":
                    ShowComparingMenu();
                    break;
                case "5":
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case "6":
                    CloseProgram();
                    break;
            }
        }
        private static void ShowAddStudentMenu()
        {
            Console.Clear();

            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Record book number: "); string recordBookNumber = Console.ReadLine();
            Console.Write("Year in university: "); string yearInUniversity = Console.ReadLine();

            Console.Write("\nAlgebra grade: "); string algebraGrade = Console.ReadLine();
            Console.Write("Geometry grade: "); string geometryGrade = Console.ReadLine();
            Console.Write("Programming grade: "); string programmingGrade = Console.ReadLine();
            Console.Write("Physics grade: "); string physicsGrade = Console.ReadLine();
            Console.Write("Chemistry grade: "); string chemistryGrade = Console.ReadLine();
            Console.Write("Ukranian grade: "); string ukrainianGrade = Console.ReadLine();
            Console.Write("English grade: "); string englishGrade = Console.ReadLine();
            Console.Write("Literature grade: "); string literatureGrade = Console.ReadLine();
            Console.Write("History grade: "); string historyGrade = Console.ReadLine();
            Console.Write("Economy grade: "); string economyGrade = Console.ReadLine();

            Console.Clear();

            IWarning errorType = StudentValidator.CheckStudent(name, recordBookNumber, yearInUniversity, algebraGrade, geometryGrade, programmingGrade
                , physicsGrade, chemistryGrade, ukrainianGrade, englishGrade, literatureGrade, economyGrade, historyGrade);
            if (errorType.GetType() == typeof(None))
            {
                itsStudentView.AddStudent(StudentConverter.ToStudent(name, recordBookNumber, yearInUniversity, algebraGrade, geometryGrade
                    , programmingGrade, physicsGrade, chemistryGrade, ukrainianGrade, englishGrade, literatureGrade, economyGrade, historyGrade));
            }
            else
                WarningDisplayer.ShowWarning(errorType);

            ShowMainMenu();
        }
        private static void ShowRemoveStudentMenu()
        {
            Console.Clear();

            itsStudentView.ShowStudents();

            Console.Write("\nYour choice (q - back to main menu): "); string choice = Console.ReadLine();
            Console.Clear();
            if (choice != "q")
            {
                itsStudentView.RemoveStudentAt(Convert.ToInt32(choice) - 1);
            }
            ShowMainMenu();
        }
        private static void ShowStudents()
        {
            Console.Clear();

            itsStudentView.ShowStudents();

            ShowMainMenu();
        }
        private static void ShowComparingMenu()
        {
            Console.Clear();

            itsStudentView.ShowStudents();

            Console.Write("\nFirst student (q - back to main menu): "); string firstChoice = Console.ReadLine();
            Console.Write("Second student (q - back to main menu): "); string secondChoice = Console.ReadLine();
            Console.Clear();

            if (firstChoice != "q" && secondChoice != "q")
            {
                itsStudentView.ShowDifferenceInGrades(Convert.ToInt32(firstChoice) - 1, Convert.ToInt32(secondChoice) - 1);
            }
            ShowMainMenu();
        }
        private static void CloseProgram()
        {
            Environment.Exit(0);
        }
    }
}