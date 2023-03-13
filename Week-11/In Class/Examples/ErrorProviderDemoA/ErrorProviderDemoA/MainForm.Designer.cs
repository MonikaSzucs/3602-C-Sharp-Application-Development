namespace ErrorProviderDemoA
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
            this.checkBoxUseErrorProvider = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAgePrompt = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxUseErrorProvider
            // 
            this.checkBoxUseErrorProvider.AutoSize = true;
            this.checkBoxUseErrorProvider.Location = new System.Drawing.Point(26, 96);
            this.checkBoxUseErrorProvider.Name = "checkBoxUseErrorProvider";
            this.checkBoxUseErrorProvider.Size = new System.Drawing.Size(112, 17);
            this.checkBoxUseErrorProvider.TabIndex = 6;
            this.checkBoxUseErrorProvider.Text = "&Use Error Provider";
            this.checkBoxUseErrorProvider.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(216, 119);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(135, 119);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.TabStop = false;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxAge
            // 
            this.errorProvider.SetIconAlignment(this.textBoxAge, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxAge, 4);
            this.textBoxAge.Location = new System.Drawing.Point(88, 70);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(80, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // labelAgePrompt
            // 
            this.labelAgePrompt.AutoSize = true;
            this.labelAgePrompt.Location = new System.Drawing.Point(23, 73);
            this.labelAgePrompt.Name = "labelAgePrompt";
            this.labelAgePrompt.Size = new System.Drawing.Size(29, 13);
            this.labelAgePrompt.TabIndex = 4;
            this.labelAgePrompt.Text = "&Age:";
            // 
            // textBoxLastName
            // 
            this.errorProvider.SetIconPadding(this.textBoxLastName, 2);
            this.textBoxLastName.Location = new System.Drawing.Point(88, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(203, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(23, 47);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(59, 13);
            this.labelLastNamePrompt.TabIndex = 2;
            this.labelLastNamePrompt.Text = "&Last name:";
            // 
            // textBoxFirstName
            // 
            this.errorProvider.SetIconPadding(this.textBoxFirstName, 2);
            this.textBoxFirstName.Location = new System.Drawing.Point(88, 18);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(203, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(23, 21);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(58, 13);
            this.labelFirstNamePrompt.TabIndex = 0;
            this.labelFirstNamePrompt.Text = "&First name:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.checkBoxUseErrorProvider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAgePrompt);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastNamePrompt);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstNamePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Provider Demo A";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUseErrorProvider;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelAgePrompt;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstNamePrompt;
    }
}

