using System;
using System.Collections.Generic;
using System.Text;

namespace Assg1Rectangle
{
    class Rectangle
    {
        //Private variables that store the Length and Width of a Rectangle.
        private int length;
        private int width;

        //Default Constructor.
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        
        //Custom Constructor.
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        // Returns Length of rectangle.
        public int GetLength()
        {
            return length;
        }

        //Sets the length of rectangle and returns the new length of rectangle.
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        //Returns the width of rectangle.
        public int GetWidth()
        {
            return width;
        }

        //Sets the width of rectangle and returns the new width of rectangle.
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        //Returns the Perimeter of rectangle.
        public int GetPerimeter()
        {
            return 2*(width + length);
        }

        //Returns the Area of rectangle.
        public int GetArea()
        {
            return (width * length);
        }
    }
}
