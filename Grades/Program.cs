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

            book.NameChanged += OnNameChanged;

            book.Name = "Scott's Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResults("Avarage", stats.AvareGrade);
            WriteResults("Highest", (int)stats.HighestGrade);
            WriteResults("Lowest", stats.LowestGrade);
        }
        static void WriteResults(string desciption, int result)
        {
            Console.WriteLine(desciption + ": " + result);
        }

        static void WriteResults(string desciption, float result)
        {
            Console.WriteLine($"{desciption}: {result:F2}");
        }

        static void OnNameChanged(object sender, NameChangedEventsArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
    }
}
