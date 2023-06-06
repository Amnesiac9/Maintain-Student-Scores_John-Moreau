using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using System.Reflection;

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
 * Change Log:
 * 
 * 5/31/23
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
 * Added StudentDB class to handle holding, saving and loading student data.
 * Now loads the intital students from a text file if the .bin file is not found.
 * Moved the GetTopStudent method to TopStudentRecord class.
 * Created a StudentList class to hold a list of students that auto sorts when a new student is added.
 * Added a FirstName and LastName property to the Student class to allow sorting by last name.
 * Now asks to confirm exiting if changes were made to the student records.
 * 
 * 
 */


namespace Maintain_Student_Scores_John_Moreau
{
    /// <summary>
    /// Windows form app for maintaining a record of student scores.
    /// Allows adding, updating, and deleting student records.
    /// Allows exporting to Txt and Csv format.
    /// </summary>
    public partial class FormMainStudentScores : Form
    {

        // Bool to track if changes have been made to the students list
        private static bool ChangesMade = false;

        public FormMainStudentScores()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreatorIntro();
            StudentDB.LoadStudentScores(listBoxStudents.Items, ref ChangesMade);
            TopStudentRecord.GetTopStudent(labelTopStudentNameTxt, labelTopStudentAverageTxt);
        }
        private void CreatorIntro()
        {
            // Show about box
            new AboutBox().ShowDialog();
        }

        // EXIT BUTTON //
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if(ChangesMade == false)
            {
                this.Close();
                return;
            }
            // Show message box to confirm exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit without saving?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ADD STUDENT BUTTON //
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            // Create new add Student Form
            var formAddStudent = new FormAddStudent(); 

            // Show the form and store the result/response in a variable
            DialogResult dialogResult = formAddStudent.ShowDialog();

            // await OK response and valid tag
            if (dialogResult == DialogResult.OK && formAddStudent.Tag != null)
            {
                // Add the student string passed back in the tag from the add student form.
                // Source: Chapter 10 of the Murach's C# book.
                Student newStudent = new Student(formAddStudent.Tag.ToString());
                StudentDB.studentList.Add(newStudent);
                int newStudentIndex = StudentDB.studentList.IndexOf(newStudent);
                listBoxStudents.Items.Insert(newStudentIndex, formAddStudent.Tag.ToString());

                TopStudentRecord.GetTopStudent(labelTopStudentNameTxt, labelTopStudentAverageTxt);
                ChangesMade = true;
            }
        }

        // UPDATE STUDENT BUTTON //
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if(listBoxStudents.SelectedItem == null)
            {
                return;
            }

            // Get the index of selected student
            int studentIndex = listBoxStudents.SelectedIndex;
            // Get selected Student
            Student selectedStudent = StudentDB.studentList[studentIndex];

            // Create new update Student Form
            var formUpdateStudent = new FormUpdateStudent(); 
            // Pass the selected student to the new form 
            // No reason to use a clone here, sending the selected student this way already makes a copy in memory.
            formUpdateStudent.GetStudentData(selectedStudent);
            // Await dialog Result
            DialogResult dialogResult = formUpdateStudent.ShowDialog(); 

            if (dialogResult == DialogResult.OK && formUpdateStudent.Tag != null)
            {
                // Cast returned tag as a Student object, set the original selected student to = the returned object.
                selectedStudent = (Student)formUpdateStudent.Tag;
                StudentDB.studentList.Sort();
                int newStudentIndex = StudentDB.studentList.IndexOf(selectedStudent);

                // Remove at the originally selected index
                listBoxStudents.Items.RemoveAt(studentIndex);
                // Insert into the listbox at the new student index now that the list is sorted.
                listBoxStudents.Items.Insert(newStudentIndex, selectedStudent.ToString()); 
                

                TopStudentRecord.GetTopStudent(labelTopStudentNameTxt, labelTopStudentAverageTxt);
                ChangesMade = true;
            }

            listBoxStudents.SelectedIndex = studentIndex;
            
        }

        // DELETE BUTTON //
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Make sure we selected a student
            if (listBoxStudents.SelectedItem == null)
            {
                return;
            }

            // Show a warning message before deleting students
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.OK)
            {
                // If the user doesn't press OK, simply return
                return;
            }

            int selectedIndex = listBoxStudents.SelectedIndex;
            // Remove the selected item
            listBoxStudents.Items.RemoveAt(selectedIndex);
            // Remove item from our list
            StudentDB.studentList.RemoveAt(selectedIndex);

            // Set our selected index to the next item in the list
            listBoxStudents.SelectedIndex = selectedIndex - 1;

            TopStudentRecord.GetTopStudent(labelTopStudentNameTxt, labelTopStudentAverageTxt);
            ChangesMade = true;
        }

        // FIND TOP STUDENT BUTTON //
        private void buttonFindTopStudent_Click(object sender, EventArgs e)
        {
            // Make sure the top student has been found and an index has been saved
            if (labelTopStudentNameTxt.Text == "")
            {
                return;
            }
            // Set the selected index to the top student index
            listBoxStudents.SelectedIndex = TopStudentRecord.TopStudentIndex;
        }

        // Students List Box Index Changed Event //
        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check for nothing selected
            if (listBoxStudents.SelectedItem == null)
            {
                // Clear labels
                labelScoreTotalTxt.Text = "";
                labelScoreCountTxt.Text = "";
                labelAverageTxt.Text = "";
                return;
            }

            // Get the currently selected student
            Student selectedStudent = StudentDB.studentList[listBoxStudents.SelectedIndex];

            // Set the labels
            labelScoreCountTxt.Text = selectedStudent.StudentScores.Count.ToString();
            labelScoreTotalTxt.Text = selectedStudent.StudentScores.Total.ToString();
            labelAverageTxt.Text = selectedStudent.StudentScores.Average.ToString();
            labelRecordCreationDateTxt.Text = selectedStudent.RecordStartDate.ToString();
            labelSelectedStudentIdText.Text = selectedStudent.StudentId;

        }

        // SAVE BUTTON //
        private void buttonSave_Click(object sender, EventArgs e)
        {
            StudentDB.SaveStudentScores(ref ChangesMade);
        }

        // EXPORT BUTTON //
        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.Items.Count <= 0)
            {
                MessageBox.Show("Nothing to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ComBoxExportFileType.Text == "txt")
            {
                StudentDB.ExportStudentsTxtFile();
                return;
            }
            
            if (ComBoxExportFileType.Text == "csv")
            {
                StudentDB.ExportStudentsCsv();                
                return;
            }
            

        }

    }
}
