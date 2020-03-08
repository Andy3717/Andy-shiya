using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    interface Area
    {
        double Area();
    }
    interface Shape
    {
        bool IfLegal();
    }
    class Rectangle : Area, Shape
    {
        int Height { get; set; }
        int Width { get; set; }
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public bool IfLegal()
        {
            return Height > 0 && Width > 0;
        }
        public double Area()
        {
            if (this.IfLegal())
            {
                return Height * Width;
            }
            else
                Console.WriteLine("该形状不合法");
            return 0;
        }

    }
    class Square : Area, Shape
    {
        int Side { get; set; }
        public Square(int s)
        {
            Side = s;
        }
        public bool IfLegal()
        {
            return Side > 0;
        }
        public double Area()
        {
            if (this.IfLegal())
            {
                return Side * Side;
            }
            else
                Console.WriteLine("该形状不合法");
            return 0;
        }

    }
    class Triangle : Area, Shape
    {
        int Side1 { get; set; }
        int Side2 { get; set; }
        int Side3 { get; set; }
        public Triangle(int s1, int s2, int s3)
        {
            this.Side1 = s1;
            this.Side2 = s2;
            this.Side3 = s3;
        }
        public bool IfLegal()
        {
            return Side1 > 0 && Side2 > 0 && Side3 > 0
                && Side1 + Side2 > Side3
                && Side3 + Side2 > Side1
                && Side1 + Side3 > Side2;
        }
        public double Area()
        {
            if (this.IfLegal())
            {
                double average = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(average * (average - Side1) * (average - Side2) * (average - Side3));
            }
            else
                Console.WriteLine("该形状不合法");
            return 0;
        }

    }
    class ShapeFactory
    {
        public Area CreateShape(int name)
        {
            Area shape = null;
            Random rand = new Random();
            switch (name)
            {
                case 0:
                    shape = new Rectangle(rand.Next(3, 7), rand.Next(3, 7));
                    return shape;
                case 1:
                    shape = new Square(rand.Next(3, 7));
                    return shape;
                case 2:
                    shape =
                        new Triangle(rand.Next(3, 7), rand.Next(3, 7), rand.Next(3, 7));
                    return shape;
                default:
                    Console.WriteLine("这不是合理形状");
                    return null;
            }
        }
    }
    class program
    {
        static double AreaSum = 0;
        static Area[] shapes = new Area[10];
        static void Main(string[] args)
        {
            for (int num = 0; num < 10; num++)
            {
                Random random = new Random();
                ShapeFactory SF = new ShapeFactory();
                Area sh = SF.CreateShape(random.Next(0, 2));
                shapes[num] = sh;
                double i = shapes[num].Area();
                AreaSum = AreaSum + i;
            }
            Console.WriteLine(AreaSum);
            Console.ReadKey();
        }
    }
}