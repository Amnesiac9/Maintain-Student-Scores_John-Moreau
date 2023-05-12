using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int score;
            // Parse score and add it to an array
            if(!int.TryParse(textBoxScore.Text, out score) || score < 0 || score > 100)
            {
                //error
                MessageBox.Show("Please enter a valid score from 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Concat to scores
            string scores = labelScoresTxt.Text + " " + score.ToString();
            
            // update scores label
            labelScoresTxt.Text = scores;

            // Focus the score entry text box
            //textBoxScore.Focus();
            textBoxScore.SelectAll();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear the label text;
            labelScoresTxt.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Check if user entered a valid name. Empty scores is ok.
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                // Error if no name or white space is entered.
                MessageBox.Show("Please enter a valid Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Concat new student with the name + scores with spaces replaced with |
            string newStudent = textBoxName.Text + labelScoresTxt.Text.Replace(" ", "|");

            // Set the tag to this new student string to export it back to the main form.
            this.Tag = newStudent;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            this.DialogResult = DialogResult.OK;
        }
    }
}
