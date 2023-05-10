namespace Maintain_Student_Scores_John_Moreau
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.textBoxScoreTotal = new System.Windows.Forms.TextBox();
            this.textBoxScoreCount = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelScoreTotal = new System.Windows.Forms.Label();
            this.labelScoreCount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(403, 56);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(88, 29);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "&Add new...";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(12, 36);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(385, 148);
            this.listBoxStudents.TabIndex = 4;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(12, 14);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(59, 16);
            this.labelStudents.TabIndex = 5;
            this.labelStudents.Text = "Students";
            // 
            // textBoxScoreTotal
            // 
            this.textBoxScoreTotal.Location = new System.Drawing.Point(314, 212);
            this.textBoxScoreTotal.Name = "textBoxScoreTotal";
            this.textBoxScoreTotal.ReadOnly = true;
            this.textBoxScoreTotal.Size = new System.Drawing.Size(53, 22);
            this.textBoxScoreTotal.TabIndex = 6;
            // 
            // textBoxScoreCount
            // 
            this.textBoxScoreCount.Location = new System.Drawing.Point(314, 240);
            this.textBoxScoreCount.Name = "textBoxScoreCount";
            this.textBoxScoreCount.ReadOnly = true;
            this.textBoxScoreCount.Size = new System.Drawing.Size(53, 22);
            this.textBoxScoreCount.TabIndex = 7;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(314, 268);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(53, 22);
            this.textBoxAverage.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(403, 91);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 29);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update...";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(403, 126);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 29);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(405, 293);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 29);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 334);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelScoreCount);
            this.Controls.Add(this.labelScoreTotal);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.textBoxScoreCount);
            this.Controls.Add(this.textBoxScoreTotal);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.buttonAddNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.TextBox textBoxScoreTotal;
        private System.Windows.Forms.TextBox textBoxScoreCount;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelScoreTotal;
        private System.Windows.Forms.Label labelScoreCount;
        private System.Windows.Forms.Label labelAverage;
    }
}

