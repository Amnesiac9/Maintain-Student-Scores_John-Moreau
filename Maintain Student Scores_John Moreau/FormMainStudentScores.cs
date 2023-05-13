﻿using System;
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



namespace Maintain_Student_Scores_John_Moreau
{
    public partial class FormMainStudentScores : Form
    {

        public FormMainStudentScores()
        {
            InitializeComponent();
        }

        // Global file to save scores
        public static string fileSavePath = "StudentScores.bin";
        // Global index of the top student
        int topStudentIndex;

        private void CreatorIntro()
        {
            MessageBox.Show("Creator: John Moreau\n\n" +
                "About: This program was created for Robin Greene's C# Class at WWCC.\n\n" +
                "Description: Save and manage a record of student names and scores.\n\n" +
                "Version: 1.0\n", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreatorIntro();
            LoadStudentScores();
            GetTopStudent();
        }

        // EXIT BUTTON //
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                listBoxStudents.Items.Add(formAddStudent.Tag.ToString());
                SaveStudentScores();
                GetTopStudent();
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

            var formUpdateStudent = new FormUpdateStudentScores(); // Create new update Student Form

            // Pass the selected data to the new form
            formUpdateStudent.GetStudentData(listBoxStudents.SelectedItem.ToString());

            // Await dialog Result
            DialogResult dialogResult = formUpdateStudent.ShowDialog();

            if (dialogResult == DialogResult.OK && formUpdateStudent.Tag != null)
            {
                // Add the student string passed in the tag from the add student form.
                // Source: Chapter 10 of the Murach's C# book.
                string updatedStudent = formUpdateStudent.Tag.ToString();
                
                listBoxStudents.Items.RemoveAt(studentIndex); // Remove at the originally selected index
                listBoxStudents.Items.Insert(studentIndex, updatedStudent); // Update at index
                SaveStudentScores(); // Save scores to bin
            }

            listBoxStudents.SelectedIndex = studentIndex;
            GetTopStudent();

        }

        // DELETE BUTTON //
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Show a warning message before deleting students
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.OK)
            {
                // If the user doesn't press OK, simply return
                return;
            }

            // Remove the selected item
            listBoxStudents.Items.RemoveAt(listBoxStudents.SelectedIndex);
            // Save scores to bin
            SaveStudentScores();
            GetTopStudent();
        }

        // Find top student button //
        private void buttonFindTopStudent_Click(object sender, EventArgs e)
        {
            // Make sure the top student has been found and an index has been saved
            if (labelTopStudentNameTxt.Text == "" || topStudentIndex < 0)
            {
                return;
            }
            // Set the selected index to the top student index
            listBoxStudents.SelectedIndex = topStudentIndex;
        }




        // Helper Functions //
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

            // Open file stream
            using (FileStream stream = new FileStream(fileSavePath, FileMode.Open))
            {
                // Create new binary formatter to convert to bin
                // https://stackoverflow.com/questions/32108996/deserialize-object-from-binary-file
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

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check for nothing selected
            if (listBoxStudents.SelectedItem == null)
            {
                // Reset labels
                labelScoreTotalTxt.Text = "";
                labelScoreCountTxt.Text = "";
                labelAverageTxt.Text = "";
                return;
            }

            // Pull Student String and split into an array
            string[] currentStudent = listBoxStudents.SelectedItem.ToString().Split('|'); // No idea why you have to use '' here

            // Check if we have any scores to calculate
            if (currentStudent.Length <= 1)
            {
                labelScoreTotalTxt.Text = "0";
                labelScoreCountTxt.Text = "0";
                labelAverageTxt.Text = "0";
                return;
            }

            // Get our numbers
            // Score count is just the student length minus one since we exclude the name part of the array
            int scoreCount = currentStudent.Length - 1;

            // Add up the total from the name onwards
            int scoreTotal = 0;
            for (int i = 1; i < currentStudent.Length; ++i)
            {
                // Make sure it's a number
                if (int.TryParse(currentStudent[i], out int score))
                {
                    scoreTotal += score;
                }
            }

            // Calculate average
            int scoreAverage = scoreTotal / scoreCount;

            // Update Labels
            labelScoreTotalTxt.Text = scoreTotal.ToString();
            labelScoreCountTxt.Text = scoreCount.ToString();
            labelAverageTxt.Text = scoreAverage.ToString();
        }

        // This could get improved to only call if the current best is deleted or beaten by a new or updated student
        private void GetTopStudent() 
        {

            // Make sure we have students listed.
            if (listBoxStudents.Items == null)
            {
                return;
            }

            // Variables
            string bestStudent = "";
            int bestStudentAverage = 0;
            int bestStudentTotal = 0;
            int index = 0;

            // Loop through list box items
            foreach(string student in listBoxStudents.Items)
            {
                // Pull Student String and split into an array
                string[] currentStudent = student.Split('|');

                // Check if we have any scores to calculate
                if (currentStudent.Length <= 1)
                {
                    // Increment our index to keep track
                    index++;
                    continue;
                }

                // Get our numbers
                // Score count is just the student length minus one since we exclude the name part of the array
                int scoreCount = currentStudent.Length - 1;

                // Add up the total from the name onwards
                int scoreTotal = 0;
                for (int i = 1; i < currentStudent.Length; ++i)
                {
                    if (int.TryParse(currentStudent[i], out int score))
                    {
                        scoreTotal += score;
                    }
                }


                int scoreAverage = scoreTotal / scoreCount;

                // Check if this is our best
                if (scoreAverage > bestStudentAverage || 
                    // Also check if they are equal, then the best score wins
                   (scoreAverage == bestStudentAverage && scoreTotal > bestStudentTotal))
                {
                    bestStudentTotal = scoreTotal;
                    bestStudentAverage = scoreAverage;
                    bestStudent = currentStudent[0];
                    topStudentIndex = index;
                }


                // Increment our index to keep track
                index++;
            }

            // Set labels
            labelTopStudentNameTxt.Text = bestStudent;
            labelTopStudentAverageTxt.Text = bestStudentAverage.ToString();

        }


    }
}
