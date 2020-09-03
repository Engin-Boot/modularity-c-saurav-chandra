using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorList;
using static TelCo.ColorCoder.ColorPair;
using static TelCo.ColorCoder.NumToColor;
using static TelCo.ColorCoder.ColorToNum;

namespace TelCo.ColorCoder
{
    class Ref
    {
        public override string ToString()
        {
            string colorCodes = "";
            for(int pairNo=1; pairNo<= colorMapMinor.Length*colorMapMajor.Length; pairNo++)
            {
                ColorPair pair = NumToColor.GetColorFromPairNumber(pairNo);
                colorCodes += "Pair Num: " + pairNo + "  Colors: " + pair + "\n";

            }
            return colorCodes;
        }
    }
}
