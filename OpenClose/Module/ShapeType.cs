using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Module
{
    public enum ShapeType
    {
        Circle,
        Rectangle
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Shape
    {
        public ShapeType ShapeType { get; set; }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point TopLeft { get; set; }
    }
}
