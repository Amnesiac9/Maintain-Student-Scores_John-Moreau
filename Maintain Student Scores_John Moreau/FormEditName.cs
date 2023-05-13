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
 * 5/12/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    public partial class FormEditName : Form
    {
        public FormEditName()
        {
            InitializeComponent();
        }

        public void GetStudentName(string student)
        {

            // Clear any previous
            textBoxName.Clear();

            // Add the name
            textBoxName.Text = student; // Name

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string text = textBoxName.Text;

            // Get name text and make sure it's valid
            if (string.IsNullOrWhiteSpace(text) || textBoxName.Text.Contains("|"))
            {
                // Error Message.
                MessageBox.Show("Please enter a valid student name, '|' not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Make sure we don't close out of the editing student name form
                this.DialogResult = DialogResult.None;
                return;
            }

            // Set the tag to this new student string to export it back to the main form.
            this.Tag = text;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            this.DialogResult = DialogResult.OK;

        }

    }
}
