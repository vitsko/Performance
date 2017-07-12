namespace Launcher
{
    using System;
    using System.Text;
    using Calculate;
    using Text;
    using static System.Console;

    internal static class Screen
    {
        internal static void ShowMainMenu(string mainMune)
        {
            Clear();
            WriteLine(mainMune);
        }

        internal static void ShowResultCompare(Calculate firstToCompare, Calculate secondToCompare)
        {
            Clear();

            StringBuilder builder = new StringBuilder();

            var firstName = firstToCompare.ToString();
            var secondName = secondToCompare.ToString();
            var firstResult = firstToCompare.GetPerformanceToAdd();
            var secondResult = secondToCompare.GetPerformanceToAdd();

            builder.AppendFormat(Text.AboutCompare, firstName, secondName, Calculate.CountOfObject);
            builder.AppendLine();

            AboutPerformanceOperatin(builder, firstName, secondName, Text.CompareToAdd, firstResult, secondResult);

            firstResult = firstToCompare.GetPerformanceToSearch();
            secondResult = secondToCompare.GetPerformanceToSearch();

            AboutPerformanceOperatin(builder, firstName, secondName, Text.CompareToSearch, firstResult, secondResult);

            firstResult = firstToCompare.GetPerformanceToClear();
            secondResult = secondToCompare.GetPerformanceToClear();

            AboutPerformanceOperatin(builder, firstName, secondName, Text.CompareToClear, firstResult, secondResult);

            builder.AppendLine(Text.PressAnyKey);

            WriteLine(builder.ToString());
        }

        internal static bool IsSelectedMenu(ConsoleKey selectCreateditem)
        {
            return selectCreateditem == ConsoleKey.D1 ||
                   selectCreateditem == ConsoleKey.D2 ||
                   selectCreateditem == ConsoleKey.D3 ||
                   selectCreateditem == ConsoleKey.NumPad1 ||
                   selectCreateditem == ConsoleKey.NumPad2 ||
                   selectCreateditem == ConsoleKey.NumPad3;
        }

        private static void AboutPerformanceOperatin(StringBuilder builder, string firstName, string secondName, string aboutOperation, long firstResult, long secondResult)
        {
            builder.AppendLine(aboutOperation);
            builder.AppendFormat(
                                 Text.AboutPerformance,
                                 firstName,
                                 firstResult);
            builder.AppendLine();
            builder.AppendFormat(
                                 Text.AboutPerformance,
                                 secondName,
                                 secondResult);
            builder.AppendLine();

            string aboutFasterOperation = Screen.AboutFaster(firstResult, secondResult, firstName, secondName);

            builder.AppendLine(aboutFasterOperation);
            builder.AppendLine();
        }

        private static string AboutFaster(long firstResult, long secondResult, string firstName, string secondName)
        {
            if (firstResult == secondResult)
            {
                return string.Format(Text.ResultOfEqual, firstName, secondName);
            }

            return firstResult < secondResult ? string.Format(Text.FirstFaster, firstName, secondName) :
                                                string.Format(Text.SecondFaster, firstName, secondName);
        }
    }
}