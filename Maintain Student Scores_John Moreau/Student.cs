using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * John Moreau
 * CSS133
 * 5/24/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    [Serializable]
    public class Student
    {

        public string Name { get; set; }
        public Scores StudentScores { get; set; }
        public DateTime RecordStartDate { get; private set; } // private so we can't change it later
        public string NameAndScores { get; set; }
        
        public Student(string nameAndScoresString)
        {
            string[] studentArray = nameAndScoresString.Split('|');

            if (studentArray.Length <= 1)
            {
                Name = studentArray[0];
                //StudentScores = new Scores(new int[0]);
                //RecordStartDate = DateTime.Now;
                //return;
            }

            // Create an int array to hold the parsed scores, -1 because we already took out the name
            int[] newScoresArray = new int[studentArray.Length - 1];

            for (int i = 1; i < studentArray.Length; ++i)
            {
                if (int.TryParse(studentArray[i], out int score))
                {
                    newScoresArray[i - 1] = score;
                }
            }

            Name = studentArray[0];
            StudentScores = new Scores(newScoresArray);
            RecordStartDate = DateTime.Now;
            NameAndScores = nameAndScoresString;
        }

        public Student(string name, Scores scores)
        {
            Name = name;
            StudentScores = scores;
            RecordStartDate = DateTime.Now;
            ConcatNameAndScoresToString();
        }



        //public Student SeperateNameAndScoresToStudent(string nameAndScoresString)
        //{

        //    string[] studentArray = nameAndScoresString.Split('|');

        //    if (studentArray.Length <= 1)
        //    {
        //        Student newStudentNoScores = new Student(studentArray[0]);
        //        return newStudentNoScores;
        //    }

        //    // Create an int array to hold the parsed scores, -1 because we already took out the name
        //    int[] newScoresArray = new int[studentArray.Length - 1];

        //    for (int i = 1; i < studentArray.Length; ++i)
        //    {
        //        if (int.TryParse(studentArray[i], out int score))
        //        {
        //            newScoresArray[i - 1] = score;
        //        }
        //    }

        //    Scores newScores = new Scores(newScoresArray);
        //    Student newStudent = new Student(studentArray[0], newScores);

        //    return newStudent;
        //}
        

        public string ConcatNameAndScoresToString()
        {
            string NameAndScoresString = Name;
            foreach (int score in StudentScores.ScoresArray) {
                string currentScore = score.ToString();
                NameAndScoresString += "|" + currentScore;
            }
            NameAndScores = NameAndScoresString;
            return NameAndScoresString;
        }
    }



}
