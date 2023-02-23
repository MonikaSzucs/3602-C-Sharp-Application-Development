using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuExample
{
    public partial class PictureViewerForm : Form
    {
        private Bitmap image;
        private bool flippedH;
        private bool flippedV;
        
        public PictureViewerForm()
        {
            InitializeComponent();
        }

        private void PictureViewerForm_Load(object sender, EventArgs e)
        {
            flippedH = false;
            flippedV = false;

            setImageStatusDisplay();

            pictureBoxMainImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void exitMainMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openMainMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Select Image File";

            if (openFile.ShowDialog() != DialogResult.Cancel 
                && openFile.FileName != string.Empty)
            {
                image = Bitmap.FromFile(openFile.FileName) as Bitmap;
                pictureBoxMainImage.Image = image;

                flippedH = false;
                flippedV = false;
                setImageStatusDisplay();
            }
        }

        private void closeMainMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMainImage.Image = image = null;
            setImageStatusDisplay();
        }

        private void flipHorizontallyMainMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBoxMainImage.Refresh();

                flippedH = !flippedH;
                setImageStatusDisplay();
            }
        }

        private void flipVerticallyMainMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBoxMainImage.Refresh();

                flippedV = !flippedV;
                setImageStatusDisplay();
            }
        }

        private void timerDateDisplay_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateDisplay.Text = $"{DateTime.Now:dddd, MMMM d, yyyy  h:mm:ss tt}";  
        }

        private void setImageStatusDisplay()
        {
            string status = "Image Normal";

            if (flippedH)
            {
                status = "Image Flipped Horizontally";
            }
            
            if (flippedV)
            {
                status = "Image Flipped Vertically";
            }
            
            if (flippedH && flippedV)
            {
                status = "Image Flipped Horizontally and Vertically";
            }

            enableButtons();            
            toolStripStatusLabelImageState.Text = image is null ? string.Empty : status;

        }

        private void enableButtons()
        {
            bool enable = image != null;

            toolStripButtonFlipHorizontal.Enabled = enable;
            toolStripButtonFlipVertical.Enabled = enable;
            flipHorizontallyContextMenuItem.Enabled = enable;
            flipVerticallyContextMenuItem.Enabled = enable;
            flipHorizontallyMainMenuItem.Enabled = enable;
            flipVerticallyMainMenuItem.Enabled = enable;
        }
    }
}
