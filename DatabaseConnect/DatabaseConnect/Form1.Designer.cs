namespace DatabaseConnect
{
    partial class Form1
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
            this.labelCheckConnection = new System.Windows.Forms.Label();
            this.listBoxProject = new System.Windows.Forms.ListBox();
            this.comboBoxProjectSelector = new System.Windows.Forms.ComboBox();
            this.labelProjectNotes = new System.Windows.Forms.Label();
            this.richTextBoxProjectNotes = new System.Windows.Forms.RichTextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCheckConnection
            // 
            this.labelCheckConnection.AutoSize = true;
            this.labelCheckConnection.Location = new System.Drawing.Point(12, 635);
            this.labelCheckConnection.Name = "labelCheckConnection";
            this.labelCheckConnection.Size = new System.Drawing.Size(102, 17);
            this.labelCheckConnection.TabIndex = 0;
            this.labelCheckConnection.Text = "Not Connected";
            // 
            // listBoxProject
            // 
            this.listBoxProject.FormattingEnabled = true;
            this.listBoxProject.ItemHeight = 16;
            this.listBoxProject.Location = new System.Drawing.Point(312, 170);
            this.listBoxProject.Name = "listBoxProject";
            this.listBoxProject.Size = new System.Drawing.Size(496, 132);
            this.listBoxProject.TabIndex = 1;
            // 
            // comboBoxProjectSelector
            // 
            this.comboBoxProjectSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProjectSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProjectSelector.FormattingEnabled = true;
            this.comboBoxProjectSelector.Location = new System.Drawing.Point(163, 74);
            this.comboBoxProjectSelector.Name = "comboBoxProjectSelector";
            this.comboBoxProjectSelector.Size = new System.Drawing.Size(387, 24);
            this.comboBoxProjectSelector.Sorted = true;
            this.comboBoxProjectSelector.TabIndex = 2;
            this.comboBoxProjectSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjectSelector_SelectedIndexChanged);
            // 
            // labelProjectNotes
            // 
            this.labelProjectNotes.AutoSize = true;
            this.labelProjectNotes.Location = new System.Drawing.Point(15, 477);
            this.labelProjectNotes.Name = "labelProjectNotes";
            this.labelProjectNotes.Size = new System.Drawing.Size(93, 17);
            this.labelProjectNotes.TabIndex = 3;
            this.labelProjectNotes.Text = "Project Notes";
            // 
            // richTextBoxProjectNotes
            // 
            this.richTextBoxProjectNotes.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxProjectNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProjectNotes.Location = new System.Drawing.Point(12, 497);
            this.richTextBoxProjectNotes.Name = "richTextBoxProjectNotes";
            this.richTextBoxProjectNotes.Size = new System.Drawing.Size(472, 135);
            this.richTextBoxProjectNotes.TabIndex = 4;
            this.richTextBoxProjectNotes.Text = "";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(577, 74);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(131, 35);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load Project";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 661);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.richTextBoxProjectNotes);
            this.Controls.Add(this.labelProjectNotes);
            this.Controls.Add(this.comboBoxProjectSelector);
            this.Controls.Add(this.listBoxProject);
            this.Controls.Add(this.labelCheckConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckConnection;
        private System.Windows.Forms.ListBox listBoxProject;
        private System.Windows.Forms.ComboBox comboBoxProjectSelector;
        private System.Windows.Forms.Label labelProjectNotes;
        private System.Windows.Forms.RichTextBox richTextBoxProjectNotes;
        private System.Windows.Forms.Button buttonLoad;
    }
}

