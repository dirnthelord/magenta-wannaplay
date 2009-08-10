using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace System.Drawing
{
    public static class IconExt
    {
        public static Bitmap As16x16Bitmap(this Icon icon)
        {
            return new Icon(icon, 16, 16).ToBitmap();
        }

        public static Bitmap As32x32Bitmap(this Icon icon)
        {
            return new Icon(icon, 32, 32).ToBitmap();
        }
    }
}
