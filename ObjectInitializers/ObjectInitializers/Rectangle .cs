using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point botomRight = new Point();
        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return botomRight; }
            set { botomRight = value; }
        }
        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft:{0},{1} BottomRight: {2}, {3}]", topLeft.X, topLeft.Y, botomRight.X, botomRight.Y);
        }
    }
}
