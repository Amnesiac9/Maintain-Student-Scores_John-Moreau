using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintain_Student_Scores_John_Moreau
{

    /* 
     * John Moreau
     * CSS133
     * 5/12/2023
     * 
     * Windows form app for maintaining a record of student scores.
     * 
     * SOURCES:
     * Adding DPI Awareness to fix fuzzy text: https://stackoverflow.com/questions/1553235/to-show-a-new-form-on-click-of-a-button-in-c-sharp
     * Passing info to and from Forms: Chapter 10 of the Murach's C# book
     * Writing to a binary file: https://www.codeproject.com/questions/500398/saveplusfileplusinplusbinaryplususingplusc-23
     * https://stackoverflow.com/questions/19432468/how-do-i-read-write-binary-files-in-c
     * https://stackoverflow.com/questions/32108996/deserialize-object-from-binary-file
     * 
     */

    internal static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainStudentScores());
        }

    }
}
