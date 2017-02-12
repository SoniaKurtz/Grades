using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResults("Avarage", stats.AvareGrade);
            WriteResults("Highest", stats.HighestGrade);
            WriteResults("Lowest", stats.LowestGrade);
            WriteResults(stats.Description, stats.LetterGrade);
        }
 
        static void WriteResults(string desciption, float result)
        {
            Console.WriteLine($"{desciption}: {result}");
        }

        static void WriteResults(string desciption, string result)
        {
            Console.WriteLine($"{desciption}: {result:F2}");
        }
    }
}
