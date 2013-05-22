using System;

namespace _02.CalcPerimeterAndAreaOfCircle
{
    class Circle
    {
        #region Fields

        private double radius = 0;
        private double perimeter = 0;
        private double area = 0;

        #endregion

        #region Constructors

        public Circle()
        { }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        #endregion

        #region Methods

        public double CalcArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalcPerimeter(double radius)
        {
            return Math.PI * radius * 2;
        }

        #endregion

        #region Properties

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }

        #endregion

    }
}
