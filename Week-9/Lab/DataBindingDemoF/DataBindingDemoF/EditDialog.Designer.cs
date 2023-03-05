namespace DataBindingDemoF
{
    partial class EditDialog
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
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSKU = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelExtension = new System.Windows.Forms.Label();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(51, 48);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(98, 25);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Location = new System.Drawing.Point(52, 111);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(61, 25);
            this.labelSKU.TabIndex = 1;
            this.labelSKU.Text = "SKU:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(52, 176);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(126, 25);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(52, 242);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(62, 25);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Cost:";
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(51, 308);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(113, 25);
            this.labelExtension.TabIndex = 4;
            this.labelExtension.Text = "Extension:";
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(203, 381);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(121, 29);
            this.checkBoxTaxable.TabIndex = 5;
            this.checkBoxTaxable.Text = "Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(203, 42);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(199, 31);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Location = new System.Drawing.Point(203, 105);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(199, 31);
            this.textBoxSKU.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(203, 170);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(342, 31);
            this.textBoxDescription.TabIndex = 8;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(203, 236);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(199, 31);
            this.textBoxCost.TabIndex = 9;
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(203, 302);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(199, 31);
            this.textBoxExtension.TabIndex = 10;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(276, 447);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(126, 37);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(427, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 37);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 513);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSKU);
            this.Controls.Add(this.labelQuantity);
            this.MaximizeBox = false;
            this.Name = "EditDialog";
            this.Text = "Product Edit Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}