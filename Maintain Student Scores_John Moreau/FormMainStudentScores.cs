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

/* 
 * John Moreau
 * CSS133
 * 5/9/2023
 * 
 * Windows form app for maintaining a record of student scores.
 * 
 * SOURCES:
 * Adding DPI Awareness to fix fuzzy text: https://stackoverflow.com/questions/1553235/to-show-a-new-form-on-click-of-a-button-in-c-sharp
 * 
 */



namespace Maintain_Student_Scores_John_Moreau
{
    public partial class FormMainStudentScores : Form
    {

        // Global file to save scores
        public static string fileSavePath = "StudentScores.bin";

        public FormMainStudentScores()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadStudentScores();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD STUDENT BUTTON //
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var formAddStudent = new FormAddStudent(); // Create new add Student Form

            DialogResult dialogResult = formAddStudent.ShowDialog();

            // await OK response and valid tag
            if (dialogResult == DialogResult.OK && formAddStudent.Tag != null)
            {
                // Add the student string passed in the tag from the add student form.
                // Source: Chapter 10 of the Murach's C# book.
                listBoxStudents.Items.Add(formAddStudent.Tag.ToString());
                SaveStudentScores();
            }

            
        }

        // UPDATE STUDENT BUTTON //
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if(listBoxStudents.SelectedItem == null)
            {
                return;
            }

            var formUpdateStudent = new FormUpdateStudentScores(); // Create new update Student Form

            //Pass the selected data to the new form
            formUpdateStudent.GetStudentData(listBoxStudents.SelectedItem.ToString());

            // Await dialog Result
            DialogResult dialogResult = formUpdateStudent.ShowDialog();

            if (dialogResult == DialogResult.OK && formUpdateStudent.Tag != null)
            {
                // Get the index of selected student
                int studentIndex = listBoxStudents.SelectedIndex;

                // Add the student string passed in the tag from the add student form.
                // Source: Chapter 10 of the Murach's C# book.
                string updatedStudent = formUpdateStudent.Tag.ToString();
                
                listBoxStudents.Items.RemoveAt(studentIndex); // Remove at the originally selected index
                listBoxStudents.Items.Insert(studentIndex, updatedStudent); // Update at index
                SaveStudentScores(); // Save scores to bin
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Get which item is selected in the list box, cast to string
            string student = listBoxStudents.SelectedItem.ToString();
            // string student = (string)listBoxStudents.SelectedItem; also works
            listBoxStudents.Items.Remove(student);
            SaveStudentScores();
        }





        // Helper Functions
        public void LoadStudentScores() // Load from Binary
        {
           
            // Make sure it exists
            if (!File.Exists(fileSavePath))
            {
                // If not, create it.
                SaveStudentScores();
                //MessageBox.Show("Error loading student scores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load the contents of the file into an array of strings
            string[] studentScores; // Using a simple array of strings this time.
            using (FileStream stream = new FileStream(fileSavePath, FileMode.Open))
            {
                // Create new binary formatter to convert to bin
                BinaryFormatter formatter = new BinaryFormatter();
                // deserialize and cast to the student scores string[]
                // Need to put (string[]) here because formatter will return an object but we want a string[]
                studentScores = (string[])formatter.Deserialize(stream);
            }

            // Clear list box and add each student to the list box
            this.listBoxStudents.Items.Clear();

            foreach (string student in studentScores)
            {
                listBoxStudents.Items.Add(student);
            }

        }

        public void AddStudent(string student)
        {
                // Add student string to the list box
                listBoxStudents.Items.Add(student);
        }

        public void SaveStudentScores()
        {   
            // Create a new string array with the same size as our list box
            string[] studentScores = new string[listBoxStudents.Items.Count];

            // Loop through each item in our list box and add to array.
            for (int i = 0; i < listBoxStudents.Items.Count; i++)
            {
                studentScores[i] = listBoxStudents.Items[i].ToString();
            }

            // Serialize to a binary file.
            // https://www.codeproject.com/questions/500398/saveplusfileplusinplusbinaryplususingplusc-23
            using (FileStream stream = new FileStream(fileSavePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter(); // IDK why it wouldn't let me do a "using" here, doesn't need to be disposed of?
                formatter.Serialize(stream, studentScores);    
            }

        }
    }
}
