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
			double x_dis = this.x - other.x;
			double y_dis = this.y - other.y;
			double distance = Math.Sqrt(Math.Pow(x_dis, 2) + Math.Pow(y_dis,2));
			return distance;
		}
		//public double X {  get; set; } //Автосвойства
		//public double Y { get; set; }
		public void Print()
		{
			Console.WriteLine("X = " + X + "\tY = " + Y);
		}
	}

}
