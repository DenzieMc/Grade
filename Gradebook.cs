using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
     class GradeBook
    {

   public GradeBook()
        {
         grades = new List<float>();
         }

        public GradeStatistics ComputeStatistics()
        {

            GradeStatistics stats =  new GradeStatistics();

            stats.HighestGrade = 0;

            float sum = 0;
            foreach(float grade in grades)
            {

                if (grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade;

                }
                else

                    if (grade < stats. HighestGrade)
                {
                    stats.LowestGrade = grade;

                }
                
                //stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                //stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
            }
            public void AddGrade(float grade)
        {
            grades.Add(grade);

        }

        private List<float> grades; 
        
                }
}




//Dean