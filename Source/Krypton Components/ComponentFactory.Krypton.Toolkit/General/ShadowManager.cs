// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Manages the drawing of Shadows
    /// </summary>
    internal class ShadowManager
    {
        #region Instance Fields
        private KryptonForm kryptonForm;
        private ShadowValues shadowValues;
        private bool allowDrawing;
        private VisualShadowBase[] shadowForms;
        #endregion

        #region Identity
        public ShadowManager(KryptonForm kryptonForm, ShadowValues shadowValues)
        {
            this.kryptonForm = kryptonForm;
            this.shadowValues = shadowValues;
            kryptonForm.Closing += KryptonFormOnClosing;
            kryptonForm.Move += KryptonFormOnMove;
            kryptonForm.Resize += KryptonForm_Resize;
            kryptonForm.SizeChanged += KryptonFormOnSizeChanged;
            kryptonForm.Shown += KryptonFormOnShown;
            kryptonForm.VisibleChanged += KryptonFormOnVisibleChanged;
            InitialiseShadowForms();
            shadowValues.EnableShadowsChanged += ShadowValues_EnableShadowsChanged;
            shadowValues.MarginsChanged += ShadowValues_MarginsChanged;
            shadowValues.BlurDistanceChanged += ShadowValues_BlurDistanceChanged;
            shadowValues.ColourChanged += ShadowValues_ColourChanged;
            shadowValues.HideOnNonActiveFormChanged += ShadowValues_HideOnNonActiveForm;
        }
        #endregion

        private void InitialiseShadowForms()
        {
            shadowForms = new VisualShadowBase[4];
            for (int i = 0; i < 4; i++)
            {
                shadowForms[i] = new VisualShadowBase();
            }
        }

        private bool AllowDrawing
        {
            get => allowDrawing
                   && shadowValues.EnableShadows
                   && (!shadowValues.HideOnNonActiveForm || kryptonForm.WindowActive)
                   && kryptonForm.Visible;
        }

        private void KryptonFormOnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            allowDrawing = false;
            kryptonForm.Closing -= KryptonFormOnClosing;
            kryptonForm.Move -= KryptonFormOnMove;
            kryptonForm.Resize -= KryptonForm_Resize;
            kryptonForm.SizeChanged -= KryptonFormOnSizeChanged;
            kryptonForm.Shown -= KryptonFormOnShown;
            kryptonForm.VisibleChanged -= KryptonFormOnVisibleChanged;
        }

        private void KryptonFormOnVisibleChanged(object sender, EventArgs e)
        {
            foreach (Form shadowForm in shadowForms)
            {
                shadowForm.Visible = AllowDrawing;
            }

            if (AllowDrawing)
            {
                PositionShadowForms();
            }
        }

        private void KryptonFormOnShown(object sender, EventArgs e)
        {
            allowDrawing = true;
            SetShadowFormsSizes();
        }

        private void KryptonFormOnSizeChanged(object sender, EventArgs e)
        {
            SetShadowFormsSizes();
        }

        private void KryptonForm_Resize(object sender, EventArgs e)
        {
            SetShadowFormsSizes();
        }

        private void KryptonFormOnMove(object sender, EventArgs e)
        {
            PositionShadowForms();
        }

        private void ShadowValues_HideOnNonActiveForm(object sender, EventArgs e)
        {
            foreach (Form shadowForm in shadowForms)
            {
                shadowForm.Visible = AllowDrawing;
            }

            if (AllowDrawing)
            {
                PositionShadowForms();
            }
        }

        private void ShadowValues_ColourChanged(object sender, ColorEventArgs e)
        {
            ReCalcBrushes();
        }

        private void ShadowValues_BlurDistanceChanged(object sender, EventArgs e)
        {
            ReCalcBrushes();
        }

        private void ShadowValues_MarginsChanged(object sender, EventArgs e)
        {
            SetShadowFormsSizes();
        }

        private void ShadowValues_EnableShadowsChanged(object sender, EventArgs e)
        {
            foreach (Form shadowForm in shadowForms)
            {
                shadowForm.Visible = AllowDrawing;
            }
        }


        private void SetShadowFormsSizes()
        {
            if (!AllowDrawing) return;

            ReCalcBrushes();
            PositionShadowForms();
        }

        private void ReCalcBrushes()
        {
            
        }

        private void PositionShadowForms()
        {
            if (!AllowDrawing) return;
        }
    }
}
