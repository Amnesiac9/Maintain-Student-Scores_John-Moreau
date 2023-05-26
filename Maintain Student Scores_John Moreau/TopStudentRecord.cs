using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * John Moreau
 * CSS133
 * 5/25/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    public static class TopStudentRecord
    {
        public static Student TopStudent { get; set; }
        public static int AverageScore { get; set; }
        public static int TopStudentIndex { get; set; }

        // pre: List of students
        // post: Top student is found and average is updated
        public static void SetTopStudent(List<Student> StudentList)
        {
            int index = 0;

            if (StudentList.Count < 1)
            {
                return;
            }


            TopStudent = StudentList[index];

            foreach (Student student in StudentList)
            {
                Scores currentStudent = student.StudentScores;
                Scores bestStudent = TopStudent.StudentScores;

                if ( currentStudent.Average > bestStudent.Average
                    || currentStudent.Average == bestStudent.Average
                    && currentStudent.Total > bestStudent.Total)
                {
                    TopStudent = student;
                    AverageScore = student.StudentScores.Average;
                    TopStudentIndex = index;
                    
                }
                ++index;
            }

        }

    }
}
