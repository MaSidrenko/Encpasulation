using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

	internal class Program
	{
		static string delimeter = "\n|--------------------------------------|\n";
		static double Distance(Point A, Point B)
		{
			double x_dis = A.X - B.X;
			double y_dis = A.Y - B.Y;
			double distance = Math.Sqrt(Math.Pow(x_dis, 2) + Math.Pow(y_dis, 2));
			return distance;
		}
		static void Main(string[] args)
		{
			Point A = new Point();
			Point B = new Point();
			//Console.WriteLine("X = " + A.GetX() + "\tY = " + A.GetY());
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();
			A.X = 1;
			A.Y = 1;

			B.X = 2;
			B.Y = 4;
			A.Print();
            Console.WriteLine();
			B.Print();
            Console.WriteLine(delimeter);
			Console.WriteLine("Расстояние от точки 'B' до точки 'A': " + B.Distance(A));
            Console.WriteLine(delimeter);
            Console.WriteLine("Расстояние между точками 'A' и 'B': " + Distance(A, B));
		}
	}
}
