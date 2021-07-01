using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class Size
    {
        public Size(int x,int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
    }

    public class Area
    {
        public Area(Size topLeft, Size bottomRight)
        {
            TopLeftCorner=topLeft;
            BottomRightCorner = bottomRight;
        }
        public Size TopLeftCorner { get; private set; }
        public Size BottomRightCorner { get; private set; }
    }
}
