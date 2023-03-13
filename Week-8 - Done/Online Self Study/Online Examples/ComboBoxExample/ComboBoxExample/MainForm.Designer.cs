namespace ComboBoxExample
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
            this.comboBoxDropDownList = new System.Windows.Forms.ComboBox();
            this.labelComboBoxSimple = new System.Windows.Forms.Label();
            this.labelComboBoxDropDown = new System.Windows.Forms.Label();
            this.comboBoxDropDown = new System.Windows.Forms.ComboBox();
            this.comboBoxSimple = new System.Windows.Forms.ComboBox();
            this.labelComboBoxDropDownList = new System.Windows.Forms.Label();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDropDownList
            // 
            this.comboBoxDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropDownList.FormattingEnabled = true;
            this.comboBoxDropDownList.Location = new System.Drawing.Point(348, 39);
            this.comboBoxDropDownList.Name = "comboBoxDropDownList";
            this.comboBoxDropDownList.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDropDownList.TabIndex = 22;
            this.comboBoxDropDownList.SelectedIndexChanged += new System.EventHandler(this.comboBoxSimple_SelectedIndexChanged);
            // 
            // labelComboBoxSimple
            // 
            this.labelComboBoxSimple.AutoSize = true;
            this.labelComboBoxSimple.Location = new System.Drawing.Point(29, 23);
            this.labelComboBoxSimple.Name = "labelComboBoxSimple";
            this.labelComboBoxSimple.Size = new System.Drawing.Size(38, 13);
            this.labelComboBoxSimple.TabIndex = 23;
            this.labelComboBoxSimple.Text = "Simple";
            // 
            // labelComboBoxDropDown
            // 
            this.labelComboBoxDropDown.AutoSize = true;
            this.labelComboBoxDropDown.Location = new System.Drawing.Point(189, 23);
            this.labelComboBoxDropDown.Name = "labelComboBoxDropDown";
            this.labelComboBoxDropDown.Size = new System.Drawing.Size(58, 13);
            this.labelComboBoxDropDown.TabIndex = 24;
            this.labelComboBoxDropDown.Text = "DropDown";
            // 
            // comboBoxDropDown
            // 
            this.comboBoxDropDown.FormattingEnabled = true;
            this.comboBoxDropDown.Location = new System.Drawing.Point(192, 39);
            this.comboBoxDropDown.Name = "comboBoxDropDown";
            this.comboBoxDropDown.Size = new System.Drawing.Size(138, 21);
            this.comboBoxDropDown.TabIndex = 21;
            this.comboBoxDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBoxSimple_SelectedIndexChanged);
            // 
            // comboBoxSimple
            // 
            this.comboBoxSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxSimple.FormattingEnabled = true;
            this.comboBoxSimple.Location = new System.Drawing.Point(32, 39);
            this.comboBoxSimple.Name = "comboBoxSimple";
            this.comboBoxSimple.Size = new System.Drawing.Size(143, 150);
            this.comboBoxSimple.TabIndex = 20;
            this.comboBoxSimple.SelectedIndexChanged += new System.EventHandler(this.comboBoxSimple_SelectedIndexChanged);
            // 
            // labelComboBoxDropDownList
            // 
            this.labelComboBoxDropDownList.AutoSize = true;
            this.labelComboBoxDropDownList.Location = new System.Drawing.Point(345, 23);
            this.labelComboBoxDropDownList.Name = "labelComboBoxDropDownList";
            this.labelComboBoxDropDownList.Size = new System.Drawing.Size(74, 13);
            this.labelComboBoxDropDownList.TabIndex = 25;
            this.labelComboBoxDropDownList.Text = "DropDownList";
            // 
            // labelPersonName
            // 
            this.labelPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonName.Location = new System.Drawing.Point(240, 166);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(258, 23);
            this.labelPersonName.TabIndex = 26;
            this.labelPersonName.Text = "<Person Name>";
            this.labelPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 235);
            this.Controls.Add(this.labelPersonName);
            this.Controls.Add(this.comboBoxDropDownList);
            this.Controls.Add(this.labelComboBoxSimple);
            this.Controls.Add(this.labelComboBoxDropDown);
            this.Controls.Add(this.comboBoxDropDown);
            this.Controls.Add(this.comboBoxSimple);
            this.Controls.Add(this.labelComboBoxDropDownList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDropDownList;
        private System.Windows.Forms.Label labelComboBoxSimple;
        private System.Windows.Forms.Label labelComboBoxDropDown;
        private System.Windows.Forms.ComboBox comboBoxDropDown;
        private System.Windows.Forms.ComboBox comboBoxSimple;
        private System.Windows.Forms.Label labelComboBoxDropDownList;
        private System.Windows.Forms.Label labelPersonName;
    }
}

