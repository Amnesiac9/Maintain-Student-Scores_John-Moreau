namespace Maintain_Student_Scores_John_Moreau
{
    partial class FormEditName
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleDescription = "Cancel editing the name of the student record.";
            this.buttonCancel.AccessibleName = "Cancel Button";
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(138, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleDescription = "Button to commit the update to the student name.";
            this.buttonUpdate.AccessibleName = "Update Button";
            this.buttonUpdate.Location = new System.Drawing.Point(48, 66);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 28);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = "Text box containing the student name to edit";
            this.textBoxName.AccessibleName = "Name Text Box";
            this.textBoxName.Location = new System.Drawing.Point(75, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // FormEditName
            // 
            this.AcceptButton = this.buttonUpdate;
            this.AccessibleDescription = "Form for editing the name of the currently selected student.";
            this.AccessibleName = "Edit Name Form";
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(261, 106);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 153);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(279, 153);
            this.Name = "FormEditName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}