using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TestApp
{
    public partial class SmallForm : KryptonForm
    {
        public SmallForm()
        {
            InitializeComponent();
        }

        private int _side = 0;
        private bool _reversed;

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            Point offset = ShadowValues.Offset;
            switch (_side)
            {
                case 0:
                    if (offset.X >= 10) _reversed = true;
                    if (_reversed)
                    {
                        offset.X -= 1;
                    }
                    else
                    {
                        offset.X += 1;
                    }

                    if (offset.X <= -10)
                    {
                        _reversed = false;
                        _side = 1;
                    }
                    break;
                case 1:
                    if (offset.Y >= 10) _reversed = true;
                    if (_reversed)
                    {
                        offset.Y -= 1;
                    }
                    else
                    {
                        offset.Y += 1;
                    }

                    if (offset.Y <= -10)
                    {
                        _reversed = false;
                        _side = 0;
                    }

                    break;
            }

            ShadowValues.Offset = offset;
        }
    }
}
