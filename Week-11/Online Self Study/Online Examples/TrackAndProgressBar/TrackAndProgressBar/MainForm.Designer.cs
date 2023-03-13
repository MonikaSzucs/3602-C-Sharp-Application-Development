namespace TrackAndProgressBar
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
            this.trackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.trackBarVertical = new System.Windows.Forms.TrackBar();
            this.progressBarHorizontal = new System.Windows.Forms.ProgressBar();
            this.progressBarVertical = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarHorizontal
            // 
            this.trackBarHorizontal.Location = new System.Drawing.Point(99, 12);
            this.trackBarHorizontal.Maximum = 50;
            this.trackBarHorizontal.Name = "trackBarHorizontal";
            this.trackBarHorizontal.Size = new System.Drawing.Size(232, 45);
            this.trackBarHorizontal.TabIndex = 0;
            this.trackBarHorizontal.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarHorizontal.Scroll += new System.EventHandler(this.trackBarHorizontal_Scroll);
            // 
            // trackBarVertical
            // 
            this.trackBarVertical.Location = new System.Drawing.Point(12, 12);
            this.trackBarVertical.Name = "trackBarVertical";
            this.trackBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVertical.Size = new System.Drawing.Size(45, 232);
            this.trackBarVertical.TabIndex = 1;
            this.trackBarVertical.Scroll += new System.EventHandler(this.trackBarVertical_Scroll);
            // 
            // progressBarHorizontal
            // 
            this.progressBarHorizontal.Location = new System.Drawing.Point(99, 64);
            this.progressBarHorizontal.Name = "progressBarHorizontal";
            this.progressBarHorizontal.Size = new System.Drawing.Size(232, 23);
            this.progressBarHorizontal.TabIndex = 2;
            // 
            // progressBarVertical
            // 
            this.progressBarVertical.Location = new System.Drawing.Point(99, 220);
            this.progressBarVertical.Name = "progressBarVertical";
            this.progressBarVertical.Size = new System.Drawing.Size(232, 23);
            this.progressBarVertical.TabIndex = 3;
            // 
            // labelProgress
            // 
            this.labelProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(99, 90);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(232, 23);
            this.labelProgress.TabIndex = 4;
            this.labelProgress.Text = "<Progress>";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 269);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarVertical);
            this.Controls.Add(this.progressBarHorizontal);
            this.Controls.Add(this.trackBarVertical);
            this.Controls.Add(this.trackBarHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackBar and ProgressBar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.TrackBar trackBarVertical;
        private System.Windows.Forms.ProgressBar progressBarHorizontal;
        private System.Windows.Forms.ProgressBar progressBarVertical;
        private System.Windows.Forms.Label labelProgress;
    }
}

