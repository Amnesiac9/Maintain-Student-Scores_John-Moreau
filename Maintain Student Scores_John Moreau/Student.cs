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
    public class Student
    {

        public string Name { get; set; }
        public Scores StudentScores { get; set; }
        public static DateTime RecordStartDate { get; private set; } // private so we can't change it later
        
        public Student(string name, Scores scores)
        {
            Name = name;
            StudentScores = scores;
            RecordStartDate = DateTime.Now;
        }

        public string DisplayNameAndScores()
        {
            string NameAndScoresString = Name;
            foreach (int score in StudentScores.ScoresArray) {
                string currentScore = score.ToString();
                NameAndScoresString += "|" + currentScore;
            }
            return NameAndScoresString;
        }


    }
}
