namespace RadioButtonCheckBox
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
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonChecked = new System.Windows.Forms.RadioButton();
            this.radioButtonUnchecked = new System.Windows.Forms.RadioButton();
            this.radioButtonIndeterminate = new System.Windows.Forms.RadioButton();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonType3 = new System.Windows.Forms.Button();
            this.buttonType2 = new System.Windows.Forms.Button();
            this.buttonType1 = new System.Windows.Forms.Button();
            this.checkBoxButtonsEnable = new System.Windows.Forms.CheckBox();
            this.labelButtonResult = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBoxStatus.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(27, 22);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(56, 17);
            this.checkBoxStatus.TabIndex = 0;
            this.checkBoxStatus.Text = "&Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            this.checkBoxStatus.CheckedChanged += new System.EventHandler(this.checkBoxStatus_CheckedChanged);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioButtonChecked);
            this.groupBoxStatus.Controls.Add(this.radioButtonUnchecked);
            this.groupBoxStatus.Controls.Add(this.radioButtonIndeterminate);
            this.groupBoxStatus.Location = new System.Drawing.Point(120, 22);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(144, 96);
            this.groupBoxStatus.TabIndex = 1;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = " Status ";
            // 
            // radioButtonChecked
            // 
            this.radioButtonChecked.AutoSize = true;
            this.radioButtonChecked.Location = new System.Drawing.Point(24, 19);
            this.radioButtonChecked.Name = "radioButtonChecked";
            this.radioButtonChecked.Size = new System.Drawing.Size(68, 17);
            this.radioButtonChecked.TabIndex = 2;
            this.radioButtonChecked.TabStop = true;
            this.radioButtonChecked.Text = "&Checked";
            this.radioButtonChecked.UseVisualStyleBackColor = true;
            this.radioButtonChecked.CheckedChanged += new System.EventHandler(this.radioButtonChecked_CheckedChanged);
            // 
            // radioButtonUnchecked
            // 
            this.radioButtonUnchecked.AutoSize = true;
            this.radioButtonUnchecked.Location = new System.Drawing.Point(24, 42);
            this.radioButtonUnchecked.Name = "radioButtonUnchecked";
            this.radioButtonUnchecked.Size = new System.Drawing.Size(81, 17);
            this.radioButtonUnchecked.TabIndex = 3;
            this.radioButtonUnchecked.TabStop = true;
            this.radioButtonUnchecked.Text = "&Unchecked";
            this.radioButtonUnchecked.UseVisualStyleBackColor = true;
            this.radioButtonUnchecked.CheckedChanged += new System.EventHandler(this.radioButtonChecked_CheckedChanged);
            // 
            // radioButtonIndeterminate
            // 
            this.radioButtonIndeterminate.AutoSize = true;
            this.radioButtonIndeterminate.Location = new System.Drawing.Point(24, 65);
            this.radioButtonIndeterminate.Name = "radioButtonIndeterminate";
            this.radioButtonIndeterminate.Size = new System.Drawing.Size(89, 17);
            this.radioButtonIndeterminate.TabIndex = 4;
            this.radioButtonIndeterminate.TabStop = true;
            this.radioButtonIndeterminate.Text = "&Indeterminate";
            this.radioButtonIndeterminate.UseVisualStyleBackColor = true;
            this.radioButtonIndeterminate.CheckedChanged += new System.EventHandler(this.radioButtonChecked_CheckedChanged);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonType3);
            this.panelButtons.Controls.Add(this.buttonType2);
            this.panelButtons.Controls.Add(this.buttonType1);
            this.panelButtons.Location = new System.Drawing.Point(331, 64);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(84, 122);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonType3
            // 
            this.buttonType3.Location = new System.Drawing.Point(3, 87);
            this.buttonType3.Name = "buttonType3";
            this.buttonType3.Size = new System.Drawing.Size(75, 23);
            this.buttonType3.TabIndex = 2;
            this.buttonType3.Text = "Type &3";
            this.buttonType3.UseVisualStyleBackColor = true;
            this.buttonType3.Click += new System.EventHandler(this.buttonType1_Click);
            // 
            // buttonType2
            // 
            this.buttonType2.Location = new System.Drawing.Point(3, 45);
            this.buttonType2.Name = "buttonType2";
            this.buttonType2.Size = new System.Drawing.Size(75, 23);
            this.buttonType2.TabIndex = 1;
            this.buttonType2.Text = "Type &2";
            this.buttonType2.UseVisualStyleBackColor = true;
            this.buttonType2.Click += new System.EventHandler(this.buttonType1_Click);
            // 
            // buttonType1
            // 
            this.buttonType1.Location = new System.Drawing.Point(3, 3);
            this.buttonType1.Name = "buttonType1";
            this.buttonType1.Size = new System.Drawing.Size(75, 23);
            this.buttonType1.TabIndex = 0;
            this.buttonType1.Text = "Type &1";
            this.buttonType1.UseVisualStyleBackColor = true;
            this.buttonType1.Click += new System.EventHandler(this.buttonType1_Click);
            // 
            // checkBoxButtonsEnable
            // 
            this.checkBoxButtonsEnable.AutoSize = true;
            this.checkBoxButtonsEnable.Location = new System.Drawing.Point(331, 22);
            this.checkBoxButtonsEnable.Name = "checkBoxButtonsEnable";
            this.checkBoxButtonsEnable.Size = new System.Drawing.Size(98, 17);
            this.checkBoxButtonsEnable.TabIndex = 3;
            this.checkBoxButtonsEnable.Text = "&Enable Buttons";
            this.checkBoxButtonsEnable.UseVisualStyleBackColor = true;
            this.checkBoxButtonsEnable.CheckedChanged += new System.EventHandler(this.checkBoxButtonsEnable_CheckedChanged);
            // 
            // labelButtonResult
            // 
            this.labelButtonResult.AutoSize = true;
            this.labelButtonResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButtonResult.Location = new System.Drawing.Point(330, 213);
            this.labelButtonResult.Name = "labelButtonResult";
            this.labelButtonResult.Size = new System.Drawing.Size(81, 19);
            this.labelButtonResult.TabIndex = 6;
            this.labelButtonResult.Text = "<Result>";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Location = new System.Drawing.Point(27, 149);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(104, 100);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = " Color ";
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(17, 66);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "&Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(17, 42);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "&Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(17, 19);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "&Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonLarge);
            this.groupBoxSize.Controls.Add(this.radioButtonMedium);
            this.groupBoxSize.Controls.Add(this.radioButtonSmall);
            this.groupBoxSize.Location = new System.Drawing.Point(160, 149);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(104, 100);
            this.groupBoxSize.TabIndex = 5;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = " Size ";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(18, 66);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(52, 17);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "&Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(18, 43);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "&Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(18, 20);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(50, 17);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "&Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 266);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.labelButtonResult);
            this.Controls.Add(this.checkBoxButtonsEnable);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.checkBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioButtons and CheckBoxes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioButtonChecked;
        private System.Windows.Forms.RadioButton radioButtonUnchecked;
        private System.Windows.Forms.RadioButton radioButtonIndeterminate;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonType3;
        private System.Windows.Forms.Button buttonType2;
        private System.Windows.Forms.Button buttonType1;
        private System.Windows.Forms.CheckBox checkBoxButtonsEnable;
        private System.Windows.Forms.Label labelButtonResult;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
    }
}

