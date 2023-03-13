namespace KeyPadDemo
{
    partial class KeyPadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyPadForm));
            this.tableLayoutPanelKeyPad = new System.Windows.Forms.TableLayoutPanel();
            this.buttonKey7 = new System.Windows.Forms.Button();
            this.buttonKey8 = new System.Windows.Forms.Button();
            this.buttonKey9 = new System.Windows.Forms.Button();
            this.buttonKey4 = new System.Windows.Forms.Button();
            this.buttonKey5 = new System.Windows.Forms.Button();
            this.buttonKey6 = new System.Windows.Forms.Button();
            this.buttonKey1 = new System.Windows.Forms.Button();
            this.buttonKey2 = new System.Windows.Forms.Button();
            this.buttonKey3 = new System.Windows.Forms.Button();
            this.buttonKeyClear = new System.Windows.Forms.Button();
            this.buttonKey0 = new System.Windows.Forms.Button();
            this.buttonKeyDecimal = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanelKeyPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelKeyPad
            // 
            this.tableLayoutPanelKeyPad.AutoSize = true;
            this.tableLayoutPanelKeyPad.ColumnCount = 3;
            this.tableLayoutPanelKeyPad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelKeyPad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelKeyPad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey7, 0, 0);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey8, 1, 0);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey9, 2, 0);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey4, 0, 1);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey5, 1, 1);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey6, 2, 1);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey1, 0, 2);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey2, 1, 2);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey3, 2, 2);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKeyClear, 0, 3);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKey0, 1, 3);
            this.tableLayoutPanelKeyPad.Controls.Add(this.buttonKeyDecimal, 2, 3);
            this.tableLayoutPanelKeyPad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelKeyPad.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelKeyPad.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanelKeyPad.Name = "tableLayoutPanelKeyPad";
            this.tableLayoutPanelKeyPad.RowCount = 4;
            this.tableLayoutPanelKeyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeyPad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeyPad.Size = new System.Drawing.Size(265, 276);
            this.tableLayoutPanelKeyPad.TabIndex = 3;
            // 
            // buttonKey7
            // 
            this.buttonKey7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey7.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey7.Location = new System.Drawing.Point(3, 3);
            this.buttonKey7.Name = "buttonKey7";
            this.buttonKey7.Size = new System.Drawing.Size(82, 63);
            this.buttonKey7.TabIndex = 0;
            this.buttonKey7.TabStop = false;
            this.buttonKey7.Text = "7";
            this.buttonKey7.UseVisualStyleBackColor = true;
            this.buttonKey7.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey8
            // 
            this.buttonKey8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey8.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey8.Location = new System.Drawing.Point(91, 3);
            this.buttonKey8.Name = "buttonKey8";
            this.buttonKey8.Size = new System.Drawing.Size(82, 63);
            this.buttonKey8.TabIndex = 1;
            this.buttonKey8.TabStop = false;
            this.buttonKey8.Text = "8";
            this.buttonKey8.UseVisualStyleBackColor = true;
            this.buttonKey8.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey9
            // 
            this.buttonKey9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey9.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey9.Location = new System.Drawing.Point(179, 3);
            this.buttonKey9.Name = "buttonKey9";
            this.buttonKey9.Size = new System.Drawing.Size(83, 63);
            this.buttonKey9.TabIndex = 2;
            this.buttonKey9.TabStop = false;
            this.buttonKey9.Text = "9";
            this.buttonKey9.UseVisualStyleBackColor = true;
            this.buttonKey9.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey4
            // 
            this.buttonKey4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey4.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey4.Location = new System.Drawing.Point(3, 72);
            this.buttonKey4.Name = "buttonKey4";
            this.buttonKey4.Size = new System.Drawing.Size(82, 63);
            this.buttonKey4.TabIndex = 3;
            this.buttonKey4.TabStop = false;
            this.buttonKey4.Text = "4";
            this.buttonKey4.UseVisualStyleBackColor = true;
            this.buttonKey4.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey5
            // 
            this.buttonKey5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey5.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey5.Location = new System.Drawing.Point(91, 72);
            this.buttonKey5.Name = "buttonKey5";
            this.buttonKey5.Size = new System.Drawing.Size(82, 63);
            this.buttonKey5.TabIndex = 4;
            this.buttonKey5.TabStop = false;
            this.buttonKey5.Text = "5";
            this.buttonKey5.UseVisualStyleBackColor = true;
            this.buttonKey5.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey6
            // 
            this.buttonKey6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey6.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey6.Location = new System.Drawing.Point(179, 72);
            this.buttonKey6.Name = "buttonKey6";
            this.buttonKey6.Size = new System.Drawing.Size(83, 63);
            this.buttonKey6.TabIndex = 5;
            this.buttonKey6.TabStop = false;
            this.buttonKey6.Text = "6";
            this.buttonKey6.UseVisualStyleBackColor = true;
            this.buttonKey6.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey1
            // 
            this.buttonKey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey1.Font = new System.Drawing.Font("Dubai", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey1.Location = new System.Drawing.Point(3, 141);
            this.buttonKey1.Name = "buttonKey1";
            this.buttonKey1.Size = new System.Drawing.Size(82, 63);
            this.buttonKey1.TabIndex = 6;
            this.buttonKey1.TabStop = false;
            this.buttonKey1.Text = "1";
            this.buttonKey1.UseVisualStyleBackColor = true;
            this.buttonKey1.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey2
            // 
            this.buttonKey2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey2.Font = new System.Drawing.Font("Dubai", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey2.Location = new System.Drawing.Point(91, 141);
            this.buttonKey2.Name = "buttonKey2";
            this.buttonKey2.Size = new System.Drawing.Size(82, 63);
            this.buttonKey2.TabIndex = 7;
            this.buttonKey2.TabStop = false;
            this.buttonKey2.Text = "2";
            this.buttonKey2.UseVisualStyleBackColor = true;
            this.buttonKey2.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey3
            // 
            this.buttonKey3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey3.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey3.Location = new System.Drawing.Point(179, 141);
            this.buttonKey3.Name = "buttonKey3";
            this.buttonKey3.Size = new System.Drawing.Size(83, 63);
            this.buttonKey3.TabIndex = 8;
            this.buttonKey3.TabStop = false;
            this.buttonKey3.Text = "3";
            this.buttonKey3.UseVisualStyleBackColor = true;
            this.buttonKey3.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKeyClear
            // 
            this.buttonKeyClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKeyClear.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeyClear.Location = new System.Drawing.Point(3, 210);
            this.buttonKeyClear.Name = "buttonKeyClear";
            this.buttonKeyClear.Size = new System.Drawing.Size(82, 63);
            this.buttonKeyClear.TabIndex = 9;
            this.buttonKeyClear.TabStop = false;
            this.buttonKeyClear.Text = "C";
            this.buttonKeyClear.UseVisualStyleBackColor = true;
            this.buttonKeyClear.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKey0
            // 
            this.buttonKey0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKey0.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKey0.Location = new System.Drawing.Point(91, 210);
            this.buttonKey0.Name = "buttonKey0";
            this.buttonKey0.Size = new System.Drawing.Size(82, 63);
            this.buttonKey0.TabIndex = 10;
            this.buttonKey0.TabStop = false;
            this.buttonKey0.Text = "0";
            this.buttonKey0.UseVisualStyleBackColor = true;
            this.buttonKey0.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // buttonKeyDecimal
            // 
            this.buttonKeyDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKeyDecimal.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeyDecimal.Location = new System.Drawing.Point(179, 210);
            this.buttonKeyDecimal.Name = "buttonKeyDecimal";
            this.buttonKeyDecimal.Size = new System.Drawing.Size(83, 63);
            this.buttonKeyDecimal.TabIndex = 11;
            this.buttonKeyDecimal.TabStop = false;
            this.buttonKeyDecimal.Text = ".";
            this.buttonKeyDecimal.UseVisualStyleBackColor = true;
            this.buttonKeyDecimal.Click += new System.EventHandler(this.buttonKey0_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDisplay.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.Location = new System.Drawing.Point(0, 0);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(265, 54);
            this.labelDisplay.TabIndex = 4;
            this.labelDisplay.Text = "<0.00>";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KeyPadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 331);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.tableLayoutPanelKeyPad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KeyPadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keypad Demo";
            this.Load += new System.EventHandler(this.Keypad_Load);
            this.tableLayoutPanelKeyPad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKeyPad;
        private System.Windows.Forms.Button buttonKey7;
        private System.Windows.Forms.Button buttonKey8;
        private System.Windows.Forms.Button buttonKey9;
        private System.Windows.Forms.Button buttonKey4;
        private System.Windows.Forms.Button buttonKey5;
        private System.Windows.Forms.Button buttonKey6;
        private System.Windows.Forms.Button buttonKey1;
        private System.Windows.Forms.Button buttonKey2;
        private System.Windows.Forms.Button buttonKey3;
        private System.Windows.Forms.Button buttonKeyClear;
        private System.Windows.Forms.Button buttonKey0;
        private System.Windows.Forms.Button buttonKeyDecimal;
        private System.Windows.Forms.Label labelDisplay;
    }
}

