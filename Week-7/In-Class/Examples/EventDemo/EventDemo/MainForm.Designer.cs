namespace EventDemo
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
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonClearEvents = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNamePrompt = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotesPrompt = new System.Windows.Forms.Label();
            this.checkBoxAcceptsReturn = new System.Windows.Forms.CheckBox();
            this.checkBoxAcceptsTab = new System.Windows.Forms.CheckBox();
            this.checkBoxCharacterCasing = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 17;
            this.listBoxEvents.Location = new System.Drawing.Point(492, 51);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(323, 361);
            this.listBoxEvents.TabIndex = 8;
            this.listBoxEvents.DoubleClick += new System.EventHandler(this.listBoxEvents_DoubleClick);
            this.listBoxEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEvents_MouseDoubleClick);
            // 
            // buttonClearEvents
            // 
            this.buttonClearEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearEvents.Location = new System.Drawing.Point(707, 12);
            this.buttonClearEvents.Name = "buttonClearEvents";
            this.buttonClearEvents.Size = new System.Drawing.Size(108, 27);
            this.buttonClearEvents.TabIndex = 9;
            this.buttonClearEvents.Text = "Clear &Events";
            this.buttonClearEvents.UseVisualStyleBackColor = true;
            this.buttonClearEvents.Click += new System.EventHandler(this.buttonClearEvents_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(160, 385);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 27);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(263, 385);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 27);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseClick);
            // 
            // labelNamePrompt
            // 
            this.labelNamePrompt.AutoSize = true;
            this.labelNamePrompt.Location = new System.Drawing.Point(32, 54);
            this.labelNamePrompt.Name = "labelNamePrompt";
            this.labelNamePrompt.Size = new System.Drawing.Size(42, 15);
            this.labelNamePrompt.TabIndex = 0;
            this.labelNamePrompt.Text = "&Name:";
            this.labelNamePrompt.Click += new System.EventHandler(this.labelNamePrompt_Click);
            this.labelNamePrompt.DoubleClick += new System.EventHandler(this.labelNamePrompt_DoubleClick);
            this.labelNamePrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelNamePrompt_MouseClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(80, 111);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(270, 247);
            this.textBoxNotes.TabIndex = 3;
            this.textBoxNotes.TextChanged += new System.EventHandler(this.textBoxNotes_TextChanged);
            this.textBoxNotes.Enter += new System.EventHandler(this.textBoxNotes_Enter);
            this.textBoxNotes.Leave += new System.EventHandler(this.textBoxNotes_Leave);
            // 
            // labelNotesPrompt
            // 
            this.labelNotesPrompt.AutoSize = true;
            this.labelNotesPrompt.Location = new System.Drawing.Point(32, 111);
            this.labelNotesPrompt.Name = "labelNotesPrompt";
            this.labelNotesPrompt.Size = new System.Drawing.Size(41, 15);
            this.labelNotesPrompt.TabIndex = 2;
            this.labelNotesPrompt.Text = "N&otes:";
            this.labelNotesPrompt.Click += new System.EventHandler(this.labelNotesPrompt_Click);
            this.labelNotesPrompt.DoubleClick += new System.EventHandler(this.labelNotesPrompt_DoubleClick);
            this.labelNotesPrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelNotesPrompt_MouseClick);
            // 
            // checkBoxAcceptsReturn
            // 
            this.checkBoxAcceptsReturn.AutoSize = true;
            this.checkBoxAcceptsReturn.Location = new System.Drawing.Point(356, 113);
            this.checkBoxAcceptsReturn.Name = "checkBoxAcceptsReturn";
            this.checkBoxAcceptsReturn.Size = new System.Drawing.Size(106, 19);
            this.checkBoxAcceptsReturn.TabIndex = 6;
            this.checkBoxAcceptsReturn.Text = "Accepts &Return";
            this.checkBoxAcceptsReturn.UseVisualStyleBackColor = true;
            this.checkBoxAcceptsReturn.CheckedChanged += new System.EventHandler(this.checkBoxAcceptsReturn_CheckedChanged);
            // 
            // checkBoxAcceptsTab
            // 
            this.checkBoxAcceptsTab.AutoSize = true;
            this.checkBoxAcceptsTab.Location = new System.Drawing.Point(356, 138);
            this.checkBoxAcceptsTab.Name = "checkBoxAcceptsTab";
            this.checkBoxAcceptsTab.Size = new System.Drawing.Size(91, 19);
            this.checkBoxAcceptsTab.TabIndex = 7;
            this.checkBoxAcceptsTab.Text = "Accepts &Tab";
            this.checkBoxAcceptsTab.UseVisualStyleBackColor = true;
            this.checkBoxAcceptsTab.CheckedChanged += new System.EventHandler(this.checkBoxAcceptsTab_CheckedChanged);
            // 
            // checkBoxCharacterCasing
            // 
            this.checkBoxCharacterCasing.AutoSize = true;
            this.checkBoxCharacterCasing.Location = new System.Drawing.Point(356, 53);
            this.checkBoxCharacterCasing.Name = "checkBoxCharacterCasing";
            this.checkBoxCharacterCasing.Size = new System.Drawing.Size(116, 19);
            this.checkBoxCharacterCasing.TabIndex = 10;
            this.checkBoxCharacterCasing.Text = "&Character Casing";
            this.checkBoxCharacterCasing.UseVisualStyleBackColor = true;
            this.checkBoxCharacterCasing.CheckedChanged += new System.EventHandler(this.checkBoxCharacterCasing_CheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(827, 426);
            this.Controls.Add(this.checkBoxCharacterCasing);
            this.Controls.Add(this.checkBoxAcceptsTab);
            this.Controls.Add(this.checkBoxAcceptsReturn);
            this.Controls.Add(this.labelNotesPrompt);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNamePrompt);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonClearEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Demo";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonClearEvents;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNamePrompt;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotesPrompt;
        private System.Windows.Forms.CheckBox checkBoxAcceptsReturn;
        private System.Windows.Forms.CheckBox checkBoxAcceptsTab;
        private System.Windows.Forms.CheckBox checkBoxCharacterCasing;
    }
}

