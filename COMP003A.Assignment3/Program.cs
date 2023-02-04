﻿/*Author: Vanessa Garcia
 * Course: Comp - 003A - L01
 * Purpose: Assignment Three Conditional Statements
*/



namespace ClearConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeLetter = "";
            string numericGradeStr;
            decimal numericGrade;
            Console.Write("Enter the number of the grade: ");
            numericGradeStr = Console.ReadLine();
            if (decimal.TryParse(numericGradeStr, out numericGrade))
            {
                if (numericGrade > 90)
                    gradeLetter = "A";
                else if (numericGrade >= 80)
                    gradeLetter = "B";
                else if (numericGrade >= 70)
                    gradeLetter = "C";
                else if (numericGrade >= 60)
                    gradeLetter = "D";
                else if (numericGrade < 60)
                    gradeLetter = "F";
            }

            else
                gradeLetter = "Please enter a valid Number";
            Console.WriteLine("Grade:" + gradeLetter);
            Console.WriteLine("Press Enter; to Exit...");
            Console.Read();
        }
    }
}


namespace ClearConsole
{
    class program
    {
        public static void Main(string[] args)
        {
            var numericDay = Convert.ToInt32(Console.ReadLine());
            switch (numericDay)
            {
                case 0:
                    Console.WriteLine("It's SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("It's MONDAY");
                    break;
                case 2:
                    Console.WriteLine("It's TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("It's WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("It's THURSDAY");
                    break;