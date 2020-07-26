using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = Math.Abs(value); }
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = Math.Abs(value); }
        }

        public Rectangle(double a)
        {
            this.SideA = a;
            this.SideB = 5;
        }

        public Rectangle(double a, double b)
        {
            this.SideA = a;
            this.SideB = b;
        }

        public Rectangle()
        {
            this.SideA = 4;
            this.SideB = -3;
        }

        public double GetSideA()
        {
            return sideA;
        }


        public double GetSideB()
        {
            return sideB;
        }


        public double Area()
        {
            return sideA * sideB;
        }

        public bool IsSquare()
        {
            if (sideA == sideB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Perimeter()
        {
            return 2 * sideA + 2 * sideB;
        }

        public void ReplaceSides()
        {
            double buffer = sideA;
            sideA = sideB;
            sideB = buffer;
        }


    }
    
    public class ArrayRectangles
    {
        private Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(IEnumerable<Rectangle> rectangles)
        {
            this.rectangle_array = Enumerable.ToArray(rectangles);
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            int i = 0;

            while (i < rectangle_array.Length)
            {

                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }

        public int NumberMaxArea()
        {
            int largest = 0;

            for (int i = 0; i < rectangle_array.Length; i++)
            {

                if (rectangle_array[i].Area() >= rectangle_array[largest].Area())
                {
                    largest = i;
                }
            }

            return largest;
        }

        public int NumberMinPerimeter()
        {
            int smallest = 0;

            for (int i = 0; i < rectangle_array.Length; i++)
            {

                if (rectangle_array[i].Perimeter() <= rectangle_array[smallest].Perimeter())
                {
                    smallest = i;
                }
            }

            return smallest;
        }

        public int NumberSquare()
        {
            int squares = 0;

            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].IsSquare() == true)
                {
                    squares++;
                }

            }

            return squares;
        }
    }
}
