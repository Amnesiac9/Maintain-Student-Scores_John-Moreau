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
        public static DateTime RecordStartDate { get; private set; } // private so we can't change it later
        
        public Student(string name)
        {
            Name = name;
            StudentScores = new Scores(new int[0]);
            RecordStartDate = DateTime.Now;
        }

        public Student(string name, int[] scores)
            : this(name)
        {
            StudentScores = new Scores(scores);
        }
        

        public string ConcatNameAndScoresToString()
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
