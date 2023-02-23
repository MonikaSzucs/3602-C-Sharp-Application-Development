namespace MenuExample
{
    partial class PictureViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureViewerForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileTopMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTopMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontallyMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flipHorizontallyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFileOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFlipHorizontal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFlipVertical = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelImageState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateDisplay = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTopMainMenuItem,
            this.imageTopMainMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(638, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileTopMainMenuItem
            // 
            this.fileTopMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMainMenuItem,
            this.closeMainMenuItem,
            this.toolStripSeparator1,
            this.exitMainMenuItem});
            this.fileTopMainMenuItem.Name = "fileTopMainMenuItem";
            this.fileTopMainMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileTopMainMenuItem.Text = "&File";
            // 
            // openMainMenuItem
            // 
            this.openMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openMainMenuItem.Image")));
            this.openMainMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openMainMenuItem.Name = "openMainMenuItem";
            this.openMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMainMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openMainMenuItem.Text = "&Open";
            this.openMainMenuItem.Click += new System.EventHandler(this.openMainMenuItem_Click);
            // 
            // closeMainMenuItem
            // 
            this.closeMainMenuItem.Name = "closeMainMenuItem";
            this.closeMainMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeMainMenuItem.Text = "&Close";
            this.closeMainMenuItem.Click += new System.EventHandler(this.closeMainMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitMainMenuItem
            // 
            this.exitMainMenuItem.Name = "exitMainMenuItem";
            this.exitMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitMainMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitMainMenuItem.Text = "&Exit";
            this.exitMainMenuItem.Click += new System.EventHandler(this.exitMainMenuItem_Click);
            // 
            // imageTopMainMenuItem
            // 
            this.imageTopMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontallyMainMenuItem,
            this.flipVerticallyMainMenuItem});
            this.imageTopMainMenuItem.Name = "imageTopMainMenuItem";
            this.imageTopMainMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageTopMainMenuItem.Text = "&Image";
            // 
            // flipHorizontallyMainMenuItem
            // 
            this.flipHorizontallyMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontallyMainMenuItem.Image")));
            this.flipHorizontallyMainMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipHorizontallyMainMenuItem.Name = "flipHorizontallyMainMenuItem";
            this.flipHorizontallyMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.flipHorizontallyMainMenuItem.Size = new System.Drawing.Size(203, 22);
            this.flipHorizontallyMainMenuItem.Text = "Flip &Horizontally";
            this.flipHorizontallyMainMenuItem.Click += new System.EventHandler(this.flipHorizontallyMainMenuItem_Click);
            // 
            // flipVerticallyMainMenuItem
            // 
            this.flipVerticallyMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticallyMainMenuItem.Image")));
            this.flipVerticallyMainMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipVerticallyMainMenuItem.Name = "flipVerticallyMainMenuItem";
            this.flipVerticallyMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.flipVerticallyMainMenuItem.Size = new System.Drawing.Size(203, 22);
            this.flipVerticallyMainMenuItem.Text = "Flip &Vertically";
            this.flipVerticallyMainMenuItem.Click += new System.EventHandler(this.flipVerticallyMainMenuItem_Click);
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.ContextMenuStrip = this.contextMenuStripImage;
            this.pictureBoxMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainImage.Location = new System.Drawing.Point(0, 49);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(638, 453);
            this.pictureBoxMainImage.TabIndex = 1;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontallyContextMenuItem,
            this.flipVerticallyContextMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(204, 48);
            // 
            // flipHorizontallyContextMenuItem
            // 
            this.flipHorizontallyContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontallyContextMenuItem.Image")));
            this.flipHorizontallyContextMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipHorizontallyContextMenuItem.Name = "flipHorizontallyContextMenuItem";
            this.flipHorizontallyContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.flipHorizontallyContextMenuItem.Size = new System.Drawing.Size(203, 22);
            this.flipHorizontallyContextMenuItem.Text = "Flip &Horizontally";
            this.flipHorizontallyContextMenuItem.Click += new System.EventHandler(this.flipHorizontallyMainMenuItem_Click);
            // 
            // flipVerticallyContextMenuItem
            // 
            this.flipVerticallyContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticallyContextMenuItem.Image")));
            this.flipVerticallyContextMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipVerticallyContextMenuItem.Name = "flipVerticallyContextMenuItem";
            this.flipVerticallyContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.flipVerticallyContextMenuItem.Size = new System.Drawing.Size(203, 22);
            this.flipVerticallyContextMenuItem.Text = "Flip &Vertically";
            this.flipVerticallyContextMenuItem.Click += new System.EventHandler(this.flipVerticallyMainMenuItem_Click);
            // 
            // toolStripTop
            // 
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFileOpen,
            this.toolStripButtonFlipHorizontal,
            this.toolStripButtonFlipVertical});
            this.toolStripTop.Location = new System.Drawing.Point(0, 24);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(638, 25);
            this.toolStripTop.TabIndex = 2;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripButtonFileOpen
            // 
            this.toolStripButtonFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileOpen.Image")));
            this.toolStripButtonFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileOpen.Name = "toolStripButtonFileOpen";
            this.toolStripButtonFileOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFileOpen.Text = "Open File";
            this.toolStripButtonFileOpen.Click += new System.EventHandler(this.openMainMenuItem_Click);
            // 
            // toolStripButtonFlipHorizontal
            // 
            this.toolStripButtonFlipHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFlipHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFlipHorizontal.Image")));
            this.toolStripButtonFlipHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFlipHorizontal.Name = "toolStripButtonFlipHorizontal";
            this.toolStripButtonFlipHorizontal.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFlipHorizontal.Text = "Flip Horizontal";
            this.toolStripButtonFlipHorizontal.ToolTipText = "Flip Horizontal";
            this.toolStripButtonFlipHorizontal.Click += new System.EventHandler(this.flipHorizontallyMainMenuItem_Click);
            // 
            // toolStripButtonFlipVertical
            // 
            this.toolStripButtonFlipVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFlipVertical.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFlipVertical.Image")));
            this.toolStripButtonFlipVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFlipVertical.Name = "toolStripButtonFlipVertical";
            this.toolStripButtonFlipVertical.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFlipVertical.Text = "Flip Vertical";
            this.toolStripButtonFlipVertical.Click += new System.EventHandler(this.flipVerticallyMainMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelImageState,
            this.toolStripStatusLabelDateDisplay});
            this.statusStripMain.Location = new System.Drawing.Point(0, 502);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(638, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelImageState
            // 
            this.toolStripStatusLabelImageState.AutoSize = false;
            this.toolStripStatusLabelImageState.Name = "toolStripStatusLabelImageState";
            this.toolStripStatusLabelImageState.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabelImageState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelDateDisplay
            // 
            this.toolStripStatusLabelDateDisplay.Name = "toolStripStatusLabelDateDisplay";
            this.toolStripStatusLabelDateDisplay.Size = new System.Drawing.Size(323, 17);
            this.toolStripStatusLabelDateDisplay.Spring = true;
            this.toolStripStatusLabelDateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDateDisplay
            // 
            this.timerDateDisplay.Enabled = true;
            this.timerDateDisplay.Interval = 1000;
            this.timerDateDisplay.Tick += new System.EventHandler(this.timerDateDisplay_Tick);
            // 
            // PictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 524);
            this.Controls.Add(this.pictureBoxMainImage);
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "PictureViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.PictureViewerForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileTopMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTopMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyMainMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxMainImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonFlipHorizontal;
        private System.Windows.Forms.ToolStripButton toolStripButtonFlipVertical;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImageState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateDisplay;
        private System.Windows.Forms.Timer timerDateDisplay;
    }
}

