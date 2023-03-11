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
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExtPrompt = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelPricePrompt = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelQuantityPrompt = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 481);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1166, 506);
            this.dataGridViewProducts.TabIndex = 14;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // labelTotals
            // 
            this.labelTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotals.Location = new System.Drawing.Point(856, 35);
            this.labelTotals.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(310, 210);
            this.labelTotals.TabIndex = 18;
            this.labelTotals.Text = "One\r\nTwo\r\nThree\r\nFour\r\nFive\r\nSix";
            this.labelTotals.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelProductLegend
            // 
            this.labelProductLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductLegend.Location = new System.Drawing.Point(706, 35);
            this.labelProductLegend.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProductLegend.Name = "labelProductLegend";
            this.labelProductLegend.Size = new System.Drawing.Size(196, 210);
            this.labelProductLegend.TabIndex = 17;
            this.labelProductLegend.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6";
            // 
            // labelCostPrompt
            // 
            this.labelCostPrompt.AutoSize = true;
            this.labelCostPrompt.Location = new System.Drawing.Point(18, 229);
            this.labelCostPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCostPrompt.Name = "labelCostPrompt";
            this.labelCostPrompt.Size = new System.Drawing.Size(62, 25);
            this.labelCostPrompt.TabIndex = 6;
            this.labelCostPrompt.Text = "&Cost:";
            // 
            // labelDescriptionPrompt
            // 
            this.labelDescriptionPrompt.AutoSize = true;
            this.labelDescriptionPrompt.Location = new System.Drawing.Point(18, 100);
            this.labelDescriptionPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDescriptionPrompt.Name = "labelDescriptionPrompt";
            this.labelDescriptionPrompt.Size = new System.Drawing.Size(126, 25);
            this.labelDescriptionPrompt.TabIndex = 2;
            this.labelDescriptionPrompt.Text = "&Description:";
            // 
            // labelSkuPrompt
            // 
            this.labelSkuPrompt.AutoSize = true;
            this.labelSkuPrompt.Location = new System.Drawing.Point(18, 40);
            this.labelSkuPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSkuPrompt.Name = "labelSkuPrompt";
            this.labelSkuPrompt.Size = new System.Drawing.Size(61, 25);
            this.labelSkuPrompt.TabIndex = 0;
            this.labelSkuPrompt.Text = "&SKU:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(348, 425);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 44);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSku
            // 
            this.textBoxSku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSku.Location = new System.Drawing.Point(156, 35);
            this.textBoxSku.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(196, 31);
            this.textBoxSku.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(156, 94);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(344, 31);
            this.textBoxDescription.TabIndex = 3;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(152, 431);
            this.checkBoxTaxable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(121, 29);
            this.checkBoxTaxable.TabIndex = 12;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(156, 223);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(196, 31);
            this.textBoxCost.TabIndex = 7;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(116, 1017);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(93, 25);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "<Count>";
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Location = new System.Drawing.Point(1028, 1008);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(150, 44);
            this.buttonNew.TabIndex = 19;
            this.buttonNew.Text = "&New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 1017);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Count:";
            // 
            // labelExtPrompt
            // 
            this.labelExtPrompt.AutoSize = true;
            this.labelExtPrompt.Location = new System.Drawing.Point(18, 360);
            this.labelExtPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelExtPrompt.Name = "labelExtPrompt";
            this.labelExtPrompt.Size = new System.Drawing.Size(113, 25);
            this.labelExtPrompt.TabIndex = 10;
            this.labelExtPrompt.Text = "E&xtension:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExtension.Enabled = false;
            this.textBoxExtension.Location = new System.Drawing.Point(156, 356);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.ReadOnly = true;
            this.textBoxExtension.Size = new System.Drawing.Size(196, 31);
            this.textBoxExtension.TabIndex = 11;
            this.textBoxExtension.TabStop = false;
            this.textBoxExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPricePrompt
            // 
            this.labelPricePrompt.AutoSize = true;
            this.labelPricePrompt.Location = new System.Drawing.Point(18, 294);
            this.labelPricePrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPricePrompt.Name = "labelPricePrompt";
            this.labelPricePrompt.Size = new System.Drawing.Size(61, 25);
            this.labelPricePrompt.TabIndex = 8;
            this.labelPricePrompt.Text = "&Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(156, 287);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(196, 31);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuantityPrompt
            // 
            this.labelQuantityPrompt.AutoSize = true;
            this.labelQuantityPrompt.Location = new System.Drawing.Point(18, 162);
            this.labelQuantityPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelQuantityPrompt.Name = "labelQuantityPrompt";
            this.labelQuantityPrompt.Size = new System.Drawing.Size(98, 25);
            this.labelQuantityPrompt.TabIndex = 4;
            this.labelQuantityPrompt.Text = "&Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxQuantity.Location = new System.Drawing.Point(156, 156);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(196, 31);
            this.textBoxQuantity.TabIndex = 5;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 1065);
            this.Controls.Add(this.labelQuantityPrompt);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelExtPrompt);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.labelPricePrompt);
            this.Controls.Add(this.textBoxPrice);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1218, 1075);
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
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelExtPrompt;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelPricePrompt;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelQuantityPrompt;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}

