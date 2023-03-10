namespace TextBoxExample
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
            this.labelGreeting = new System.Windows.Forms.Label();
            this.buttonCreateGreeting = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(24, 175);
            this.labelGreeting.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(151, 30);
            this.labelGreeting.TabIndex = 10;
            this.labelGreeting.Text = "<Greeting>";
            this.labelGreeting.Click += new System.EventHandler(this.labelGreeting_Click);
            // 
            // buttonCreateGreeting
            // 
            this.buttonCreateGreeting.Location = new System.Drawing.Point(314, 246);
            this.buttonCreateGreeting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCreateGreeting.Name = "buttonCreateGreeting";
            this.buttonCreateGreeting.Size = new System.Drawing.Size(212, 44);
            this.buttonCreateGreeting.TabIndex = 11;
            this.buttonCreateGreeting.Text = "&Create Greeting";
            this.buttonCreateGreeting.UseVisualStyleBackColor = true;
            this.buttonCreateGreeting.Click += new System.EventHandler(this.buttonCreateGreeting_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(160, 96);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(362, 31);
            this.textBoxLastName.TabIndex = 9;
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(160, 40);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(362, 31);
            this.textBoxFirstName.TabIndex = 7;
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(24, 102);
            this.labelLastNamePrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(121, 25);
            this.labelLastNamePrompt.TabIndex = 8;
            this.labelLastNamePrompt.Text = "&Last Name:";
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(24, 46);
            this.labelFirstNamePrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(122, 25);
            this.labelFirstNamePrompt.TabIndex = 6;
            this.labelFirstNamePrompt.Text = "&First Name:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCreateGreeting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 337);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.buttonCreateGreeting);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastNamePrompt);
            this.Controls.Add(this.labelFirstNamePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBox Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Button buttonCreateGreeting;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.Label labelFirstNamePrompt;
    }
}

