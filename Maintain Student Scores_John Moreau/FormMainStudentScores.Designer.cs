namespace Maintain_Student_Scores_John_Moreau
{
    partial class FormMainStudentScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainStudentScores));
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelScoreTotal = new System.Windows.Forms.Label();
            this.labelScoreCount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelScoreTotalTxt = new System.Windows.Forms.Label();
            this.labelScoreCountTxt = new System.Windows.Forms.Label();
            this.labelAverageTxt = new System.Windows.Forms.Label();
            this.labelTopStudent = new System.Windows.Forms.Label();
            this.labelTopStudentNameTxt = new System.Windows.Forms.Label();
            this.labelTopStudentAverage = new System.Windows.Forms.Label();
            this.labelTopStudentAverageTxt = new System.Windows.Forms.Label();
            this.labelSelectedStudentDate = new System.Windows.Forms.Label();
            this.labelRecordCreationDateTxt = new System.Windows.Forms.Label();
            this.labelSelectedStudentId = new System.Windows.Forms.Label();
            this.labelSelectedStudentIdText = new System.Windows.Forms.Label();
            this.labelExport = new System.Windows.Forms.Label();
            this.ComBoxExportFileType = new System.Windows.Forms.ComboBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFindTopStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.AccessibleDescription = "Add a new student record";
            this.buttonAddStudent.AccessibleName = "Add New";
            this.buttonAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStudent.Location = new System.Drawing.Point(405, 71);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(88, 29);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "&Add New...";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.AccessibleDescription = "A box containing a list of students and their scores.";
            this.listBoxStudents.AccessibleName = "Student List Box";
            this.listBoxStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(31, 52);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(356, 164);
            this.listBoxStudents.TabIndex = 4;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudents.Location = new System.Drawing.Point(28, 28);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(59, 16);
            this.labelStudents.TabIndex = 5;
            this.labelStudents.Text = "Students";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleDescription = "Update a student record";
            this.buttonUpdate.AccessibleName = "Update Student";
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(405, 106);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 29);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update...";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleDescription = "Delete a student record.";
            this.buttonDelete.AccessibleName = "Delete Student";
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(405, 141);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 29);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AccessibleDescription = "Button to exit the program.";
            this.buttonExit.AccessibleName = "Exit";
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(405, 324);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 29);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelScoreTotal
            // 
            this.labelScoreTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreTotal.AutoSize = true;
            this.labelScoreTotal.Location = new System.Drawing.Point(231, 274);
            this.labelScoreTotal.Name = "labelScoreTotal";
            this.labelScoreTotal.Size = new System.Drawing.Size(74, 16);
            this.labelScoreTotal.TabIndex = 12;
            this.labelScoreTotal.Text = "Score total:";
            // 
            // labelScoreCount
            // 
            this.labelScoreCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreCount.AutoSize = true;
            this.labelScoreCount.Location = new System.Drawing.Point(224, 302);
            this.labelScoreCount.Name = "labelScoreCount";
            this.labelScoreCount.Size = new System.Drawing.Size(81, 16);
            this.labelScoreCount.TabIndex = 13;
            this.labelScoreCount.Text = "Score count:";
            // 
            // labelAverage
            // 
            this.labelAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(243, 330);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(62, 16);
            this.labelAverage.TabIndex = 14;
            this.labelAverage.Text = "Average:";
            // 
            // labelScoreTotalTxt
            // 
            this.labelScoreTotalTxt.AccessibleDescription = "Currently selected student\'s score total";
            this.labelScoreTotalTxt.AccessibleName = "Score Total";
            this.labelScoreTotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreTotalTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoreTotalTxt.Location = new System.Drawing.Point(311, 270);
            this.labelScoreTotalTxt.Name = "labelScoreTotalTxt";
            this.labelScoreTotalTxt.Size = new System.Drawing.Size(73, 25);
            this.labelScoreTotalTxt.TabIndex = 15;
            this.labelScoreTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScoreCountTxt
            // 
            this.labelScoreCountTxt.AccessibleDescription = "A count of the currently selected student\'s scores.";
            this.labelScoreCountTxt.AccessibleName = "Score Count";
            this.labelScoreCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreCountTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoreCountTxt.Location = new System.Drawing.Point(311, 298);
            this.labelScoreCountTxt.Name = "labelScoreCountTxt";
            this.labelScoreCountTxt.Size = new System.Drawing.Size(73, 25);
            this.labelScoreCountTxt.TabIndex = 16;
            this.labelScoreCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAverageTxt
            // 
            this.labelAverageTxt.AccessibleDescription = "The average of the currently selected student\'s scores.";
            this.labelAverageTxt.AccessibleName = "Average";
            this.labelAverageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAverageTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageTxt.Location = new System.Drawing.Point(311, 326);
            this.labelAverageTxt.Name = "labelAverageTxt";
            this.labelAverageTxt.Size = new System.Drawing.Size(73, 25);
            this.labelAverageTxt.TabIndex = 17;
            this.labelAverageTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTopStudent
            // 
            this.labelTopStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopStudent.AutoSize = true;
            this.labelTopStudent.Location = new System.Drawing.Point(28, 270);
            this.labelTopStudent.Name = "labelTopStudent";
            this.labelTopStudent.Size = new System.Drawing.Size(80, 16);
            this.labelTopStudent.TabIndex = 18;
            this.labelTopStudent.Text = "Top Student";
            // 
            // labelTopStudentNameTxt
            // 
            this.labelTopStudentNameTxt.AccessibleDescription = "The name of the top student. Sorted by Average Score.";
            this.labelTopStudentNameTxt.AccessibleName = "Top Student";
            this.labelTopStudentNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopStudentNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTopStudentNameTxt.Location = new System.Drawing.Point(31, 294);
            this.labelTopStudentNameTxt.Name = "labelTopStudentNameTxt";
            this.labelTopStudentNameTxt.Size = new System.Drawing.Size(169, 25);
            this.labelTopStudentNameTxt.TabIndex = 19;
            this.labelTopStudentNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTopStudentAverage
            // 
            this.labelTopStudentAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopStudentAverage.AutoSize = true;
            this.labelTopStudentAverage.Location = new System.Drawing.Point(25, 331);
            this.labelTopStudentAverage.Name = "labelTopStudentAverage";
            this.labelTopStudentAverage.Size = new System.Drawing.Size(101, 16);
            this.labelTopStudentAverage.TabIndex = 20;
            this.labelTopStudentAverage.Text = "Average Score:";
            // 
            // labelTopStudentAverageTxt
            // 
            this.labelTopStudentAverageTxt.AccessibleDescription = "The average score of the current top student.";
            this.labelTopStudentAverageTxt.AccessibleName = "Top Student Average";
            this.labelTopStudentAverageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopStudentAverageTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTopStudentAverageTxt.Location = new System.Drawing.Point(127, 327);
            this.labelTopStudentAverageTxt.Name = "labelTopStudentAverageTxt";
            this.labelTopStudentAverageTxt.Size = new System.Drawing.Size(73, 25);
            this.labelTopStudentAverageTxt.TabIndex = 21;
            this.labelTopStudentAverageTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSelectedStudentDate
            // 
            this.labelSelectedStudentDate.AccessibleName = "Record Creation Date";
            this.labelSelectedStudentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedStudentDate.AutoSize = true;
            this.labelSelectedStudentDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSelectedStudentDate.Location = new System.Drawing.Point(28, 219);
            this.labelSelectedStudentDate.Name = "labelSelectedStudentDate";
            this.labelSelectedStudentDate.Size = new System.Drawing.Size(140, 16);
            this.labelSelectedStudentDate.TabIndex = 23;
            this.labelSelectedStudentDate.Text = "Record Creation Date:";
            // 
            // labelRecordCreationDateTxt
            // 
            this.labelRecordCreationDateTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecordCreationDateTxt.AutoSize = true;
            this.labelRecordCreationDateTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelRecordCreationDateTxt.Location = new System.Drawing.Point(174, 219);
            this.labelRecordCreationDateTxt.Name = "labelRecordCreationDateTxt";
            this.labelRecordCreationDateTxt.Size = new System.Drawing.Size(0, 16);
            this.labelRecordCreationDateTxt.TabIndex = 24;
            // 
            // labelSelectedStudentId
            // 
            this.labelSelectedStudentId.AccessibleName = "Student ID";
            this.labelSelectedStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedStudentId.AutoSize = true;
            this.labelSelectedStudentId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSelectedStudentId.Location = new System.Drawing.Point(28, 235);
            this.labelSelectedStudentId.Name = "labelSelectedStudentId";
            this.labelSelectedStudentId.Size = new System.Drawing.Size(71, 16);
            this.labelSelectedStudentId.TabIndex = 25;
            this.labelSelectedStudentId.Text = "Student ID:";
            // 
            // labelSelectedStudentIdText
            // 
            this.labelSelectedStudentIdText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedStudentIdText.AutoSize = true;
            this.labelSelectedStudentIdText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSelectedStudentIdText.Location = new System.Drawing.Point(99, 235);
            this.labelSelectedStudentIdText.Name = "labelSelectedStudentIdText";
            this.labelSelectedStudentIdText.Size = new System.Drawing.Size(0, 16);
            this.labelSelectedStudentIdText.TabIndex = 26;
            // 
            // labelExport
            // 
            this.labelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExport.AutoSize = true;
            this.labelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExport.Location = new System.Drawing.Point(224, 28);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(48, 16);
            this.labelExport.TabIndex = 29;
            this.labelExport.Text = "Export:";
            // 
            // ComBoxExportFileType
            // 
            this.ComBoxExportFileType.AccessibleDescription = "Select a file type to export the student data.";
            this.ComBoxExportFileType.AccessibleName = "Export File Type selector";
            this.ComBoxExportFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComBoxExportFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxExportFileType.FormattingEnabled = true;
            this.ComBoxExportFileType.Items.AddRange(new object[] {
            ".txt",
            ".csv"});
            this.ComBoxExportFileType.Location = new System.Drawing.Point(278, 24);
            this.ComBoxExportFileType.Name = "ComBoxExportFileType";
            this.ComBoxExportFileType.Size = new System.Drawing.Size(74, 24);
            this.ComBoxExportFileType.TabIndex = 30;
            // 
            // buttonExport
            // 
            this.buttonExport.AccessibleDescription = "Button to export data to the file system.";
            this.buttonExport.AccessibleName = "Export Button";
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.BackColor = System.Drawing.Color.Transparent;
            this.buttonExport.BackgroundImage = global::Maintain_Student_Scores_John_Moreau.Properties.Resources.arrow;
            this.buttonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExport.Location = new System.Drawing.Point(357, 21);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(30, 29);
            this.buttonExport.TabIndex = 28;
            this.buttonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleDescription = "Button to save data to the file system.";
            this.buttonSave.AccessibleName = "Save Button";
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackgroundImage = global::Maintain_Student_Scores_John_Moreau.Properties.Resources.diskette;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave.Location = new System.Drawing.Point(405, 289);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 29);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonFindTopStudent
            // 
            this.buttonFindTopStudent.AccessibleDescription = "Find the current index of the top student in the students list box.";
            this.buttonFindTopStudent.AccessibleName = "Find Top Student";
            this.buttonFindTopStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFindTopStudent.BackgroundImage = global::Maintain_Student_Scores_John_Moreau.Properties.Resources.search;
            this.buttonFindTopStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFindTopStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindTopStudent.Location = new System.Drawing.Point(172, 261);
            this.buttonFindTopStudent.Name = "buttonFindTopStudent";
            this.buttonFindTopStudent.Size = new System.Drawing.Size(28, 29);
            this.buttonFindTopStudent.TabIndex = 22;
            this.buttonFindTopStudent.UseVisualStyleBackColor = true;
            this.buttonFindTopStudent.Click += new System.EventHandler(this.buttonFindTopStudent_Click);
            // 
            // FormMainStudentScores
            // 
            this.AcceptButton = this.buttonAddStudent;
            this.AccessibleDescription = "Main window for adding, updating, or deleting student records.";
            this.AccessibleName = "Student Scores Record Main Window";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(505, 383);
            this.Controls.Add(this.ComBoxExportFileType);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelSelectedStudentIdText);
            this.Controls.Add(this.labelSelectedStudentId);
            this.Controls.Add(this.labelRecordCreationDateTxt);
            this.Controls.Add(this.labelSelectedStudentDate);
            this.Controls.Add(this.buttonFindTopStudent);
            this.Controls.Add(this.labelTopStudentAverageTxt);
            this.Controls.Add(this.labelTopStudentAverage);
            this.Controls.Add(this.labelTopStudentNameTxt);
            this.Controls.Add(this.labelTopStudent);
            this.Controls.Add(this.labelAverageTxt);
            this.Controls.Add(this.labelScoreCountTxt);
            this.Controls.Add(this.labelScoreTotalTxt);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelScoreCount);
            this.Controls.Add(this.labelScoreTotal);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.buttonAddStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(523, 381);
            this.Name = "FormMainStudentScores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelScoreTotal;
        private System.Windows.Forms.Label labelScoreCount;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelScoreTotalTxt;
        private System.Windows.Forms.Label labelScoreCountTxt;
        private System.Windows.Forms.Label labelAverageTxt;
        private System.Windows.Forms.Label labelTopStudent;
        private System.Windows.Forms.Label labelTopStudentNameTxt;
        private System.Windows.Forms.Label labelTopStudentAverage;
        private System.Windows.Forms.Label labelTopStudentAverageTxt;
        private System.Windows.Forms.Button buttonFindTopStudent;
        private System.Windows.Forms.Label labelSelectedStudentDate;
        private System.Windows.Forms.Label labelRecordCreationDateTxt;
        private System.Windows.Forms.Label labelSelectedStudentId;
        private System.Windows.Forms.Label labelSelectedStudentIdText;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelExport;
        private System.Windows.Forms.ComboBox ComBoxExportFileType;
    }
}

