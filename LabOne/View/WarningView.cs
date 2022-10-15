﻿using LabOne.Validators;

namespace LabOne.View
{
    public static class WarningView
    {
        public static void ShowWarning(ErrorType errorType)
        {
            switch (errorType)
            {
                case ErrorType.IncorrectName:
                    Console.WriteLine("The name is invalid!");
                    break;
                case ErrorType.IncorrectRecordBookNumber:
                    Console.WriteLine("The record book number is invalid!");
                    break;
                case ErrorType.IncorrectYearInUniversity:
                    Console.WriteLine("The univesity year is invalid!");
                    break;
                case ErrorType.IncorrectGrades:
                    Console.WriteLine("Grades are invalid!");
                    break;
            }
        }
    }
}