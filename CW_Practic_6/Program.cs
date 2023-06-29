using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Practic_6
{

    public class Point
    {
        private int _x; //приватное поле
        //private int _y;//приватное поле

        public int Y { get; set; }
        //свойство
        public int X
        {
            get { return _x; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Ты слишком молод!");
                }
                else
                {
                    _x = value;
                }

            }
        }

        public Point()
        {
            X = 18;
            Y = 0;
        }

        public Point(int x, int y)
        {
            this._x = x;
            Y = y;
        }



        public void printPoint()
        {
            Console.WriteLine($"X: {X}. Y: {Y}");
        }

        public static Point operator +(Point a, int val)
        {
            return new Point(a.X + val, a.Y + val);
        }

        public static int operator +(int val, Point a)
        {
            return val + a.X + a.Y;
        }
        public static bool operator >(Point a, Point b)
        {
            return ((a.X + a.Y) > (b.X + b.Y) ? true : false);
        }

        public static bool operator <(Point a, Point b)
        {
            return ((a.X + a.Y) < (b.X + b.Y) ? true : false);
        }

        public static bool operator ==(Point a, Point b)
        {
            return (a.X == b.X ? (a.Y == b.Y ? true : false) : false);
        }
        public static bool operator !=(Point a, Point b)
        {
            return (a.X != b.X ? true : (a.Y != b.Y ? true : false));
        }
        public override string ToString()
        {
            return $"Point. X: {X}, Y: {Y}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(10, 10);
            Point b = new Point(10, 10);
            Console.WriteLine($"10 + point a = {10 + a}");
            Console.WriteLine($"Is == ? {a == b}");
            Console.WriteLine($"Is != ? {a != b}");
        }
    }
}
