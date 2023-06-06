using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * John Moreau
 * CSS133
 * 6/5/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    /// <summary>
    /// A class for storing, loading, and saving student scores as student objects and lists.
    /// </summary>
    internal class StudentDB
    {

        // Global list of students
        //public static List<Student> StudentList = new List<Student>();
        public static StudentList studentList = new StudentList();

        // Global file to save scores
        public static string fileSavePathBin = "StudentScores.bin";



        /// <summary>
        /// Function to load the initial student list from a txt file.
        /// Called when the form is loaded if the bin file does not exist.
        /// </summary>
        /// <param name="listBoxStudents"></param>
        /// <param name="ChangesMade"></param>
        /// Pre: A listbox with student names and scores, and a bool to track changes.
        /// Post: List box is populated with student names and scores, and changesmade is set to true
        public static void LoadStudentsTxtFile(ListBox.ObjectCollection listBoxStudents, ref bool ChangesMade)
        {
            string fileSavePathTxt = "StudentScores.txt";

            if (!File.Exists(fileSavePathTxt))
            {
                MessageBox.Show("Error reading StudentScores.txt File.", "Error");
                return;
            }

            try
            {
                string[] students = File.ReadAllLines(fileSavePathTxt);

                foreach (string student in students)
                {
                    listBoxStudents.Add(student);
                }

                ChangesMade = true;
            }
            catch
            {
                MessageBox.Show("Error reading StudentScores.txt File.", "Error");
            }
            
        }

        /// <summary>
        /// Function to generate our list from the initial default ListBox.
        /// Called when transferring data from the ListBox to Student Objects.
        /// </summary>
        /// <param name="listBoxStudents"></param>
        /// Pre: a listbox with student names and scores
        /// Post: a list of students with names and scores as objects

        public static void SplitNamesAndScoresToList(ListBox.ObjectCollection listBoxStudents)
        {


            foreach (string student in listBoxStudents)
            {
                string[] currentStudent = student.Split('|');
                if (currentStudent.Length <= 1)
                {
                    Student newStudentNoScores = new Student(currentStudent[0]);
                    studentList.Add(newStudentNoScores);
                    // We have no scores, so skip to the next student
                    continue;
                }

                // Create an int array to hold the parsed scores, -1 because we already took out the name
                int[] newScoresArray = new int[currentStudent.Length - 1];

                for (int i = 1; i < currentStudent.Length; ++i)
                {
                    if (int.TryParse(currentStudent[i], out int score))
                    {
                        newScoresArray[i - 1] = score;
                    }
                }

                // Create new student with scores and add to the list
                Student newStudent = new Student(currentStudent[0], new Scores(newScoresArray));
                studentList.Add(newStudent);
            }
        }

        /// <summary>
        /// Function to Save the student list to a binary file. Takes and sets a ref bool to False to track changes made. Shows an error window if there are issues saving, and does not update the changes made bool.
        /// </summary>
        /// <param name="ChangesMade"></param>
        /// Pre: A ref to a ChangesMade bool to set to false if successful.
        /// Post: The student scores are serlialized from the list and saved to a bin file.
        public static void SaveStudentScores(ref bool ChangesMade)
        {
            // Serialize the StudentList to a binary file.
            // https://www.codeproject.com/questions/500398/saveplusfileplusinplusbinaryplususingplusc-23
            using (FileStream stream = new FileStream(fileSavePathBin, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter(); // IDK why it wouldn't let me do a "using" here, doesn't need to be disposed of?
                try
                {
                    formatter.Serialize(stream, studentList);
                    ChangesMade = false;
                    MessageBox.Show("Data saved succesfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error saving data to file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        ///  Function to load the student scores from a bin file (or create the file if it doesn't exist).
        ///  Will load initial students from a text file if the bin file doesn't exist.
        /// </summary>
        /// <param name="listBoxStudents"></param>
        /// <param name="ChangesMade"></param>
        /// Pre: none
        /// Post: student scores are loaded from a binary file into the list box
        public static void LoadStudentScores(ListBox.ObjectCollection listBoxStudents, ref bool ChangesMade) // Load from Binary
        {

            // Make sure it exists
            if (!File.Exists(fileSavePathBin))
            {
                // Load a text file that contains the student scores into the listboxStudents.Items
                LoadStudentsTxtFile(listBoxStudents, ref ChangesMade);
                // Load the intial strings from the list box to our List of students
                SplitNamesAndScoresToList(listBoxStudents); // TODO: Read this from text file instead
                //SaveStudentScores();
                return;
            }
            try
            {
                // Open file stream
                using (FileStream stream = new FileStream(fileSavePathBin, FileMode.Open))
                {
                    // Create new binary formatter to convert to bin
                    // https://stackoverflow.com/questions/32108996/deserialize-object-from-binary-file
                    BinaryFormatter formatter = new BinaryFormatter();
                    // deserialize and cast to a student list which includes their scores.
                    studentList = (StudentList)formatter.Deserialize(stream);
                }

                // Clear list box and add each student to the list box
                //listBoxStudents.Clear();

                foreach (Student student in studentList)
                {
                    listBoxStudents.Add(student.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error opening StudentScores.bin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Exports the current students list as a formatted text file in the root directory.
        /// </summary>
        /// Pre: User clicks export
        /// Post: A formatted text file is created in the root directory.
        public static void ExportStudentsTxtFile()
        {
            string fileSavePathTxt = "StudentScoresExport.txt";
            int namePad = 20;
            int scoresPad = 50;
            int totalPad = 11;
            int avgPad = 4;

            // Generate a unique file name
            int counter = 1;
            while (File.Exists(fileSavePathTxt))
            {
                fileSavePathTxt = "StudentScoresExport" + counter + ".txt";
                ++counter;
            }

            // All this formatting feels wrong lol.
            using (FileStream fileStream = new FileStream(fileSavePathTxt, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    // Write Headers
                    // Left pad needs to be (total / 2) + (original string length / 2)
                    // Or total - length / 2 + length

                    //Date
                    streamWriter.WriteLine("Report Date: " + DateTime.Today.ToShortDateString());

                    // Student Name | Student Scores | Total | Average
                    string line = string.Format("{0} | {1} | {2} | {3}",
                            "Student Name".PadRight(namePad),
                            "Student Scores".PadLeft(scoresPad / 2 + 7).PadRight(scoresPad),
                            "Total".PadLeft(totalPad / 2 + 3).PadRight(totalPad),
                            "Average".PadLeft(avgPad));
                    streamWriter.WriteLine(line);

                    // Write seperator
                    for (int i = 0; i < line.Length; ++i)
                    {
                        streamWriter.Write("-");
                    }
                    streamWriter.Write("\n");

                    // Write each student
                    foreach (Student student in studentList)
                    {
                        int scoresLength = student.StudentScores.ToString().Length;
                        int scoresPadLeft = (scoresPad - scoresLength) / 2 + scoresLength;
                        int totalLength = student.StudentScores.Total.ToString().Length;
                        int totalPadLeft = (totalPad - totalLength) / 2 + totalLength;

                        line = string.Format("{0} | {1} | {2} | {3}",
                            student.Name.PadRight(namePad),
                            student.StudentScores.ToString().PadLeft(scoresPadLeft).PadRight(scoresPad),
                            student.StudentScores.Total.ToString().PadLeft(totalPadLeft).PadRight(totalPad),
                            student.StudentScores.Average.ToString().PadLeft(avgPad));

                        streamWriter.WriteLine(line);
                    }
                }
            }

            MessageBox.Show("Export successful", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Exports the current students list as a formatted csv file in the root directory.
        /// </summary>
        /// Pre: User clicks export
        /// Post: A formatted Csv file is created in the root directory.
        public static void ExportStudentsCsv()
        {
            string fileSavePathTxt = "StudentScoresExport.csv";

            int counter = 1;
            while (File.Exists(fileSavePathTxt))
            {
                fileSavePathTxt = "StudentScoresExport" + counter + ".csv";
                counter++;
            }

            using (FileStream fileStream = new FileStream(fileSavePathTxt, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Report Date: ," + DateTime.Today.ToShortDateString());
                    streamWriter.WriteLine("Student Name, Student Scores, Total, Average");

                    foreach (Student student in studentList)
                    {
                        string line = string.Format("{0},{1},{2},{3}",
                            student.Name,
                            student.StudentScores.ToString().Replace(",", " | "),
                            student.StudentScores.Total.ToString(),
                            student.StudentScores.Average.ToString());
                        streamWriter.WriteLine(line);
                    }


                }
            }
            MessageBox.Show("Export successful", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
