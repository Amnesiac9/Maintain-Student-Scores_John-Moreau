using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintain_Student_Scores_John_Moreau
{
    public class Scores
    {
        public int[] ScoresArray { get; set; }
        public int ScoreCount { get; set; }
        public int ScoreTotal { get; set; }
        public double ScoreAverage { get; set; }
        public int ScoreMinimum { get; set; }
        public int ScoreMaximum { get; set; }

        public Scores(int[] scores) {
            ScoresArray = scores;
            ScoreCount = scores.Length;
            ScoreTotal = scores.Sum();
            ScoreAverage = scores.Average();
            ScoreMinimum = scores.Min();
            ScoreMaximum = scores.Max();
        }


    }
}
