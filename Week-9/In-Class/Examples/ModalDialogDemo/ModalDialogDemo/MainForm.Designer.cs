namespace ModalDialogDemo
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
            this.buttonShowEditDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(22, 84);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(73, 20);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "<Result>";
            // 
            // buttonShowEditDialog
            // 
            this.buttonShowEditDialog.Location = new System.Drawing.Point(26, 26);
            this.buttonShowEditDialog.Name = "buttonShowEditDialog";
            this.buttonShowEditDialog.Size = new System.Drawing.Size(94, 23);
            this.buttonShowEditDialog.TabIndex = 4;
            this.buttonShowEditDialog.Text = "&Edit Username...";
            this.buttonShowEditDialog.UseVisualStyleBackColor = true;
            this.buttonShowEditDialog.Click += new System.EventHandler(this.buttonShowEditDialog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 164);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonShowEditDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog Example With Data Passing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonShowEditDialog;
    }
}

