using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Graph
    {
        private string graphType;
        public Graph(string s)
        {
            type = s;
        }
        public string type
        {
            get
            {
                return graphType;
            }
            set
            {
                graphType = value;
            }
        }
        public abstract double Area
        {
            get;
        }
    }
    public class Circle : Graph
    {
        private double myRadius = 0;
        public Circle(double radius, string type) : base(type)
        {
            myRadius = radius;
        }
        public override double Area
        {
            get
            {
                return myRadius * myRadius * Math.PI;
            }
        }


    }
    public class Square : Graph
    {
        private double myWidth;
        private double myHeight;
        public Square(double width, double height, string type) : base(type)
        {
            myWidth = width;
            myHeight = height;

        }
        public override double Area
        {
            get
            {
                return myWidth * myHeight;
            }
        }


    }

    public class Triangle : Graph
    {
        private double MySide1;
        private double MySide2;
        private double MySide3;
        public Triangle(double side1, double side2, double side3, string type) : base(type)
        {
            MySide1 = side1;
            MySide2 = side2;
            MySide3 = side3;
        }
        public override double Area
        {
            get
            {
                double temp1 = (MySide1 + MySide2 + MySide3) / 2;
                double temp2 = temp1 * (temp1 - MySide1) * (temp1 - MySide2) * (temp1 - MySide3);
                return Math.Sqrt(temp2);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph square = new Square(3.05, 9.06, "Square");
            Console.WriteLine(square.type + " Area " + square.Area);
            Graph tirangle = new Triangle(3.05, 9.06, 8.0, "Triangle");
            Console.WriteLine(tirangle.type + " Area " + tirangle.Area);
            Graph circle = new Circle(3.0, "Circle");
            Console.WriteLine(circle.type + " Area " + circle.Area);

        }
    }
}
