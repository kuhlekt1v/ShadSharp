using System;
using System.Drawing;
using System.Windows.Forms;

namespace CandyCrush
{
    class MyButton : Button
    {
        public static Color [] myColors = { Color.Red, Color.Blue, Color.Yellow, Color.White, Color.DimGray, Color.Black };

        static Random rnd = new Random();

        public static int btnSize = 25;
        public int Row { get; set; }
        public int Col { get; set; }

        public MyButton()
        {
            Width = Height = btnSize;
            int initColor = rnd.Next() % myColors.Length;
            this.BackColor = myColors [initColor];
        }
    }
}
