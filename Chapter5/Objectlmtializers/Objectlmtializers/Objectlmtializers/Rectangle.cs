using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectlmtializers
{
    class Rectangle
    {
        public Point TopLeft { get; set; } = new Point();
        public Point BottomRight { get; set; } = new Point();

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}",
                TopLeft.X, TopLeft.Y, TopLeft.Color,
                BottomRight.X, BottomRight.Y, BottomRight.Color);
        }
    }
}
