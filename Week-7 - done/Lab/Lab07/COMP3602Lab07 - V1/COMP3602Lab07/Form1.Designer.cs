namespace COMP3602Lab07
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelValueToConvert = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.formButtonConvertCToF = new System.Windows.Forms.Button();
            this.formButtonConvertFToC = new System.Windows.Forms.Button();
            this.labelConvertedTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValueToConvert
            // 
            this.labelValueToConvert.AutoSize = true;
            this.labelValueToConvert.Location = new System.Drawing.Point(37, 37);
            this.labelValueToConvert.Name = "labelValueToConvert";
            this.labelValueToConvert.Size = new System.Drawing.Size(193, 32);
            this.labelValueToConvert.TabIndex = 0;
            this.labelValueToConvert.Text = "Value to convert:";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(37, 81);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(510, 39);
            this.textBox.TabIndex = 1;
            // 
            // formButtonConvertCToF
            // 
            this.formButtonConvertCToF.Location = new System.Drawing.Point(37, 358);
            this.formButtonConvertCToF.Name = "formButtonConvertCToF";
            this.formButtonConvertCToF.Size = new System.Drawing.Size(215, 46);
            this.formButtonConvertCToF.TabIndex = 2;
            this.formButtonConvertCToF.Text = "&Convert C to F";
            this.formButtonConvertCToF.UseVisualStyleBackColor = true;
            this.formButtonConvertCToF.Click += new System.EventHandler(this.formButtonConvertCToF_Click);
            // 
            // formButtonConvertFToC
            // 
            this.formButtonConvertFToC.Location = new System.Drawing.Point(323, 358);
            this.formButtonConvertFToC.Name = "formButtonConvertFToC";
            this.formButtonConvertFToC.Size = new System.Drawing.Size(224, 46);
            this.formButtonConvertFToC.TabIndex = 3;
            this.formButtonConvertFToC.Text = "Convert F to C";
            this.formButtonConvertFToC.UseVisualStyleBackColor = true;
            this.formButtonConvertFToC.Click += new System.EventHandler(this.formButtonConvertFToC_Click);
            // 
            // labelConvertedTemperature
            // 
            this.labelConvertedTemperature.AutoSize = true;
            this.labelConvertedTemperature.Location = new System.Drawing.Point(37, 224);
            this.labelConvertedTemperature.Name = "labelConvertedTemperature";
            this.labelConvertedTemperature.Size = new System.Drawing.Size(0, 32);
            this.labelConvertedTemperature.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.formButtonConvertCToF;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 440);
            this.Controls.Add(this.labelConvertedTemperature);
            this.Controls.Add(this.formButtonConvertFToC);
            this.Controls.Add(this.formButtonConvertCToF);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelValueToConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValueToConvert;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button formButtonConvertCToF;
        private System.Windows.Forms.Button formButtonConvertFToC;
        private System.Windows.Forms.Label labelConvertedTemperature;
    }
}
