using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Avarage";
                        break;
                    case "D":
                        result = "Below Avarage";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if(AvareGrade >= 90)
                {
                    result = "A";
                }
                else if (AvareGrade >= 80)
                {
                    result = "B";
                }
                else if (AvareGrade >= 70)
                {
                    result = "C";
                }
                else if (AvareGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public float AvareGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
