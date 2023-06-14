using System;
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
    /// <summary>
    /// A Scores class for storing an int[] array of scores and calculating the count, total, average, min, and max of the scores.
    /// </summary>
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

        /// <summary>
        /// Scores.ToString() overrides the standard ToString() method to return a string representation of the scores array with ", " as a delimiter.
        /// </summary>
        /// <returns>A string representation of the scores array with ", " as a delimiter.</returns>
        public override string ToString()
        {
            string arrayString = "";

            for (int i = 0; i < ScoresArray.Length; ++i)
            {
                int s = ScoresArray[i];

                if (i != ScoresArray.Length - 1)
                    arrayString += s + ", ";
                else
                    arrayString += s;
            }

            return arrayString;
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
