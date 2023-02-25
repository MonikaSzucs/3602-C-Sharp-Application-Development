namespace COMP3602Assign06
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.buttonCheckDate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.toolTipValid = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(51, 47);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(63, 32);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Year:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(259, 47);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(91, 32);
            this.labelMonth.TabIndex = 1;
            this.labelMonth.Text = "Month:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(465, 47);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(60, 32);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(51, 91);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(164, 39);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(259, 91);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(164, 39);
            this.textBoxMonth.TabIndex = 4;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(465, 91);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(164, 39);
            this.textBoxDay.TabIndex = 5;
            // 
            // buttonCheckDate
            // 
            this.buttonCheckDate.Location = new System.Drawing.Point(479, 226);
            this.buttonCheckDate.Name = "buttonCheckDate";
            this.buttonCheckDate.Size = new System.Drawing.Size(150, 46);
            this.buttonCheckDate.TabIndex = 6;
            this.buttonCheckDate.Text = "Check Date";
            this.buttonCheckDate.UseVisualStyleBackColor = true;
            this.buttonCheckDate.Click += new System.EventHandler(this.buttonCheckDate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(51, 212);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 32);
            this.labelResult.TabIndex = 7;
            this.labelResult.MouseEnter += new System.EventHandler(this.labelResult_MouseEnter);
            this.labelResult.MouseLeave += new System.EventHandler(this.labelResult_MouseLeave);
            // 
            // Form
            // 
            this.AcceptButton = this.buttonCheckDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 325);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCheckDate);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Button buttonCheckDate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ToolTip toolTipValid;
    }
}
