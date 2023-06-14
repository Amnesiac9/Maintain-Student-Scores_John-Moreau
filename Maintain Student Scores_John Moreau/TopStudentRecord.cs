using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * John Moreau
 * CSS133
 * 6/5/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    /// <summary>
    /// A class for maintaining a top student record. This allows easy retreval and updating of the data from the rest of the app.
    /// </summary>
    public static class TopStudentRecord
    {
        public static Student TopStudent { get; set; }
        public static int AverageScore { get; set; }
        public static int TopStudentIndex { get; set; }

        /// <summary>
        /// Sets the top student, top average score, and the index of that student.
        /// </summary>
        /// Pre: A list of students from StudentDB.
        /// Post: Top student is found, average and index is updated
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

        /// <summary>
        /// Function to find the top student and update the top student labels.
        /// </summary>
        /// <param name="labelTopStudentNameTxt"></param>
        /// <param name="labelTopStudentAverageTxt"></param>
        /// Pre: list of students edited
        /// Post: the top student is found and the labels are updated
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
