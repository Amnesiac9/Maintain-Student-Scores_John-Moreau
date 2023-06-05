using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintain_Student_Scores_John_Moreau
{
    internal class StudentDB
    {

        // Global file to save scores
        public static string fileSavePathBin = "StudentScores.bin";

        public static void LoadStudentsTxtFile(ListBox.ObjectCollection listBoxStudents, ref bool ChangesMade)
        {
            string fileSavePathTxt = "StudentScores.txt";

            if (!File.Exists(fileSavePathTxt))
            {
                MessageBox.Show("Error reading StudentScores.txt File.", "Error");
                return;
            }

            string[] students = File.ReadAllLines(fileSavePathTxt);

            foreach (string student in students)
            {
                listBoxStudents.Add(student);
            }

            ChangesMade = true;
        }

        // Function to generate our list from the initial default ListBox
        // pre: a listbox with student names and scores
        // post: a list of students with names and scores as objects

        public static void SplitNamesAndScoresToList(ListBox.ObjectCollection listBoxStudents)
        {


            foreach (string student in listBoxStudents)
            {
                string[] currentStudent = student.Split('|');
                if (currentStudent.Length <= 1)
                {
                    Student newStudentNoScores = new Student(currentStudent[0]);
                    FormMainStudentScores.StudentList.Add(newStudentNoScores);
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
                FormMainStudentScores.StudentList.Add(newStudent);
            }
        }

        // Function to Save the student list to a binary file.
        // pre: A List<Student> to save.
        // post: The student scores are serlialized from the list and saved to a bin file.
        public static void SaveStudentScores(ref bool ChangesMade)
        {
            // Serialize the StudentList to a binary file.
            // https://www.codeproject.com/questions/500398/saveplusfileplusinplusbinaryplususingplusc-23
            using (FileStream stream = new FileStream(fileSavePathBin, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter(); // IDK why it wouldn't let me do a "using" here, doesn't need to be disposed of?
                try
                {
                    formatter.Serialize(stream, FormMainStudentScores.StudentList);
                    ChangesMade = false;
                    MessageBox.Show("Data saved succesfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error saving data to file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        // Function to load the student scores from a bin file (or create the file if it doesn't exist).
        // pre: none
        // post: student scores are loaded from a binary file into the list box
        public static void LoadStudentScores(ListBox.ObjectCollection listBoxStudents, ref bool ChangesMade) // Load from Binary
        {

            // Make sure it exists
            if (!File.Exists(fileSavePathBin))
            {

                // Load a text file that contains the student scores into the listboxStudents.Items
                StudentDB.LoadStudentsTxtFile(listBoxStudents, ref ChangesMade);
                // Load the intial strings from the list box to our List of students
                StudentDB.SplitNamesAndScoresToList(listBoxStudents); // TODO: Read this from text file instead
                //SaveStudentScores();
                return;
            }

            // Open file stream
            using (FileStream stream = new FileStream(fileSavePathBin, FileMode.Open))
            {
                // Create new binary formatter to convert to bin
                // https://stackoverflow.com/questions/32108996/deserialize-object-from-binary-file
                BinaryFormatter formatter = new BinaryFormatter();
                // deserialize and cast to a student list which includes their scores.
                FormMainStudentScores.StudentList = (List<Student>)formatter.Deserialize(stream);
            }

            // Clear list box and add each student to the list box
            listBoxStudents.Clear();

            foreach (Student student in FormMainStudentScores.StudentList)
            {
                listBoxStudents.Add(student.ToString());
            }

        }
    }
}
