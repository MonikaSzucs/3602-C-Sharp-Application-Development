namespace DataBindingDemoD
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxLineAmounts = new System.Windows.Forms.ListBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxLineAmount = new System.Windows.Forms.TextBox();
            this.buttonAddAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(190, 248);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.MinimumSize = new System.Drawing.Size(77, 34);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(77, 34);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxLineAmounts
            // 
            this.listBoxLineAmounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLineAmounts.Location = new System.Drawing.Point(21, 79);
            this.listBoxLineAmounts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLineAmounts.Name = "listBoxLineAmounts";
            this.listBoxLineAmounts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLineAmounts.Size = new System.Drawing.Size(151, 147);
            this.listBoxLineAmounts.TabIndex = 2;
            this.listBoxLineAmounts.TabStop = false;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalAmount.Enabled = false;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(21, 252);
            this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(151, 24);
            this.textBoxTotalAmount.TabIndex = 4;
            // 
            // textBoxLineAmount
            // 
            this.textBoxLineAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLineAmount.Location = new System.Drawing.Point(21, 32);
            this.textBoxLineAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLineAmount.Name = "textBoxLineAmount";
            this.textBoxLineAmount.Size = new System.Drawing.Size(151, 23);
            this.textBoxLineAmount.TabIndex = 0;
            // 
            // buttonAddAmount
            // 
            this.buttonAddAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAmount.Location = new System.Drawing.Point(190, 25);
            this.buttonAddAmount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddAmount.Name = "buttonAddAmount";
            this.buttonAddAmount.Size = new System.Drawing.Size(77, 34);
            this.buttonAddAmount.TabIndex = 1;
            this.buttonAddAmount.Text = "&Add Amount";
            this.buttonAddAmount.UseVisualStyleBackColor = true;
            this.buttonAddAmount.Click += new System.EventHandler(this.buttonAddAmount_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonAddAmount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(289, 307);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxLineAmounts);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.textBoxLineAmount);
            this.Controls.Add(this.buttonAddAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxLineAmounts;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxLineAmount;
        private System.Windows.Forms.Button buttonAddAmount;
    }
}

