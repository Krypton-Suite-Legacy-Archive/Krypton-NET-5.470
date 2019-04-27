// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace TestMessageBoxClipping
{
    public partial class Form1 : KryptonForm
    {
        private const string SEED_TEXT =
            @"// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************
";
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonOffice2013_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2013.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2013;
            }
        }

        private void kryptonOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2010Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            }
        }

        private void kryptonOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2010Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            }
        }

        private void kryptonOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2007Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
        }

        private void kryptonOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2007Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            }
        }

        private void kryptonOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2007Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            }
        }

        private void kryptonSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSparkleBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
        }

        private void kryptonSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSparkleOrange.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            }
        }

        private void kryptonSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSparklePurple.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            }
        }

        private void kryptonOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2003.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
            }
        }

        private void kryptonSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            }
        }

        private void kryptonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCustom.Checked)
            {
                kryptonManager.GlobalPalette = kryptonPaletteCustom;
            }
        }

        private void kryptonOffice2013White_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2013White.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2013White;
            }
        }

        private void btnSingleLines_Click(object sender, EventArgs e)
        {
            string localText = SEED_TEXT.Replace(Environment.NewLine, "");
            MessageBox.Show(this, localText + localText, localText);
            KryptonMessageBox.Show(this, localText + localText, localText);
        }

        private void btnCarriageReturns_Click(object sender, EventArgs e)
        {
            string localText = SEED_TEXT;
            MessageBox.Show(this, localText + localText, localText);
            KryptonMessageBox.Show(this, localText + localText, localText);
        }

        private void btnStackTrace_Click(object sender, EventArgs e)
        {
            try
            {
                void InfiniteLoopIt(int howDeep)
                {
                    if (howDeep > 50)
                    {
                        throw new InsufficientExecutionStackException();
                    }

                    InfiniteLoopIt(++howDeep);
                }

                InfiniteLoopIt(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, ex.Message);
                KryptonMessageBox.Show(this, ex.StackTrace, ex.Message);
                KryptonTaskDialog.Show(ex.Message, "MinInstruction", ex.StackTrace, MessageBoxIcon.Stop,
                    TaskDialogButtons.Close);
            }
        }

        private void btnLongTitle_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "ex.StackTrace", ex.Message);
                KryptonMessageBox.Show(this, "ex.StackTrace", ex.Message);
            }
        }

        private void btnLongContents_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                KryptonMessageBox.Show(this, ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLongTitleNoOwner_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.StackTrace", ex.Message);
                KryptonMessageBox.Show("ex.StackTrace", ex.Message);
            }
        }

        private void btnLongContentsNoOwner_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                KryptonMessageBox.Show(ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
