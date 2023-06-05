﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * John Moreau
 * CSS133
 * 6/4/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    [Serializable]
    public class Scores : ICloneable
    {
        public int[] ScoresArray { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        public int Average { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

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

        public object Clone()
        {

            Scores clonedScores = new Scores(new int[0]);

            // Deep copy the scores array if it's not empty
            if (ScoresArray != null)
            {
                clonedScores.ScoresArray = new int[ScoresArray.Length];
                Array.Copy(ScoresArray, clonedScores.ScoresArray, ScoresArray.Length);
                clonedScores.Count = Count;
                clonedScores.Total = Total;
                clonedScores.Average = Average;
                clonedScores.Min = Min;
                clonedScores.Max = Max;
            }

            return clonedScores;

        }

    }
}
