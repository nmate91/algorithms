using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingRectangles
{
    class RectangleCoordinates
    {
        public RectangleCoordinates(int x1, int y1, int x2, int y2)
        {
            X1 = x1 <= x2 ? x1 : x2;
            Y1 = y1 <= y2 ? y1 : y2;
            X2 = x1 > x2 ? x1 : x2;
            Y2 = y1 > y2 ? y1 : y2;
        }
        public int X1 { get; private set; }
        public int Y1 { get; private set; }
        public int X2 { get; private set; }
        public int Y2 { get; private set; }
    }

    class RectangleOverlappingCounter
    {
        public int CalculateArea(RectangleCoordinates coordinates)
        {
            return Math.Abs(coordinates.X1 - coordinates.X2) * Math.Abs(coordinates.Y1 - coordinates.Y2);
        }

        public RectangleCoordinates DefineOverlapCoordinates(RectangleCoordinates rc1, RectangleCoordinates rc2)
        {
            if(rc1.X1 > rc2.X1)
            {
                var tempRect = rc1;
                rc1 = rc2;
                rc2 = tempRect;
            }
            bool areRectanglesFading = rc1.X2 > rc2.X1 && rc1.X1 < rc2.X2 && rc1.Y2 > rc2.Y1 && rc1.Y1 < rc2.Y2;
            if (areRectanglesFading)
            {
                int x1 = rc1.X1 > rc2.X1 ? rc1.X1 : rc2.X1;
                int y1 = rc1.Y1 > rc2.Y1 ? rc1.Y1 : rc2.Y1;
                int x2 = rc1.X2 < rc2.X2 ? rc1.X2 : rc2.X2;
                int y2 = rc1.Y2 < rc2.Y2 ? rc1.Y2 : rc2.Y2;
                return new RectangleCoordinates(x1, y1, x2, y2);
            }
            return new RectangleCoordinates(0, 0, 0, 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rc1 = new RectangleCoordinates(3, 3, 6, 6);
            var rc2 = new RectangleCoordinates(3, 3, 5, 5);
            RectangleOverlappingCounter counter = new RectangleOverlappingCounter();
            var result = counter.CalculateArea(counter.DefineOverlapCoordinates(rc1, rc2));
            Console.WriteLine(result);
        }
    }
}
