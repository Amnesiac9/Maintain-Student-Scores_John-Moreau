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
 * 6/5/2023
 * 
 * 
 */

namespace Maintain_Student_Scores_John_Moreau
{
    /// <summary>
    /// For for editing the student name. Validates the text input and sets the student name if the user presses ok.
    /// </summary>
    public partial class FormEditName : Form
    {
        public FormEditName()
        {
            InitializeComponent();
            this.KeyDown += FormEditName_KeyDown;
        }

        private void FormEditName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.X && e.Modifiers == Keys.Alt)
            {
                buttonCancel.PerformClick();
            }
        }

        public void GetStudentName(string student)
        {

            // Clear any previous
            //textBoxName.Clear();

            // Add the name
            textBoxName.Text = student; // Name

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string text = textBoxName.Text.Trim();

            // Get name text and make sure it's valid
            if (string.IsNullOrWhiteSpace(text) || textBoxName.Text.Contains("|"))
            {
                // Error Message.
                MessageBox.Show("Please enter a valid student name, '|' not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Refocus text box
                textBoxName.SelectAll();
                textBoxName.Focus();

                // Make sure we don't close out of the editing student name form
                this.DialogResult = DialogResult.None;
                return;
            }

            if (!Validator.IsValidLength(textBoxName.Text, 1, 30))
            {
                MessageBox.Show("Please enter a valid Student Name, maximum length is 30.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                textBoxName.SelectAll();
                textBoxName.Focus();
                return;
            }


            // Set the tag to this new student string to export it back to the main form.
            this.Tag = text;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            this.DialogResult = DialogResult.OK;

        }

    }
}
