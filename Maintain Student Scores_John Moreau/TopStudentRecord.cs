using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintain_Student_Scores_John_Moreau
{
    public class TopStudentRecord
    {
        public Student TopStudent { get; set; }
        public double AverageScore { get; set; }

        public static int TopStudentIndex { get; set; }

        public void GetTopStudentAverage()
        {
            AverageScore = TopStudent.StudentScores.ScoreAverage;
        }

        // pre: List of students
        // post: Top student is found and average is updated
        public void SetTopStudent(List<Student> StudentList)
        {
            int index = 0;

            TopStudent = StudentList.FirstOrDefault();

            foreach (Student student in StudentList)
            {
                Scores currentStudent = student.StudentScores;
                Scores bestStudent = TopStudent.StudentScores;

                if ( currentStudent.ScoreAverage > bestStudent.ScoreAverage
                    || currentStudent.ScoreAverage == bestStudent.ScoreAverage
                    && currentStudent.ScoreTotal > bestStudent.ScoreTotal)
                {
                    TopStudent = student;
                    TopStudentIndex = index;
                    GetTopStudentAverage();
                }
                ++index;
            }

        }

    }
}
