using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * John Moreau
 * CSS133
 * 6/4/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{

    public partial class FormAddStudent : Form
    {

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            
            
            if(!Validator.IsInRange(textBoxScore.Text, 0, 100))
            {
                //error
                MessageBox.Show("Please enter a valid score from 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Refocus text box
                textBoxScore.SelectAll();
                textBoxScore.Focus();
                return;
            }

            // Parse score and add it to an array
            int score = int.Parse(textBoxScore.Text);

            // Concat to scores
            string scoresString = labelScoresTxt.Text + " " + score.ToString();
            
            // update scores label
            labelScoresTxt.Text = scoresString;

            // Focus the score entry text box
            textBoxScore.Focus();
            textBoxScore.SelectAll();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear the label text;
            labelScoresTxt.Text = "";
            textBoxScore.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Check if user entered a valid name. Empty scores is ok.
            if (!Validator.IsValidName(textBoxName.Text))
            {
                // Error if no name or white space is entered.
                MessageBox.Show("Please enter a valid Student Name, '|' not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Make sure to set the response to NONE so that the form doesn't close
                this.DialogResult = DialogResult.None;
                // Re-Focus the text box
                textBoxName.Focus();
                return;
            }

            //TODO: Use objects instead of strings

            // Concat new student with the name + scores with spaces replaced with |
            string newStudent = textBoxName.Text.Trim() + labelScoresTxt.Text.Replace(" ", "|");

            // Set the tag to this new student string to export it back to the main form.
            this.Tag = newStudent;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            this.DialogResult = DialogResult.OK;
        }


    }
}
