// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012 - 2019. All rights reserved.
//  The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace ButtonSpecPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButtonAdd_Click(object sender, EventArgs e)
        {
            // Create a new button spec entry
            ButtonSpecHeaderGroup spec = new ButtonSpecHeaderGroup();
            spec.Type = PaletteButtonSpecStyle.Close;

            // Need to know when button is selected
            spec.Click += new EventHandler(OnButtonSelected);

            // Add to end of the collection of button specs
            kryptonHeaderGroup1.ButtonSpecs.Add(spec);

            // Make it the selected button spec
            propertyGrid.SelectedObject = spec;

            UpdateActionButtons();
        }

        private void kryptonButtonRemove_Click(object sender, EventArgs e)
        {
            // Get access to the selected button spec
            ButtonSpecHeaderGroup spec = (ButtonSpecHeaderGroup)propertyGrid.SelectedObject;

            // Remove just the selected button spec
            kryptonHeaderGroup1.ButtonSpecs.Remove(spec);

            // Nothing selected in the property grid
            propertyGrid.SelectedObject = null;

            UpdateActionButtons();
        }

        private void kryptonButtonClear_Click(object sender, EventArgs e)
        {
            // Remove all the button specifications
            kryptonHeaderGroup1.ButtonSpecs.Clear();

            // Nothing selected in the property grid
            propertyGrid.SelectedObject = null;

            UpdateActionButtons();
        }

        private void kryptonButtonTopP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Top;
        }

        private void kryptonButtonLeftP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Left;
        }

        private void kryptonButtonRightP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Right;
        }

        private void kryptonButtonBottomP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Bottom;
        }

        private void kryptonButtonTopS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Top;
        }

        private void kryptonButtonLeftS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Left;
        }

        private void kryptonButtonRightS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Right;
        }

        private void kryptonButtonBottomS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Bottom;
        }

        private void OnButtonSelected(object sender, EventArgs e)
        {
            // Cast to correct type
            ButtonSpecHeaderGroup spec = (ButtonSpecHeaderGroup)sender;

            // Make it the selected button spec
            propertyGrid.SelectedObject = spec;

            UpdateActionButtons();
        }

        private void UpdateActionButtons()
        {
            kryptonButtonRemove.Enabled = (propertyGrid.SelectedObject != null);
            kryptonButtonClear.Enabled = (kryptonHeaderGroup1.ButtonSpecs.Count > 0);
        }

        private void kryptonCheckSet1_CheckedButtonChanged(object sender, EventArgs e)
        {
            switch (kryptonCheckSet1.CheckedButton.Name)
            {
                case @"checkOffice365Black":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office365Black;
                    break;
                case @"check2010Blue":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case @"checkSparkle":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case @"checkSystem":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case @"checkOffice2010Black":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case @"checkOffice2010White":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010White;
                    break;
                case @"checkOffice365White":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office365White;
                    break;
                case @"checkOffice2007Black":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (btnInvert.Checked)
            {
                foreach (ButtonSpecHeaderGroup buttonSpec in kryptonHeaderGroup1.ButtonSpecs)
                {
                    Image buttonSpecImage = buttonSpec.GetImage( kryptonManager1.GlobalPalette, buttonSpec.GetView().State);
                    Bitmap invertingImage = InvertingImage(buttonSpecImage);
                    // invertingImage.MakeTransparent(); // Note: Decide where would be a good transparent colour
                    buttonSpec.Image = invertingImage;
                }
            }
            else
            {
                foreach (ButtonSpecHeaderGroup buttonSpec in kryptonHeaderGroup1.ButtonSpecs)
                {
                    // This is not perfect as it will forcibly remove any user original defined image
                    buttonSpec.ResetImage();
                }
            }
        }

        // Stolen from here
        // https://mariusbancila.ro/blog/2009/11/13/using-colormatrix-for-creating-negative-image/
        private Bitmap InvertingImage(Image source)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(source.Width, source.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            // create the negative color matrix
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 0, 1}
            });

            // create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height),
                0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();

            return newBitmap;
        }
    }
}
