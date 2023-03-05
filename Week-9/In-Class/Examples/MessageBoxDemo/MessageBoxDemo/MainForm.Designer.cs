namespace MessageBoxDemo
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
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonAlertEnhanced = new System.Windows.Forms.Button();
            this.buttonAlertBasic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(136, 122);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(84, 24);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "<Result>";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(27, 123);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(97, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "&Confirmation";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonAlertEnhanced
            // 
            this.buttonAlertEnhanced.Location = new System.Drawing.Point(27, 74);
            this.buttonAlertEnhanced.Name = "buttonAlertEnhanced";
            this.buttonAlertEnhanced.Size = new System.Drawing.Size(97, 23);
            this.buttonAlertEnhanced.TabIndex = 5;
            this.buttonAlertEnhanced.Text = "Alert &Enhanced";
            this.buttonAlertEnhanced.UseVisualStyleBackColor = true;
            this.buttonAlertEnhanced.Click += new System.EventHandler(this.buttonAlertEnhanced_Click);
            // 
            // buttonAlertBasic
            // 
            this.buttonAlertBasic.Location = new System.Drawing.Point(27, 24);
            this.buttonAlertBasic.Name = "buttonAlertBasic";
            this.buttonAlertBasic.Size = new System.Drawing.Size(97, 23);
            this.buttonAlertBasic.TabIndex = 4;
            this.buttonAlertBasic.Text = "Alert &Basic";
            this.buttonAlertBasic.UseVisualStyleBackColor = true;
            this.buttonAlertBasic.Click += new System.EventHandler(this.buttonAlertBasic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 183);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonAlertEnhanced);
            this.Controls.Add(this.buttonAlertBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonAlertEnhanced;
        private System.Windows.Forms.Button buttonAlertBasic;
    }
}

