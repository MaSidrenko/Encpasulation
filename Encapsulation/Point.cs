using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		double x;
		double y;
		public double X //Property
		{
			get
			{
				return x;
			}
			set
			{
				if (value > 200) value = 200;
				x = value;//Ключевое слово "Value" дает принимаемое зачение
			}
		}
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				if (value > 150) value = 150;
				y = value;
			}
		}
		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			if (x > 200) x = 200;
			this.x = x;
		}
		public void SetY(double y)
		{
			if (y > 150) y = 150;
			this.y = y;
		}
		public double Distance(Point other)
		{			
			double distance = Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y,2));
			return distance;
		}
		public static double Distance(Point A, Point B)
		{
			double x_dis = A.X - B.X;
			double y_dis = A.Y - B.Y;
			double distance = Math.Sqrt(Math.Pow(x_dis, 2) + Math.Pow(y_dis, 2));
			return distance;
		}
		//public double X {  get; set; } //Автосвойства
		//public double Y { get; set; }
		public Point(double x = 0, double y = 0)
		{
			this.X = x;
			this.Y = y;
            Console.WriteLine("DefaultConstructor: " + this.GetHashCode());
		}
		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
            Console.WriteLine("CopyConstructor: " +this.GetHashCode());
		}
		~Point()
		{
            Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public static Point operator+(Point left, Point right)
		{
			Point res = new Point();
			res.X = left.X + right.X;
			res.Y = left.Y + right.Y;
			return res;
		}
		public static Point operator-(Point left, Point right)
		{
			return new Point
				(
				left.X - right.X,
				left.Y - right.Y
				);
		}
		public static Point operator++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return obj;
		}
		public static bool operator==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}
		public static bool operator!=(Point left, Point right)
		{
			return !(left == right);
		}
		public void Print()
		{
			Console.WriteLine("X = " + X + "\tY = " + Y);
		}
	}

}
