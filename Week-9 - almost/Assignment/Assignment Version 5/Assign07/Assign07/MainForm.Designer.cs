namespace Assign07
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.labelCountTaxableClients = new System.Windows.Forms.Label();
            this.labelCountTotalCreditHold = new System.Windows.Forms.Label();
            this.labelTotals = new System.Windows.Forms.Label();
            this.labelClientLegend = new System.Windows.Forms.Label();
            this.labelCountIsTaxable = new System.Windows.Forms.Label();
            this.labelCountTotalIsTaxable = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 345);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 62;
            this.dataGridViewClients.RowTemplate.Height = 41;
            this.dataGridViewClients.Size = new System.Drawing.Size(1188, 396);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentDoubleClick);
            this.dataGridViewClients.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // labelCountTaxableClients
            // 
            this.labelCountTaxableClients.AutoSize = true;
            this.labelCountTaxableClients.Location = new System.Drawing.Point(12, 779);
            this.labelCountTaxableClients.Name = "labelCountTaxableClients";
            this.labelCountTaxableClients.Size = new System.Drawing.Size(213, 32);
            this.labelCountTaxableClients.TabIndex = 22;
            this.labelCountTaxableClients.Text = "Count Credit Hold:";
            // 
            // labelCountTotalCreditHold
            // 
            this.labelCountTotalCreditHold.AutoSize = true;
            this.labelCountTotalCreditHold.Location = new System.Drawing.Point(326, 779);
            this.labelCountTotalCreditHold.Name = "labelCountTotalCreditHold";
            this.labelCountTotalCreditHold.Size = new System.Drawing.Size(111, 32);
            this.labelCountTotalCreditHold.TabIndex = 23;
            this.labelCountTotalCreditHold.Text = "<Count>";
            // 
            // labelTotals
            // 
            this.labelTotals.AutoSize = true;
            this.labelTotals.Location = new System.Drawing.Point(1007, 92);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(107, 32);
            this.labelTotals.TabIndex = 26;
            this.labelTotals.Text = "<Totals>";
            // 
            // labelClientLegend
            // 
            this.labelClientLegend.AutoSize = true;
            this.labelClientLegend.Location = new System.Drawing.Point(820, 92);
            this.labelClientLegend.Name = "labelClientLegend";
            this.labelClientLegend.Size = new System.Drawing.Size(194, 32);
            this.labelClientLegend.TabIndex = 27;
            this.labelClientLegend.Text = "<Client Legend>";
            // 
            // labelCountIsTaxable
            // 
            this.labelCountIsTaxable.AutoSize = true;
            this.labelCountIsTaxable.Location = new System.Drawing.Point(12, 827);
            this.labelCountIsTaxable.Name = "labelCountIsTaxable";
            this.labelCountIsTaxable.Size = new System.Drawing.Size(185, 32);
            this.labelCountIsTaxable.TabIndex = 30;
            this.labelCountIsTaxable.Text = "Count IsTaxable:";
            // 
            // labelCountTotalIsTaxable
            // 
            this.labelCountTotalIsTaxable.AutoSize = true;
            this.labelCountTotalIsTaxable.Location = new System.Drawing.Point(326, 827);
            this.labelCountTotalIsTaxable.Name = "labelCountTotalIsTaxable";
            this.labelCountTotalIsTaxable.Size = new System.Drawing.Size(111, 32);
            this.labelCountTotalIsTaxable.TabIndex = 31;
            this.labelCountTotalIsTaxable.Text = "<Count>";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(864, 813);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 46);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(1050, 813);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(150, 46);
            this.buttonNew.TabIndex = 33;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 888);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelCountTotalIsTaxable);
            this.Controls.Add(this.labelCountIsTaxable);
            this.Controls.Add(this.labelClientLegend);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.labelCountTotalCreditHold);
            this.Controls.Add(this.labelCountTaxableClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label labelCountTaxableClients;
        private System.Windows.Forms.Label labelCountTotalCreditHold;
        private System.Windows.Forms.Label labelTotals;
        private System.Windows.Forms.Label labelClientLegend;
        private System.Windows.Forms.Label labelCountIsTaxable;
        private System.Windows.Forms.Label labelCountTotalIsTaxable;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
    }
}
