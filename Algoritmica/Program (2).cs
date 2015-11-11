using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(10, 30);
            Point p1 = new Point(10, 45);
            Point p2 = new Point(10, 60);
            Point p3 = new Point(10, 85);
            Point p4 = new Point(10, 100);
            Point p5 = new Point(30, 100);
            Point p6 = new Point(50, 100);
            Point p7 = new Point(50, 70);
            Point p8 = new Point(50, 50);
            Point p9 = new Point(0, 50);

            Line l01 = new Line(p, p1);
            Line l12 = new Line(p1, p2);
            Line l23 = new Line(p2, p3);
            Line l34 = new Line(p3, p4);
            Line l45 = new Line(p4, p5);
            Line l56 = new Line(p5, p6);
            Line l67 = new Line(p6, p7);
            Line l78 = new Line(p7, p8);
            Line l89 = new Line(p8, p9);

            List<Line> output = new List<Line>();
            output.Add(l01);
            output.Add(l12);
            output.Add(l23);
            output.Add(l34);
            output.Add(l45);
            output.Add(l56);
            output.Add(l67);
            output.Add(l78);
            output.Add(l89);

            int count = 0;
            foreach (var Line in output)
            {
                
                Line.ToPrint();
                count++;
            }

            l01.ToPrint();
            Console.WriteLine(count);
            //private void FindIntersection(
            //       Point p1, Point p2, Point p3, Point p4,
            //       out bool lines_intersect, out bool segments_intersect,
            //       out Point intersection,
            //       out Point close_p1, out Point close_p2)
          
            Point pct1;          
            Line intersect = new Line();
            intersect.FindIntersection(p, p1, p2, p3, out  pct1);         
            Console.WriteLine(pct1.x + ""+pct1.y);
         
 
            Point pct4;          
            Console.WriteLine("A new point");
            Line intersect1 = new Line();
            intersect.FindIntersection(p4, p5, p6, p7,out  pct4);          
            Console.WriteLine("x:"+pct4.x + "y:  " + pct4.y);
         
            Console.ReadKey();
        }
    }
    public class Point
    {
        internal float x, y;
        public Point()
        {
            x = y = 0;
        }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public  class Line
    {
        internal Point a, b;
        private Point p;
        private Point p1;
        private Point p2;
        private Point p3;
        private bool intSec1;
        private bool intSec2;
        private Point pct1;
        private Point pct2;
        private Point pct3;
        public Line()
        {

        }
        public Line(Point p, Point p1)
        {
            a = p;
            b = p1;
        }

        public Line(Point p, Point p1, Point p2, Point p3, out bool intSec1, out bool intSec2, out Point pct1, out Point pct2, out Point pct3)
        {
            intSec1 = false;
            intSec2 = false;
            pct1 = new Point();
            pct2 = new Point();
            pct3 = new Point();
            // TODO: Complete member initialization
            this.p = p;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.intSec1 = intSec1;
            this.intSec2 = intSec2;
            this.pct1 = pct1;
            this.pct2 = pct2;
            this.pct3 = pct3;
        }

        internal void ToPrint()
        {
            Console.WriteLine("Line Begin From(x,y):({0},{1})", a.x, a.y);
            Console.WriteLine("Line End In (x,y):({0},{1})", b.x, b.y);
        }

        public void FindIntersection(
                   Point p1, Point p2, Point p3, Point p4,
                   out Point intersection)
        {
            // Get the segments' parameters.
            float dx12 = p2.x - p1.x;
            float dy12 = p2.y - p1.y;
            float dx34 = p4.x - p3.x;
            float dy34 = p4.y - p3.y;

            // Solve for t1 and t2
            float denominator = (dy12 * dx34 - dx12 * dy34);

            float t1 =
                ((p1.x - p3.x) * dy34 + (p3.y - p1.y) * dx34)
                    / denominator;
            if (float.IsInfinity(t1))
            {
                intersection = new Point(float.NaN, float.NaN);
                return;
            }


            float t2 =
                ((p3.x - p1.x) * dy12 + (p1.y - p3.y) * dx12)
                    / -denominator;

            // Find the point of intersection.
            intersection = new Point(p1.x + dx12 * t1, p1.y + dy12 * t1);
        }
    }
}