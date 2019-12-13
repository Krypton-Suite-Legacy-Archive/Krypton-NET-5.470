using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteDesigner.Components
{
    [ToolboxBitmap(typeof(PropertyGrid))]
    public class KryptonPropertyGrid : PropertyGrid
    {
        #region Variables
        private Color _gradientMiddleColour = Color.Gray;

        private IPalette _palette;

        private PaletteRedirect _paletteRedirect;
        #endregion

        #region Properties
        [Browsable(true), Category("Appearance-Extended"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DefaultValue("Color.Gray")]
        public Color GradientMiddleColour
        {
            get => _gradientMiddleColour;
            set { _gradientMiddleColour = value; Invalidate(); }
        }
        #endregion

        #region Constructor
        public KryptonPropertyGrid()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColours();
        }
        #endregion

        #region Methods
        private void InitColours()
        {
            ToolStripRenderer = ToolStripManager.Renderer;

            GradientMiddleColour = _palette.ColorTable.ToolStripGradientMiddle;

            HelpBackColor = _palette.ColorTable.MenuStripGradientBegin;

            HelpForeColor = _palette.ColorTable.StatusStripText;

            LineColor = _palette.ColorTable.ToolStripGradientMiddle;

            CategoryForeColor = _palette.ColorTable.StatusStripText;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.FillRectangle(new SolidBrush(GradientMiddleColour), pevent.ClipRectangle);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }
        #endregion

        #region Krypton
        //Kripton Palette Events
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values

                InitColours();

            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }
        #endregion
    }
}