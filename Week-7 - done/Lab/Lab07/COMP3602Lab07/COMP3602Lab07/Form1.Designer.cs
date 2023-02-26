namespace COMP3602Lab07
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.buttonFtoC = new System.Windows.Forms.Button();
            this.labelValueToConvert = new System.Windows.Forms.Label();
            this.textBoxInputTemperature = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(47, 274);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(206, 46);
            this.buttonCtoF.TabIndex = 2;
            this.buttonCtoF.Text = "Convert C to F";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            this.buttonCtoF.Click += new System.EventHandler(this.buttonCtoF_Click);
            // 
            // buttonFtoC
            // 
            this.buttonFtoC.Location = new System.Drawing.Point(306, 274);
            this.buttonFtoC.Name = "buttonFtoC";
            this.buttonFtoC.Size = new System.Drawing.Size(190, 46);
            this.buttonFtoC.TabIndex = 3;
            this.buttonFtoC.Text = "Convert F to C";
            this.buttonFtoC.UseVisualStyleBackColor = true;
            this.buttonFtoC.Click += new System.EventHandler(this.buttonFtoC_Click);
            // 
            // labelValueToConvert
            // 
            this.labelValueToConvert.AutoSize = true;
            this.labelValueToConvert.Location = new System.Drawing.Point(47, 50);
            this.labelValueToConvert.Name = "labelValueToConvert";
            this.labelValueToConvert.Size = new System.Drawing.Size(193, 32);
            this.labelValueToConvert.TabIndex = 0;
            this.labelValueToConvert.Text = "Value to convert:";
            // 
            // textBoxInputTemperature
            // 
            this.textBoxInputTemperature.Location = new System.Drawing.Point(47, 105);
            this.textBoxInputTemperature.Name = "textBoxInputTemperature";
            this.textBoxInputTemperature.Size = new System.Drawing.Size(449, 39);
            this.textBoxInputTemperature.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(47, 192);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 32);
            this.labelResult.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCtoF;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 366);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxInputTemperature);
            this.Controls.Add(this.labelValueToConvert);
            this.Controls.Add(this.buttonFtoC);
            this.Controls.Add(this.buttonCtoF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Button buttonFtoC;
        private System.Windows.Forms.Label labelValueToConvert;
        private System.Windows.Forms.TextBox textBoxInputTemperature;
        private System.Windows.Forms.Label labelResult;
    }
}
