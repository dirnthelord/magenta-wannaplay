using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Magenta.WannaPlay.UI.WinForms.Properties
{
    /// <summary>
    /// Represents the component that hosts images that can be accessed by index
    /// </summary>
    public static class ImageListHost
    {
        #region Known image keys

        public static class KnownKeys
        {
            public const string Tennis = "Tennis";
            public const string Squash = "Squash";
        }

        #endregion

        #region Constructors

        static ImageListHost()
        {
            Default = new ImageList();

            Default.ImageSize = new Size(16, 16);
            Default.ColorDepth = ColorDepth.Depth32Bit;

            Default.Images.Add(KnownKeys.Tennis, Resources.Tennis.As16x16Bitmap());
            Default.Images.Add(KnownKeys.Squash, Resources.Squash.As16x16Bitmap());
        } 

        #endregion

        #region Properties
        
        public static ImageList Default { get; private set; }

        #endregion
    }
}