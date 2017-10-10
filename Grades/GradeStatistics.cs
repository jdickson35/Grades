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
                switch(LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
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
                double RoundAverageGrade = Math.Round(AverageGrade);
                Console.WriteLine(RoundAverageGrade);
                if (RoundAverageGrade >= 90)
                {
                    result = "A";
                }
                else if(RoundAverageGrade >= 80)
                {
                    result = "B";
                }
                else if (RoundAverageGrade >= 70)
                {
                    result = "C";
                }
                else if (RoundAverageGrade >= 60)
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

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
         
    }
}
