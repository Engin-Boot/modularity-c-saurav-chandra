using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorList
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor;
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        public static Color[] ColorMapMajor
        {
            set
            {
                colorMapMajor = value;
            }
            get
            {
                return colorMapMajor;
            }
        }
        public static Color[] ColorMapMinor
        {
            set
            {
                colorMapMinor = value;
            }
            get
            {
                return colorMapMinor;
            }
        }

        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorList()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
