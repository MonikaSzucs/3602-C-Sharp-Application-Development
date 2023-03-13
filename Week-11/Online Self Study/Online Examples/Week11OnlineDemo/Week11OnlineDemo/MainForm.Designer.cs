namespace Week11OnlineDemo
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
            this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
            this.linkLabelDirectory = new System.Windows.Forms.LinkLabel();
            this.linklabelApp = new System.Windows.Forms.LinkLabel();
            this.domainUpDownNumbers = new System.Windows.Forms.DomainUpDown();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.labelDomainValue = new System.Windows.Forms.Label();
            this.labelNumericValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelWeb
            // 
            this.linkLabelWeb.AutoSize = true;
            this.linkLabelWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWeb.Location = new System.Drawing.Point(367, 30);
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.Size = new System.Drawing.Size(72, 15);
            this.linkLabelWeb.TabIndex = 0;
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.Text = "www.bcit.ca";
            this.linkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWeb_LinkClicked);
            // 
            // linkLabelDirectory
            // 
            this.linkLabelDirectory.AutoSize = true;
            this.linkLabelDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDirectory.Location = new System.Drawing.Point(367, 57);
            this.linkLabelDirectory.Name = "linkLabelDirectory";
            this.linkLabelDirectory.Size = new System.Drawing.Size(72, 15);
            this.linkLabelDirectory.TabIndex = 1;
            this.linkLabelDirectory.TabStop = true;
            this.linkLabelDirectory.Text = "Directory C:\\";
            this.linkLabelDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDirectory_LinkClicked);
            // 
            // linklabelApp
            // 
            this.linklabelApp.AutoSize = true;
            this.linklabelApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabelApp.Location = new System.Drawing.Point(367, 84);
            this.linklabelApp.Name = "linklabelApp";
            this.linklabelApp.Size = new System.Drawing.Size(62, 15);
            this.linklabelApp.TabIndex = 2;
            this.linklabelApp.TabStop = true;
            this.linklabelApp.Text = "Calculator";
            this.linklabelApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelApp_LinkClicked);
            // 
            // domainUpDownNumbers
            // 
            this.domainUpDownNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.domainUpDownNumbers.Location = new System.Drawing.Point(26, 28);
            this.domainUpDownNumbers.Name = "domainUpDownNumbers";
            this.domainUpDownNumbers.ReadOnly = true;
            this.domainUpDownNumbers.Size = new System.Drawing.Size(137, 20);
            this.domainUpDownNumbers.TabIndex = 3;
            this.domainUpDownNumbers.SelectedItemChanged += new System.EventHandler(this.domainUpDownNumbers_SelectedItemChanged);
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Location = new System.Drawing.Point(202, 28);
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPages.TabIndex = 4;
            this.numericUpDownPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPages.ValueChanged += new System.EventHandler(this.numericUpDownPages_ValueChanged);
            // 
            // labelDomainValue
            // 
            this.labelDomainValue.AutoSize = true;
            this.labelDomainValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomainValue.Location = new System.Drawing.Point(22, 65);
            this.labelDomainValue.Name = "labelDomainValue";
            this.labelDomainValue.Size = new System.Drawing.Size(122, 20);
            this.labelDomainValue.TabIndex = 5;
            this.labelDomainValue.Text = "<Domain Value>";
            // 
            // labelNumericValue
            // 
            this.labelNumericValue.AutoSize = true;
            this.labelNumericValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumericValue.Location = new System.Drawing.Point(198, 65);
            this.labelNumericValue.Name = "labelNumericValue";
            this.labelNumericValue.Size = new System.Drawing.Size(125, 20);
            this.labelNumericValue.TabIndex = 6;
            this.labelNumericValue.Text = "<Numeric Value>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 168);
            this.Controls.Add(this.labelNumericValue);
            this.Controls.Add(this.labelDomainValue);
            this.Controls.Add(this.numericUpDownPages);
            this.Controls.Add(this.domainUpDownNumbers);
            this.Controls.Add(this.linklabelApp);
            this.Controls.Add(this.linkLabelDirectory);
            this.Controls.Add(this.linkLabelWeb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomainUpDown NumericUpDown and LinkLabel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelWeb;
        private System.Windows.Forms.LinkLabel linkLabelDirectory;
        private System.Windows.Forms.LinkLabel linklabelApp;
        private System.Windows.Forms.DomainUpDown domainUpDownNumbers;
        private System.Windows.Forms.NumericUpDown numericUpDownPages;
        private System.Windows.Forms.Label labelDomainValue;
        private System.Windows.Forms.Label labelNumericValue;
    }
}

