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

        public static Random random = new Random();

        public string Name { get; set; }
        public Scores StudentScores { get; set; }
        public string StudentId { get; set; }
        public DateTime RecordStartDate { get; private set; } // private so we can't change it later


        public Student(string nameAndScoresString)
        {
           (string studentName, int[] newScoresArray) = SplitNameAndScores(nameAndScoresString);
            Name = studentName;
            StudentScores = new Scores(newScoresArray);
            StudentId = random.Next(000000001, 999999999).ToString("D9"); // D9 to pad with 0s SOURCE: https://stackoverflow.com/questions/3459610/pad-with-leading-zeros
            RecordStartDate = DateTime.Now;
        }

        public Student(string name, Scores scores)
        {
            Name = name;
            StudentScores = scores;
            StudentId = random.Next(000000001, 999999999).ToString();
            RecordStartDate = DateTime.Now;
        }
        
        // pre: none
        // post: returns a string of the student's name and scores concatenated together with | as a seperator
        public string ConcatNameAndScoresToString()
        {
            string NameAndScoresString = Name;
            foreach (int score in StudentScores.ScoresArray) {
                string currentScore = score.ToString();
                NameAndScoresString += "|" + currentScore;
            }
            return NameAndScoresString;
        }

        // pre: a string with the names and scores with | as a seperator
        // post: a tuple with the name and an int array of the scores
        private (string, int[]) SplitNameAndScores(string nameAndScoresString)
        {
            string[] studentArray = nameAndScoresString.Split('|');

            // Create an int array to hold the parsed scores, -1 because we already took out the name
            int[] newScoresArray = new int[studentArray.Length - 1];

            for (int i = 1; i < studentArray.Length; ++i)
            {
                if (int.TryParse(studentArray[i], out int score))
                {
                    newScoresArray[i - 1] = score;
                }
            }

            return (studentArray[0], newScoresArray);
        }

    }



}
