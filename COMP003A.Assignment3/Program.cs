/*Author: Vanessa Garcia
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
                    if(numericGrade > 90)
                    gradeLetter = "A";
                    else if (numericGrade >= 80)
                    gradeLetter = "B";
                    else if (numericGrade >= 70)
                    gradeLetter = "C";
                    else if (numericGrade >= 60)
                    gradeLetter = "D";
                    else if (numericGrade<60)
                    gradeLetter = "F"
            }