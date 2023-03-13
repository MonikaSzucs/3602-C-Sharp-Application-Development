namespace DataBindingDemoF
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelTotals = new System.Windows.Forms.Label();
            this.labelProductLegend = new System.Windows.Forms.Label();
            this.labelCostPrompt = new System.Windows.Forms.Label();
            this.labelDescriptionPrompt = new System.Windows.Forms.Label();
            this.labelSkuPrompt = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelGrid = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(32, 412);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1554, 580);
            this.dataGridViewProducts.TabIndex = 9;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // labelTotals
            // 
            this.labelTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotals.Location = new System.Drawing.Point(1141, 43);
            this.labelTotals.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(440, 260);
            this.labelTotals.TabIndex = 11;
            this.labelTotals.Text = "One\r\nTwo\r\nThree\r\nFour\r\nFive\r\nSix";
            // 
            // labelProductLegend
            // 
            this.labelProductLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductLegend.Location = new System.Drawing.Point(942, 43);
            this.labelProductLegend.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelProductLegend.Name = "labelProductLegend";
            this.labelProductLegend.Size = new System.Drawing.Size(260, 260);
            this.labelProductLegend.TabIndex = 10;
            this.labelProductLegend.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6";
            // 
            // labelCostPrompt
            // 
            this.labelCostPrompt.AutoSize = true;
            this.labelCostPrompt.Location = new System.Drawing.Point(25, 212);
            this.labelCostPrompt.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCostPrompt.Name = "labelCostPrompt";
            this.labelCostPrompt.Size = new System.Drawing.Size(81, 32);
            this.labelCostPrompt.TabIndex = 4;
            this.labelCostPrompt.Text = "Cost:";
            // 
            // labelDescriptionPrompt
            // 
            this.labelDescriptionPrompt.AutoSize = true;
            this.labelDescriptionPrompt.Location = new System.Drawing.Point(25, 132);
            this.labelDescriptionPrompt.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelDescriptionPrompt.Name = "labelDescriptionPrompt";
            this.labelDescriptionPrompt.Size = new System.Drawing.Size(166, 32);
            this.labelDescriptionPrompt.TabIndex = 2;
            this.labelDescriptionPrompt.Text = "&Description:";
            // 
            // labelSkuPrompt
            // 
            this.labelSkuPrompt.AutoSize = true;
            this.labelSkuPrompt.Location = new System.Drawing.Point(25, 50);
            this.labelSkuPrompt.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelSkuPrompt.Name = "labelSkuPrompt";
            this.labelSkuPrompt.Size = new System.Drawing.Size(81, 32);
            this.labelSkuPrompt.TabIndex = 0;
            this.labelSkuPrompt.Text = "&SKU:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(468, 287);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(199, 54);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSku
            // 
            this.textBoxSku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSku.Location = new System.Drawing.Point(208, 43);
            this.textBoxSku.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(260, 38);
            this.textBoxSku.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(208, 124);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(456, 38);
            this.textBoxDescription.TabIndex = 3;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(208, 296);
            this.checkBoxTaxable.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(155, 36);
            this.checkBoxTaxable.TabIndex = 6;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(208, 205);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(260, 38);
            this.textBoxCost.TabIndex = 5;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelGrid
            // 
            this.labelGrid.AutoSize = true;
            this.labelGrid.Location = new System.Drawing.Point(837, 598);
            this.labelGrid.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(129, 32);
            this.labelGrid.TabIndex = 0;
            this.labelGrid.Text = "Data&Grid";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(159, 1029);
            this.labelCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(123, 32);
            this.labelCount.TabIndex = 13;
            this.labelCount.Text = "<Count>";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(1387, 1007);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(199, 54);
            this.buttonNew.TabIndex = 14;
            this.buttonNew.Text = "&New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 1029);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Count:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 1085);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.labelProductLegend);
            this.Controls.Add(this.labelCostPrompt);
            this.Controls.Add(this.labelDescriptionPrompt);
            this.Controls.Add(this.labelSkuPrompt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelTotals;
        private System.Windows.Forms.Label labelProductLegend;
        private System.Windows.Forms.Label labelCostPrompt;
        private System.Windows.Forms.Label labelDescriptionPrompt;
        private System.Windows.Forms.Label labelSkuPrompt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelGrid;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label1;
    }
}

