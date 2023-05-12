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

namespace Maintain_Student_Scores_John_Moreau
{
    public partial class FormUpdateStudentScores : Form
    {
        public FormUpdateStudentScores()
        {
            InitializeComponent();
        }

        // Bool to check if changes were made
        bool changesMade = false;


        // Bring in data from main form
        public void GetStudentData(string student)
        {
            //student.Split("|");
            string[] currentStudent = student.Split('|'); // need to use '' here???

            // Add the name
            labelNameTxt.Text = currentStudent[0]; // Name

            // Add the scores // need to use length -1 to avoid added white space from split function
            for (int i = 1; i < currentStudent.Length; i++) 
            {
                listBoxScores.Items.Add(currentStudent[i]);
            }
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {



            // Loop through scores list box and concat

            string newStudentScores = "";
            for (int i = 0; i < listBoxScores.Items.Count; i++)
            {
                newStudentScores += "|" + listBoxScores.Items[i];
            }
            

            // Concat new student with the name + scores
            newStudentScores = labelNameTxt.Text + newStudentScores;

            // Set the tag to this new student string to export it back to the main form.
            this.Tag = newStudentScores;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            this.DialogResult = DialogResult.OK;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAddScore = new FormAddScore();
            DialogResult dialogResult = formAddScore.ShowDialog();

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
                listBoxScores.SelectedIndex = index;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Create a dialog box to confirm
            DialogResult eraseAllScores = MessageBox.Show("Are you sure you want to erase all scores?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            
            // Return if the answer is no
            if (eraseAllScores == DialogResult.No)
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
                    // This prevents the cancel button we clicked from closing the form anyway =)
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }


            // If they clicked OK
            this.Close();

        }

        private void buttonEditName_Click(object sender, EventArgs e)
        {
            //TODO
            var formEditName = new FormEditName();
            DialogResult dialogResult = formEditName.ShowDialog();

            if (dialogResult == DialogResult.OK && formEditName.Tag != null)
            {
                // Add the new score to our working score list box.
                listBoxScores.Items.Add(formEditName.Tag.ToString());

                // Update our changes made bool;
                changesMade = true;
            }


            // Check if user entered a valid name. Empty scores is ok.
            //if (string.IsNullOrWhiteSpace(textBoxName.Text))
            //{
            //    // Error if no name or white space is entered.
            //    MessageBox.Show("Please enter a valid Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }
    }
}
