using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintain_Student_Scores_John_Moreau
{
    internal class Validator
    {
        /// <summary>
        /// Checks if a string is present and is not white space.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>bool</returns>
        public static bool IsPresent(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        /// Checks if a string can be parsed into an int.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>bool</returns>
        public static bool IsInt(string text)
        {
            return int.TryParse(text, out _);
        }

        /// <summary>
        /// Checks if the text can be parsed into a decimal, if it can, it will check if the decimal is within the min, max range.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>bool</returns>
        public static bool IsInRange(string text, decimal min, decimal max)
        {
            if(decimal.TryParse(text.Trim(), out decimal number))
            {
                if (number > max || number < min)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if the string entered is a valid student name, which must not include "|" or be empty space.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>bool</returns>
        public static bool IsValidName(string text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Contains("|"))
            {
                return false;
            }
            return true;
        }

    }
}
