namespace DataBindingDemoF
{
    partial class ProductEditDialog
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
            this.labelExtPrompt = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelQuantityPrompt = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelCostPrompt = new System.Windows.Forms.Label();
            this.labelDescriptionPrompt = new System.Windows.Forms.Label();
            this.labelSkuPrompt = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExtPrompt
            // 
            this.labelExtPrompt.AutoSize = true;
            this.labelExtPrompt.Location = new System.Drawing.Point(18, 156);
            this.labelExtPrompt.Name = "labelExtPrompt";
            this.labelExtPrompt.Size = new System.Drawing.Size(56, 13);
            this.labelExtPrompt.TabIndex = 20;
            this.labelExtPrompt.Text = "Extension:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExtension.Location = new System.Drawing.Point(87, 153);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.ReadOnly = true;
            this.textBoxExtension.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtension.TabIndex = 21;
            this.textBoxExtension.TabStop = false;
            this.textBoxExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuantityPrompt
            // 
            this.labelQuantityPrompt.AutoSize = true;
            this.labelQuantityPrompt.Location = new System.Drawing.Point(18, 23);
            this.labelQuantityPrompt.Name = "labelQuantityPrompt";
            this.labelQuantityPrompt.Size = new System.Drawing.Size(49, 13);
            this.labelQuantityPrompt.TabIndex = 12;
            this.labelQuantityPrompt.Text = "&Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxQuantity.Location = new System.Drawing.Point(87, 20);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 13;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCostPrompt
            // 
            this.labelCostPrompt.AutoSize = true;
            this.labelCostPrompt.Location = new System.Drawing.Point(18, 121);
            this.labelCostPrompt.Name = "labelCostPrompt";
            this.labelCostPrompt.Size = new System.Drawing.Size(31, 13);
            this.labelCostPrompt.TabIndex = 18;
            this.labelCostPrompt.Text = "&Cost:";
            // 
            // labelDescriptionPrompt
            // 
            this.labelDescriptionPrompt.AutoSize = true;
            this.labelDescriptionPrompt.Location = new System.Drawing.Point(18, 87);
            this.labelDescriptionPrompt.Name = "labelDescriptionPrompt";
            this.labelDescriptionPrompt.Size = new System.Drawing.Size(63, 13);
            this.labelDescriptionPrompt.TabIndex = 16;
            this.labelDescriptionPrompt.Text = "&Description:";
            // 
            // labelSkuPrompt
            // 
            this.labelSkuPrompt.AutoSize = true;
            this.labelSkuPrompt.Location = new System.Drawing.Point(18, 53);
            this.labelSkuPrompt.Name = "labelSkuPrompt";
            this.labelSkuPrompt.Size = new System.Drawing.Size(32, 13);
            this.labelSkuPrompt.TabIndex = 14;
            this.labelSkuPrompt.Text = "&SKU:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(209, 236);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxSku
            // 
            this.textBoxSku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSku.Location = new System.Drawing.Point(87, 51);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 20);
            this.textBoxSku.TabIndex = 15;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(87, 84);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(173, 20);
            this.textBoxDescription.TabIndex = 17;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(86, 199);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 22;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(87, 118);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 19;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(124, 236);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 24;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ProductEditDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelExtPrompt);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.labelQuantityPrompt);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelCostPrompt);
            this.Controls.Add(this.labelDescriptionPrompt);
            this.Controls.Add(this.labelSkuPrompt);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "ProductEditDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Edit Dialog";
            this.Load += new System.EventHandler(this.ProductEditDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExtPrompt;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelQuantityPrompt;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelCostPrompt;
        private System.Windows.Forms.Label labelDescriptionPrompt;
        private System.Windows.Forms.Label labelSkuPrompt;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonOK;
    }
}