namespace LabelDemo
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
            this.labelAutoSizeTrue = new System.Windows.Forms.Label();
            this.labelAutoSizeFalse = new System.Windows.Forms.Label();
            this.buttonSetMaxSizeWidth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAutoSizeTrue
            // 
            this.labelAutoSizeTrue.AutoSize = true;
            this.labelAutoSizeTrue.Location = new System.Drawing.Point(21, 76);
            this.labelAutoSizeTrue.Name = "labelAutoSizeTrue";
            this.labelAutoSizeTrue.Size = new System.Drawing.Size(0, 13);
            this.labelAutoSizeTrue.TabIndex = 0;
            // 
            // labelAutoSizeFalse
            // 
            this.labelAutoSizeFalse.Location = new System.Drawing.Point(21, 140);
            this.labelAutoSizeFalse.Name = "labelAutoSizeFalse";
            this.labelAutoSizeFalse.Size = new System.Drawing.Size(120, 91);
            this.labelAutoSizeFalse.TabIndex = 1;
            // 
            // buttonSetMaxSizeWidth
            // 
            this.buttonSetMaxSizeWidth.Location = new System.Drawing.Point(21, 25);
            this.buttonSetMaxSizeWidth.Name = "buttonSetMaxSizeWidth";
            this.buttonSetMaxSizeWidth.Size = new System.Drawing.Size(205, 23);
            this.buttonSetMaxSizeWidth.TabIndex = 2;
            this.buttonSetMaxSizeWidth.TabStop = false;
            this.buttonSetMaxSizeWidth.Text = "&Set MaximumSize Width to 120";
            this.buttonSetMaxSizeWidth.UseVisualStyleBackColor = true;
            this.buttonSetMaxSizeWidth.Click += new System.EventHandler(this.buttonSetMaxSizeWidth_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 271);
            this.Controls.Add(this.buttonSetMaxSizeWidth);
            this.Controls.Add(this.labelAutoSizeFalse);
            this.Controls.Add(this.labelAutoSizeTrue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAutoSizeTrue;
        private System.Windows.Forms.Label labelAutoSizeFalse;
        private System.Windows.Forms.Button buttonSetMaxSizeWidth;
    }
}

