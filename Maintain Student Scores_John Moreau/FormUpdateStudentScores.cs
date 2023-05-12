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
    public partial class FormUpdateStudentScores : Form
    {
        public FormUpdateStudentScores()
        {
            InitializeComponent();
        }

        // Bring in data from main form

        public void GetStudentData(string student)
        {
            //student.Split("|");
            string[] currentStudent = student.Split('|'); // need to use '' here???

            // Add the name
            labelNameTxt.Text = currentStudent[0]; // Name

            // Add the scores // need to use length -1 to avoid added white space from split function
            for (int i = 1; i < currentStudent.Length - 1; i++) 
            {
                listBoxScores.Items.Add(currentStudent[i]);
            }
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            // Loop through scores list box and concat

            string newStudentScores = "|";
            for (int i = 0; i < listBoxScores.Items.Count; i++)
            {
                newStudentScores += listBoxScores.Items[i] + "|";
            }
            

            // Concat new student with the name + scores with spaces replaced with |
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
            }
        }
    }
}
