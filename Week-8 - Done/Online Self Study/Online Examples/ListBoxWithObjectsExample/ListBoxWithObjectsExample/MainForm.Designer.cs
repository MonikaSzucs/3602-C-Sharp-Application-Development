namespace ListBoxWithObjectsExample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelBirthDatePrompt = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelAgePrompt = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthDate.Location = new System.Drawing.Point(80, 85);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.ReadOnly = true;
            this.textBoxBirthDate.Size = new System.Drawing.Size(200, 13);
            this.textBoxBirthDate.TabIndex = 5;
            this.textBoxBirthDate.Text = "<birthdate>";
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(12, 12);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(292, 121);
            this.listBoxNames.TabIndex = 12;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(80, 65);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(200, 13);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.Text = "<age>";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(80, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(200, 13);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.Text = "<lastname>";
            // 
            // labelBirthDatePrompt
            // 
            this.labelBirthDatePrompt.AutoSize = true;
            this.labelBirthDatePrompt.Location = new System.Drawing.Point(16, 85);
            this.labelBirthDatePrompt.Name = "labelBirthDatePrompt";
            this.labelBirthDatePrompt.Size = new System.Drawing.Size(55, 13);
            this.labelBirthDatePrompt.TabIndex = 2;
            this.labelBirthDatePrompt.Text = "Birth date:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(80, 25);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 13);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.Text = "<firstname>";
            // 
            // labelAgePrompt
            // 
            this.labelAgePrompt.AutoSize = true;
            this.labelAgePrompt.Location = new System.Drawing.Point(16, 65);
            this.labelAgePrompt.Name = "labelAgePrompt";
            this.labelAgePrompt.Size = new System.Drawing.Size(29, 13);
            this.labelAgePrompt.TabIndex = 2;
            this.labelAgePrompt.Text = "Age:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxBirthDate);
            this.groupBoxDetails.Controls.Add(this.textBoxAge);
            this.groupBoxDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxDetails.Controls.Add(this.labelBirthDatePrompt);
            this.groupBoxDetails.Controls.Add(this.labelAgePrompt);
            this.groupBoxDetails.Controls.Add(this.labelLastNamePrompt);
            this.groupBoxDetails.Controls.Add(this.labelFirstNamePrompt);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 152);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(292, 113);
            this.groupBoxDetails.TabIndex = 13;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = " Details ";
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(16, 45);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(59, 13);
            this.labelLastNamePrompt.TabIndex = 1;
            this.labelLastNamePrompt.Text = "Last name:";
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(16, 25);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(58, 13);
            this.labelFirstNamePrompt.TabIndex = 0;
            this.labelFirstNamePrompt.Text = "First name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 279);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.groupBoxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox With Objects";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelBirthDatePrompt;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelAgePrompt;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.Label labelFirstNamePrompt;
    }
}

