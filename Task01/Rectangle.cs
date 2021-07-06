using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Rectangle
    {
        double width;
        double height;
        double area;
        double perimeter;

        public Rectangle()
        {
            width = 1;
            height = 1;

            AreaCalculator();
            PerimeterCalculator();
        }

        public Rectangle (double width, double height)
        {
            this.width = width;
            this.height = height;

            AreaCalculator();
            PerimeterCalculator();            
        }

        public double Area
        {
            get { return area; }
        }

        public double Perimeter
        {
            get { return perimeter; }
        }

        public double Width
        {
            get { return width; }
            set 
            { 
                width = value;
                AreaCalculator();
                PerimeterCalculator();
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                AreaCalculator();
                PerimeterCalculator();
            }
        }

        void AreaCalculator()
        {
            area = width * height;
        }

        void PerimeterCalculator()
        {
            perimeter = 2 * (width + height);
        }
    }
}
