namespace DataBindingDemoA
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.checkBoxOnPropertyChanged = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxOpB = new System.Windows.Forms.TextBox();
            this.textBoxOpA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxOnPropertyChanged
            // 
            this.checkBoxOnPropertyChanged.AutoSize = true;
            this.checkBoxOnPropertyChanged.Checked = true;
            this.checkBoxOnPropertyChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnPropertyChanged.Location = new System.Drawing.Point(49, 138);
            this.checkBoxOnPropertyChanged.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.checkBoxOnPropertyChanged.Name = "checkBoxOnPropertyChanged";
            this.checkBoxOnPropertyChanged.Size = new System.Drawing.Size(266, 33);
            this.checkBoxOnPropertyChanged.TabIndex = 17;
            this.checkBoxOnPropertyChanged.Text = "&OnPropertyChanged";
            this.checkBoxOnPropertyChanged.UseVisualStyleBackColor = true;
            this.checkBoxOnPropertyChanged.CheckedChanged += new System.EventHandler(this.checkBoxOnPropertyChanged_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(471, 47);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(135, 35);
            this.textBoxResult.TabIndex = 14;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOpB
            // 
            this.textBoxOpB.Location = new System.Drawing.Point(240, 47);
            this.textBoxOpB.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxOpB.Name = "textBoxOpB";
            this.textBoxOpB.Size = new System.Drawing.Size(135, 35);
            this.textBoxOpB.TabIndex = 13;
            this.textBoxOpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOpB.TextChanged += new System.EventHandler(this.textBoxOpB_TextChanged);
            // 
            // textBoxOpA
            // 
            this.textBoxOpA.Location = new System.Drawing.Point(49, 47);
            this.textBoxOpA.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxOpA.Name = "textBoxOpA";
            this.textBoxOpA.Size = new System.Drawing.Size(135, 35);
            this.textBoxOpA.TabIndex = 12;
            this.textBoxOpA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOpA.TextChanged += new System.EventHandler(this.textBoxOpA_TextChanged);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 248);
            this.Controls.Add(this.checkBoxOnPropertyChanged);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxOpB);
            this.Controls.Add(this.textBoxOpA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding Example";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxOnPropertyChanged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxOpB;
        private System.Windows.Forms.TextBox textBoxOpA;
    }
}

