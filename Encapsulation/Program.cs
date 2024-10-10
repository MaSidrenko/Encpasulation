//#define DISTANCE 
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
	
		static void Main(string[] args)
		{
#if DISTANCE
			Point A = new Point();
			Point C;
			//Point B = new Point();
			//Console.WriteLine("X = " + A.GetX() + "\tY = " + A.GetY());
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();
			A.X = 1;
			A.Y = 1;
			Point B = new Point(A);
			B.X = 2;
			B.Y = 4;
			A.Print();
			Console.WriteLine();
			B.Print();
			С = new Point(B);
			Console.WriteLine(delimeter);
			Console.WriteLine("Расстояние от точки 'B' до точки 'A': " + B.Distance(A));
			Console.WriteLine(delimeter);
			//Console.WriteLine("Расстояние между точками 'A' и 'B': " + Distance(A, B));  
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
			Point D = new Point(A - B);
			D.Print();
			for(Point i = new Point(); i.X < 10; i++)
			{
				i.Print();
			}
		}
	}
}
