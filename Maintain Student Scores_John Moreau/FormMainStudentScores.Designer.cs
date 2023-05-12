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
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(403, 56);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(88, 29);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "&Add New...";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Items.AddRange(new object[] {
            "Robin Greene|87|89|85|90",
            "Dennis Richardson|88|99|96|89",
            "Jerry Sampson|100|100|100"});
            this.listBoxStudents.Location = new System.Drawing.Point(31, 52);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(356, 132);
            this.listBoxStudents.TabIndex = 4;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudents.Location = new System.Drawing.Point(31, 24);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(59, 16);
            this.labelStudents.TabIndex = 5;
            this.labelStudents.Text = "Students";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(403, 91);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 29);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update...";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(403, 126);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 29);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(405, 293);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 29);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelScoreTotal
            // 
            this.labelScoreTotal.AutoSize = true;
            this.labelScoreTotal.Location = new System.Drawing.Point(234, 215);
            this.labelScoreTotal.Name = "labelScoreTotal";
            this.labelScoreTotal.Size = new System.Drawing.Size(74, 16);
            this.labelScoreTotal.TabIndex = 12;
            this.labelScoreTotal.Text = "Score total:";
            // 
            // labelScoreCount
            // 
            this.labelScoreCount.AutoSize = true;
            this.labelScoreCount.Location = new System.Drawing.Point(227, 243);
            this.labelScoreCount.Name = "labelScoreCount";
            this.labelScoreCount.Size = new System.Drawing.Size(81, 16);
            this.labelScoreCount.TabIndex = 13;
            this.labelScoreCount.Text = "Score count:";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(246, 271);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(62, 16);
            this.labelAverage.TabIndex = 14;
            this.labelAverage.Text = "Average:";
            // 
            // labelScoreTotalTxt
            // 
            this.labelScoreTotalTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoreTotalTxt.Location = new System.Drawing.Point(314, 211);
            this.labelScoreTotalTxt.Name = "labelScoreTotalTxt";
            this.labelScoreTotalTxt.Size = new System.Drawing.Size(73, 25);
            this.labelScoreTotalTxt.TabIndex = 15;
            this.labelScoreTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScoreCountTxt
            // 
            this.labelScoreCountTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScoreCountTxt.Location = new System.Drawing.Point(314, 239);
            this.labelScoreCountTxt.Name = "labelScoreCountTxt";
            this.labelScoreCountTxt.Size = new System.Drawing.Size(73, 25);
            this.labelScoreCountTxt.TabIndex = 16;
            this.labelScoreCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAverageTxt
            // 
            this.labelAverageTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageTxt.Location = new System.Drawing.Point(314, 267);
            this.labelAverageTxt.Name = "labelAverageTxt";
            this.labelAverageTxt.Size = new System.Drawing.Size(73, 25);
            this.labelAverageTxt.TabIndex = 17;
            this.labelAverageTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMainStudentScores
            // 
            this.AcceptButton = this.buttonAddStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(505, 334);
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
            this.Name = "FormMainStudentScores";
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
    }
}

