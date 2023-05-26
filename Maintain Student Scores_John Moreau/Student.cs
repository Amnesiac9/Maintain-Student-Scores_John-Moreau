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
        
        public Student(string name)
        {
            Name = name;
            StudentScores = new Scores(new int[0]);
            RecordStartDate = DateTime.Now;
        }

        public Student(string name, Scores scores)
            : this(name)
        {
            StudentScores = scores;
        }
        

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
