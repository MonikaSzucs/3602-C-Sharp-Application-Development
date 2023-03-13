namespace ErrorProviderDemoB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.labelCodePattern = new System.Windows.Forms.Label();
            this.labelCodePrompt = new System.Windows.Forms.Label();
            this.labelPostalPrompt = new System.Windows.Forms.Label();
            this.labelAgePrompt = new System.Windows.Forms.Label();
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxPostalCode
            // 
            this.errorProvider.SetIconPadding(this.maskedTextBoxPostalCode, 5);
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(95, 129);
            this.maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBoxPostalCode.TabIndex = 9;
            // 
            // textBoxAge
            // 
            this.errorProvider.SetIconPadding(this.textBoxAge, 5);
            this.textBoxAge.Location = new System.Drawing.Point(95, 100);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(65, 20);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.errorProvider.SetIconPadding(this.textBoxLastName, 5);
            this.textBoxLastName.Location = new System.Drawing.Point(95, 71);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(205, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.errorProvider.SetIconPadding(this.textBoxFirstName, 5);
            this.textBoxFirstName.Location = new System.Drawing.Point(95, 42);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(205, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.errorProvider.SetIconPadding(this.textBoxClientCode, 5);
            this.textBoxClientCode.Location = new System.Drawing.Point(95, 13);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(75, 20);
            this.textBoxClientCode.TabIndex = 1;
            // 
            // labelCodePattern
            // 
            this.labelCodePattern.AutoSize = true;
            this.labelCodePattern.Location = new System.Drawing.Point(192, 16);
            this.labelCodePattern.Name = "labelCodePattern";
            this.labelCodePattern.Size = new System.Drawing.Size(45, 13);
            this.labelCodePattern.TabIndex = 10;
            this.labelCodePattern.Text = "[AA999]";
            // 
            // labelCodePrompt
            // 
            this.labelCodePrompt.AutoSize = true;
            this.labelCodePrompt.Location = new System.Drawing.Point(25, 16);
            this.labelCodePrompt.Name = "labelCodePrompt";
            this.labelCodePrompt.Size = new System.Drawing.Size(64, 13);
            this.labelCodePrompt.TabIndex = 0;
            this.labelCodePrompt.Text = "&Client Code:";
            // 
            // labelPostalPrompt
            // 
            this.labelPostalPrompt.AutoSize = true;
            this.labelPostalPrompt.Location = new System.Drawing.Point(26, 132);
            this.labelPostalPrompt.Name = "labelPostalPrompt";
            this.labelPostalPrompt.Size = new System.Drawing.Size(67, 13);
            this.labelPostalPrompt.TabIndex = 8;
            this.labelPostalPrompt.Text = "&Postal Code:";
            // 
            // labelAgePrompt
            // 
            this.labelAgePrompt.AutoSize = true;
            this.labelAgePrompt.Location = new System.Drawing.Point(26, 103);
            this.labelAgePrompt.Name = "labelAgePrompt";
            this.labelAgePrompt.Size = new System.Drawing.Size(29, 13);
            this.labelAgePrompt.TabIndex = 6;
            this.labelAgePrompt.Text = "&Age:";
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(25, 74);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(56, 13);
            this.labelFirstNamePrompt.TabIndex = 4;
            this.labelFirstNamePrompt.Text = "&Lastname:";
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(26, 45);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(55, 13);
            this.labelLastNamePrompt.TabIndex = 2;
            this.labelLastNamePrompt.Text = "&Firstname:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(225, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(146, 174);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.TabStop = false;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.maskedTextBoxPostalCode);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelCodePattern);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.labelCodePrompt);
            this.Controls.Add(this.labelPostalPrompt);
            this.Controls.Add(this.labelAgePrompt);
            this.Controls.Add(this.labelFirstNamePrompt);
            this.Controls.Add(this.labelLastNamePrompt);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Provider Demo B";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelCodePattern;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.Label labelCodePrompt;
        private System.Windows.Forms.Label labelPostalPrompt;
        private System.Windows.Forms.Label labelAgePrompt;
        private System.Windows.Forms.Label labelFirstNamePrompt;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}

