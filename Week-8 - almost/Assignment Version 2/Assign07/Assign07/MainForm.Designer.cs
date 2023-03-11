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
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.checkBoxIsTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountTotal = new System.Windows.Forms.Label();
            this.labelCreditHold = new System.Windows.Forms.Label();
            this.labelTaxable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 713);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 62;
            this.dataGridViewClients.RowTemplate.Height = 41;
            this.dataGridViewClients.Size = new System.Drawing.Size(1150, 346);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(37, 46);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(185, 32);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "CompanyName:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(37, 108);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(116, 32);
            this.labelAddress1.TabIndex = 2;
            this.labelAddress1.Text = "Address1:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(37, 170);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(116, 32);
            this.labelAddress2.TabIndex = 3;
            this.labelAddress2.Text = "Address2:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(37, 236);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(60, 32);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City:";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(37, 302);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(110, 32);
            this.labelProvince.TabIndex = 5;
            this.labelProvince.Text = "Province:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(37, 373);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(144, 32);
            this.labelPostalCode.TabIndex = 6;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(37, 445);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(116, 32);
            this.labelYTDSales.TabIndex = 7;
            this.labelYTDSales.Text = "YTDSales:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(37, 512);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(82, 32);
            this.labelNotes.TabIndex = 9;
            this.labelNotes.Text = "Notes:";
            // 
            // checkBoxIsTaxable
            // 
            this.checkBoxIsTaxable.AutoSize = true;
            this.checkBoxIsTaxable.Location = new System.Drawing.Point(264, 645);
            this.checkBoxIsTaxable.Name = "checkBoxIsTaxable";
            this.checkBoxIsTaxable.Size = new System.Drawing.Size(28, 27);
            this.checkBoxIsTaxable.TabIndex = 10;
            this.checkBoxIsTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(264, 39);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(486, 39);
            this.textBoxCompanyName.TabIndex = 11;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(264, 101);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(486, 39);
            this.textBoxAddress1.TabIndex = 12;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(264, 163);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(486, 39);
            this.textBoxAddress2.TabIndex = 13;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(264, 229);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 39);
            this.textBoxCity.TabIndex = 14;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(264, 295);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(200, 39);
            this.textBoxProvince.TabIndex = 15;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(264, 366);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(200, 39);
            this.textBoxPostalCode.TabIndex = 16;
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(264, 438);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(200, 39);
            this.textBoxYTDSales.TabIndex = 17;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(264, 512);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(486, 39);
            this.textBoxNotes.TabIndex = 19;
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(264, 591);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(28, 27);
            this.checkBoxCreditHold.TabIndex = 20;
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(600, 635);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 46);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(13, 1076);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(84, 32);
            this.labelCount.TabIndex = 22;
            this.labelCount.Text = "Count:";
            // 
            // labelCountTotal
            // 
            this.labelCountTotal.AutoSize = true;
            this.labelCountTotal.Location = new System.Drawing.Point(113, 1076);
            this.labelCountTotal.Name = "labelCountTotal";
            this.labelCountTotal.Size = new System.Drawing.Size(111, 32);
            this.labelCountTotal.TabIndex = 23;
            this.labelCountTotal.Text = "<Count>";
            // 
            // labelCreditHold
            // 
            this.labelCreditHold.AutoSize = true;
            this.labelCreditHold.Location = new System.Drawing.Point(298, 586);
            this.labelCreditHold.Name = "labelCreditHold";
            this.labelCreditHold.Size = new System.Drawing.Size(136, 32);
            this.labelCreditHold.TabIndex = 24;
            this.labelCreditHold.Text = "Credit Hold";
            // 
            // labelTaxable
            // 
            this.labelTaxable.AutoSize = true;
            this.labelTaxable.Location = new System.Drawing.Point(298, 640);
            this.labelTaxable.Name = "labelTaxable";
            this.labelTaxable.Size = new System.Drawing.Size(92, 32);
            this.labelTaxable.TabIndex = 25;
            this.labelTaxable.Text = "Taxable";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1125);
            this.Controls.Add(this.labelTaxable);
            this.Controls.Add(this.labelCreditHold);
            this.Controls.Add(this.labelCountTotal);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.checkBoxIsTaxable);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelYTDSales);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelCompanyName);
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
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.CheckBox checkBoxIsTaxable;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountTotal;
        private System.Windows.Forms.Label labelCreditHold;
        private System.Windows.Forms.Label labelTaxable;
    }
}
