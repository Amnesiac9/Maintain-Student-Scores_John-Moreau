using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * John Moreau
 * CSS133
 * 5/12/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    public partial class FormUpdateStudentScores : Form
    {
        public FormUpdateStudentScores()
        {
            InitializeComponent();
        }

        // Bool to check if changes were made, could put this in a method
        bool changesMade = false;

        // To hold our student being worked on

        public static Student CurrentStudent;


        // Bring in data from main form
        public void GetStudentData(Student student)
        {
            //student.Split("|");
            //string[] currentStudent = student.Split('|'); // need to use '' here???

            // Add the name
            labelNameTxt.Text = student.Name; // Name

            // Add the scores starting at index 1 to skip name
            for (int i = 0; i < student.StudentScores.Count; i++) 
            {
                listBoxScores.Items.Add(student.StudentScores.ScoresArray[i].ToString());
            }

            CurrentStudent = student;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            // Loop through scores and add to array
            int[] newScores = new int[listBoxScores.Items.Count];
            for (int i = 0; i < listBoxScores.Items.Count; ++i)
            {
                if(int.TryParse(listBoxScores.Items[i].ToString(), out int score))
                {
                    newScores[i] = score;
                }
            }

            // Set the current working student's scores to the new array
            CurrentStudent.StudentScores = new Scores(newScores);
            // Set the name
            CurrentStudent.Name = labelNameTxt.Text;

            // Set the tag to this new student string to export it back to the main form.
            Tag = CurrentStudent;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            DialogResult = DialogResult.OK;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open a form for adding a new score
            var formAddScore = new FormAddScore();
            DialogResult dialogResult = formAddScore.ShowDialog();
            
            // Make sure we get an OK response and a valid score in the tag
            if (dialogResult == DialogResult.OK && formAddScore.Tag != null)
            {
                // Add the new score to our working score list box.
                listBoxScores.Items.Add(formAddScore.Tag.ToString());

                // Update our changes made bool;
                changesMade = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Make sure we are selecting a score
            if (listBoxScores.SelectedItem == null)
            {
                return;
            }

            // Find index of selected item
            int index = listBoxScores.SelectedIndex;


            // Create new update score dialogue 
            var formUpdateScore = new FormUpdateScore();
            formUpdateScore.GetScoreData(listBoxScores.SelectedItem.ToString());
            DialogResult dialogResult = formUpdateScore.ShowDialog();


            if (dialogResult == DialogResult.OK && formUpdateScore.Tag != null)
            {
                // Need to find index of selected and replace.
                listBoxScores.Items.RemoveAt(index);
                listBoxScores.Items.Insert(index, formUpdateScore.Tag.ToString());
                
                // Update our changes made bool;
                changesMade = true;
            }

            // Set the selected item back to index
            listBoxScores.SelectedIndex = index;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Make sure we are selecting a score
            if (listBoxScores.SelectedItem == null)
            {
                return;
            }

            // Get the index of our selected item
            int index = listBoxScores.SelectedIndex;

            // Remove the selected score
            listBoxScores.Items.RemoveAt(index);

            // Update our changes made bool;
            changesMade = true;

            // Check if our index would fall off the end
            if (index > listBoxScores.Items.Count - 1)
            {
                //If yes, set the selected item back to index - 1
                listBoxScores.SelectedIndex = index - 1;
            }
            else
            {
                // Keep the current index selected
                listBoxScores.SelectedIndex = index;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Create a dialog box to confirm
            DialogResult eraseAllScores = MessageBox.Show("Are you sure you want to erase all scores?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); ;
            
            // Return if the answer is not OK
            if (eraseAllScores != DialogResult.OK)
            {
                return;
            }
            
            // If we make it here, the answer was yes
            listBoxScores.Items.Clear();
            // Update our changes made bool;
            changesMade = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            

            if (changesMade == true)
            {
                // Create a dialog box to confirm
                DialogResult eraseAllScores = MessageBox.Show("Are you sure you want to discard your updates?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); ;

                // Return if the answer is no
                if (eraseAllScores != DialogResult.OK)
                {
                    // Set the dialog result of the overall form to NONE
                    // This prevents the cancel button we clicked from closing the form anyway.
                    // This is needed because the default cancel button always sends a dialogresult of Cancel so we need to delete it before it causes the form to close.
                    DialogResult = DialogResult.None;
                    return;
                }
            }


            // If they clicked OK then this.Close() isn't needed because they clicked cancel
            // Which, if it is set as the Cancel Button in the form properties, will always
            // send a DialogResult.Cancel which sends the response to the underlying form.
            // this.Close();

        }

        private void buttonEditName_Click(object sender, EventArgs e)
        {
            // New edit name form
            var formEditName = new FormEditName();

            // Pass the current student name to the new form
            formEditName.GetStudentName(labelNameTxt.Text);

            // Open the new dialog
            DialogResult dialogResult = formEditName.ShowDialog();

            // Make sure the user pressed OK and that the form returned a valid tag
            if (dialogResult == DialogResult.OK && formEditName.Tag != null)
            {
                // Add the new score to our working score list box.
                labelNameTxt.Text = formEditName.Tag.ToString();

                // Update our changes made bool;
                changesMade = true;
            }
        }
    }
}
