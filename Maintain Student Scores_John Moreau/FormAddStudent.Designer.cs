﻿namespace Maintain_Student_Scores_John_Moreau
{
    partial class FormAddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelScores = new System.Windows.Forms.Label();
            this.labelScoresTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = "Field to enter a student name";
            this.textBoxName.AccessibleName = "Student Name";
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Location = new System.Drawing.Point(59, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxScore
            // 
            this.textBoxScore.AccessibleDescription = "Field to enter a score to add to the list of scores for a student";
            this.textBoxScore.AccessibleName = "Student Score";
            this.textBoxScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxScore.Location = new System.Drawing.Point(59, 66);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(90, 22);
            this.textBoxScore.TabIndex = 1;
            this.textBoxScore.Enter += new System.EventHandler(this.textBoxScore_Enter);
            this.textBoxScore.Leave += new System.EventHandler(this.textBoxScore_Leave);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.AccessibleDescription = "Add a score to the new student record";
            this.buttonAddScore.AccessibleName = "Add Score";
            this.buttonAddScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddScore.Location = new System.Drawing.Point(170, 65);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(101, 27);
            this.buttonAddScore.TabIndex = 2;
            this.buttonAddScore.Text = "&Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AccessibleDescription = "A button to clear all the current scores from a new student record";
            this.buttonClear.AccessibleName = "Clear Scores Button";
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClear.Location = new System.Drawing.Point(170, 145);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 27);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "&Clear Scores";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.AccessibleDescription = "Submit the new student to the main form";
            this.buttonOK.AccessibleName = "OK Button";
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(48, 184);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(101, 27);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleDescription = "Cancel adding a new student";
            this.buttonCancel.AccessibleName = "Cancel Button";
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(170, 184);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 27);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(9, 68);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(46, 16);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name:";
            // 
            // labelScores
            // 
            this.labelScores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScores.AutoSize = true;
            this.labelScores.Location = new System.Drawing.Point(4, 107);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(53, 16);
            this.labelScores.TabIndex = 7;
            this.labelScores.Text = "Scores:";
            // 
            // labelScoresTxt
            // 
            this.labelScoresTxt.AccessibleDescription = "A list showing the scores of the new student";
            this.labelScoresTxt.AccessibleName = "Scores List";
            this.labelScoresTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoresTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoresTxt.Location = new System.Drawing.Point(59, 106);
            this.labelScoresTxt.Name = "labelScoresTxt";
            this.labelScoresTxt.Size = new System.Drawing.Size(212, 25);
            this.labelScoresTxt.TabIndex = 10;
            this.labelScoresTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAddStudent
            // 
            this.AcceptButton = this.buttonOK;
            this.AccessibleDescription = "Form for adding a new student.";
            this.AccessibleName = "New Student Form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(282, 223);
            this.Controls.Add(this.labelScoresTxt);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxName);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 270);
            this.Name = "FormAddStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Label labelScoresTxt;
    }
}