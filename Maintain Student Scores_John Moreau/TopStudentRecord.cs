using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void SetTopStudent()
        {
            int index = 0;

            if (StudentDB.studentList.Count < 1)
            {
                return;
            }


            TopStudent = StudentDB.studentList[index];
            AverageScore = TopStudent.StudentScores.Average;
            TopStudentIndex = index;


            foreach (Student student in StudentDB.studentList)
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

        // Function to find the top student and update the top student labels.
        // pre: list of students edited
        // post: the top student is found and the labels are updated
        public static void GetTopStudent(Label labelTopStudentNameTxt, Label labelTopStudentAverageTxt)
        {
            // Set the top student
            TopStudentRecord.SetTopStudent();

            // Make sure we have students and that the top student has scores
            if (StudentDB.studentList.Count < 1 || TopStudent.StudentScores.ScoresArray.Length < 1)
            {
                labelTopStudentNameTxt.Text = "";
                labelTopStudentAverageTxt.Text = "";
                TopStudentIndex = -1;
                return;
            }

            labelTopStudentNameTxt.Text = TopStudent.Name;
            labelTopStudentAverageTxt.Text = AverageScore.ToString();

        }
    }
}
