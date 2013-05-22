using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CalcAreaOfRectangle
{
    public class Rectangle 
    {
        private double baseSide;
        private double heightSide;
        private double area;

        public Rectangle()
        {
        }

        public Rectangle(double baseSide, double heightSide)
        {
            this.baseSide = baseSide;
            this.heightSide = heightSide;
        }

        public double BaseSide 
        {
            get { return this.baseSide; }
            set { this.baseSide = value; }
        }

        public double HeightSide 
        {
            get { return this.heightSide; }
            set { this.heightSide = value; }
        }

        public double Area 
        {
            get { return this.area; }
            set { this.area = value; }
        }

        internal double CalcArea() 
        {
            return this.baseSide * this.heightSide;
        }
    }
    class calcAreaOfRectangle
    {
        static void Main()
        {
            Rectangle screen1 = new Rectangle();
            screen1.BaseSide = 4.5;
            screen1.HeightSide = 4.25;
            screen1.Area = screen1.CalcArea();
            Console.WriteLine(screen1.Area);
        }
    }
}
