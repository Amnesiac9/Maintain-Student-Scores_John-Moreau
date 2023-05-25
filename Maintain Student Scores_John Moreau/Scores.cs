using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintain_Student_Scores_John_Moreau
{
    [Serializable]
    public class Scores
    {
        public int[] ScoresArray { get; set; }
        public int ScoreCount { get; }
        public int ScoreTotal { get; }
        public double ScoreAverage { get; }
        public int ScoreMinimum { get; }
        public int ScoreMaximum { get; }

        public Scores(int[] scores) {
            ScoresArray = scores;
            if (scores.Length == 0) {
                ScoreCount = 0;
                ScoreTotal = 0;
                ScoreAverage = 0;
                ScoreMinimum = 0;
                ScoreMaximum = 0;
            } else
            {
                ScoreCount = scores.Length;
                ScoreTotal = scores.Sum();
                ScoreAverage = scores.Average();
                ScoreMinimum = scores.Min();
                ScoreMaximum = scores.Max();
            }
            
        }


    }
}
