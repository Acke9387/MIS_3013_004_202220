using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_RectangleAndCircle
{
    public class Rectangle
    {

        //private double Length;

        //public void SetLength(double l)
        //{
        //    Length = l;
        //}

        //public double GetLength()
        //{
        //    return Length;
        //}

        public double Length { get; set; }
        public double Width { get; set; }

        public string IWillDeleteThisLaterBecauseItIsNotUsed { get; set; }

        /// <summary>
        /// Default/Empty constructor
        /// </summary>
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            IWillDeleteThisLaterBecauseItIsNotUsed = string.Empty;
        }

        /// <summary>
        /// Overloaded Constructor taking the Width and Length
        /// </summary>
        /// <param name="width">The Width of the Rectangle</param>
        /// <param name="Length">The Length of the Rectangle</param>
        public Rectangle(double width, double Length) : this()
        {
            Width = width;
            this.Length = Length;
        }

        /// <summary>
        /// Calculate the area of this Rectangle by multiplying the Length and Width
        /// </summary>
        /// <returns>The Area of the Rectangle</returns>
        public double CalculateArea()
        {
            double area = Length * Width;

            return area;

        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public override string ToString()
        {
            return $"Width:{Width} \tLength:{Length}\tArea:{CalculateArea()}\tPerimeter:{CalculatePerimeter()}";
        }
    }
}
