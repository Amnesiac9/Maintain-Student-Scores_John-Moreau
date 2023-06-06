using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * John Moreau
 * CSS133
 * 6/5/2023
 * 
 * Windows form app for maintaining a record of student scores.
 * 
 * SOURCES:
 * Adding DPI Awareness to fix fuzzy text: https://stackoverflow.com/questions/1553235/to-show-a-new-form-on-click-of-a-button-in-c-sharp
 * Passing info to and from Forms: Chapter 10 of the Murach's C# book
 * Writing to a binary file: https://www.codeproject.com/questions/500398/saveplusfileplusinplusbinaryplususingplusc-23
 * https://stackoverflow.com/questions/19432468/how-do-i-read-write-binary-files-in-c
 * https://stackoverflow.com/questions/32108996/deserialize-object-from-binary-file
 * Adding leading zeros to student id: https://stackoverflow.com/questions/3459610/pad-with-leading-zeros
 * 
 * Updates:
 * Switched to using serializable classes for students and their scores.
 * Added a Scores class to hold the scores and calculate the average, min, max, etc.
 * Added a Student class to hold a student's name, scores, and date of record creation.
 * Added a TOP student class to hold the top student.
 * Added a Top Student button to find the index of the current top student.
 * Added new label showing when a student record was first created.
 * Added student ID to the student class with a ranom 9 digit number.
 * 
 * 6/4/23, 6/5/23
 * Added the validator class to validate user input.
 * Added a save button so saving is not automatic.
 * Added a try/catch to the save button to catch any errors saving to a binary file.
 * Added StudentDB class to handle saving and loading student data.
 * Moved the GetTopStudent method to TopStudentRecord class.
 * Created a StudentList class to hold a list of students that auto sorts when a new student is added.
 * Added a FirstName and LastName property to the Student class to allow sorting by last name.
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{

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
