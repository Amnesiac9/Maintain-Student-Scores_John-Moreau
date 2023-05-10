namespace Maintain_Student_Scores_John_Moreau
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
            this.textBoxScores = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelScores = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(59, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(59, 66);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(90, 22);
            this.textBoxScore.TabIndex = 1;
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Location = new System.Drawing.Point(170, 65);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(101, 23);
            this.buttonAddScore.TabIndex = 2;
            this.buttonAddScore.Text = "&Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            // 
            // textBoxScores
            // 
            this.textBoxScores.AccessibleDescription = "Scores Output";
            this.textBoxScores.AccessibleName = "Scores Output";
            this.textBoxScores.Location = new System.Drawing.Point(59, 104);
            this.textBoxScores.Name = "textBoxScores";
            this.textBoxScores.ReadOnly = true;
            this.textBoxScores.Size = new System.Drawing.Size(212, 22);
            this.textBoxScores.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(170, 143);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "&Clear Scores";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(48, 180);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(101, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(170, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.Location = new System.Drawing.Point(4, 107);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(53, 16);
            this.labelScores.TabIndex = 7;
            this.labelScores.Text = "Scores:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(9, 68);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(46, 16);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name:";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 210);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxScores);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.TextBox textBoxScores;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelName;
    }
}