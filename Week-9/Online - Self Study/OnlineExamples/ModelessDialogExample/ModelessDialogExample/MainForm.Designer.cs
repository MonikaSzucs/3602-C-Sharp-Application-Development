namespace ModelessDialogExample
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
            this.buttonOpenModeless = new System.Windows.Forms.Button();
            this.buttonSingletonModeless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenModeless
            // 
            this.buttonOpenModeless.Location = new System.Drawing.Point(39, 39);
            this.buttonOpenModeless.Name = "buttonOpenModeless";
            this.buttonOpenModeless.Size = new System.Drawing.Size(148, 23);
            this.buttonOpenModeless.TabIndex = 0;
            this.buttonOpenModeless.Text = "Open Modeless";
            this.buttonOpenModeless.UseVisualStyleBackColor = true;
            this.buttonOpenModeless.Click += new System.EventHandler(this.buttonOpenModeless_Click);
            // 
            // buttonSingletonModeless
            // 
            this.buttonSingletonModeless.Location = new System.Drawing.Point(226, 39);
            this.buttonSingletonModeless.Name = "buttonSingletonModeless";
            this.buttonSingletonModeless.Size = new System.Drawing.Size(148, 23);
            this.buttonSingletonModeless.TabIndex = 1;
            this.buttonSingletonModeless.Text = "Open Singleton Modeless";
            this.buttonSingletonModeless.UseVisualStyleBackColor = true;
            this.buttonSingletonModeless.Click += new System.EventHandler(this.buttonSingletonModeless_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 118);
            this.Controls.Add(this.buttonSingletonModeless);
            this.Controls.Add(this.buttonOpenModeless);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeless Dialogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenModeless;
        private System.Windows.Forms.Button buttonSingletonModeless;
    }
}

