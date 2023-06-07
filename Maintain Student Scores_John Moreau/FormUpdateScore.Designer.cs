namespace Maintain_Student_Scores_John_Moreau
{
    partial class FormUpdateScore
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
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labeScore = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxScore
            // 
            this.textBoxScore.AccessibleDescription = "Score Text Box for updating a student score record.";
            this.textBoxScore.AccessibleName = "Score Text Box";
            this.textBoxScore.Location = new System.Drawing.Point(74, 42);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 22);
            this.textBoxScore.TabIndex = 0;
            // 
            // labeScore
            // 
            this.labeScore.AutoSize = true;
            this.labeScore.Location = new System.Drawing.Point(24, 45);
            this.labeScore.Name = "labeScore";
            this.labeScore.Size = new System.Drawing.Size(46, 16);
            this.labeScore.TabIndex = 1;
            this.labeScore.Text = "Score:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleDescription = "Update the score";
            this.buttonUpdate.AccessibleName = "Update Button";
            this.buttonUpdate.Location = new System.Drawing.Point(27, 86);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 28);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleDescription = "Cancel updating the student score";
            this.buttonCancel.AccessibleName = "Cancel Button";
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(117, 86);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormUpdateScore
            // 
            this.AcceptButton = this.buttonUpdate;
            this.AccessibleDescription = "A form for updating the currently selected score on a student record.";
            this.AccessibleName = "Update Score Form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(214, 137);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labeScore);
            this.Controls.Add(this.textBoxScore);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(232, 184);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(232, 184);
            this.Name = "FormUpdateScore";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labeScore;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
    }
}