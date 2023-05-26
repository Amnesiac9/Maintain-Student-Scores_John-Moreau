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
    public class Scores
    {
        public int[] ScoresArray { get; set; }
        public int Count { get; }
        public int Total { get; }
        public int Average { get; }
        public int Min { get; }
        public int Max { get; }

        public Scores(int[] scores) {
            ScoresArray = scores;
            if (scores.Length == 0) {
                Count = 0;
                Total = 0;
                Average = 0;
                Min = 0;
                Max = 0;
            } else
            {
                Count = scores.Length;
                Total = scores.Sum();
                Average = (int)scores.Average();
                Min = scores.Min();
                Max = scores.Max();
            }
            
        }

    }
}
