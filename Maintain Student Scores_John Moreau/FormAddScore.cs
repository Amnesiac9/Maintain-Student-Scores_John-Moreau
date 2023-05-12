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
    public partial class FormAddScore : Form
    {
        public FormAddScore()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int score;
            // Parse score and add it to an array
            if (!int.TryParse(textBoxScore.Text, out score) || score < 0 || score > 100)
            {
                //error
                MessageBox.Show("Please enter a valid score from 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set the tag to this new student string to export it back to the main form.
            this.Tag = score;

            // Set the result to OK to trigger this form closing and sending data back to main form.
            this.DialogResult = DialogResult.OK;

        }
    }
}
