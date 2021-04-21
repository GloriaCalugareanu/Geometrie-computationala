using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Devide
{
	class Engine
	{
		public static Bitmap b;
		public static Graphics g;
		public static int resx;
		public static int resy;
		public static void InitGraph()
		{
			b = new Bitmap(resx, resy);
			g = Graphics.FromImage(b);
		}
		public static Random r = new Random();

		public static Point New { get; private set; }

		public static void initPoint()
		{
			for (int i = 0; i < Jarvis.n; i++)
			{
				Point New = new Point(r.Next(r.Next(50, 150), resx - r.Next(50, 150)), r.Next(r.Next(50, 150), resy - r.Next(50, 150)));

				/*Point A = new Point(200, 110);
				Point B = new Point(60, 270);
				Point C = new Point(90, 300);
				Point D = new Point(150, 210);
				Point E= new Point(180, 210);
				Point F= new Point(120, 270);
				Point G = new Point(90, 180);
				Point H= new Point(210, 360);
				Point I = new Point(210, 330);
				Point J= new Point(210, 300);
				*/

				Jarvis.Points.Add(New);

				/*Jarvis.Points.Add(A);
				Jarvis.Points.Add(B);
				Jarvis.Points.Add(C);
				Jarvis.Points.Add(D);
				Jarvis.Points.Add(E);
				Jarvis.Points.Add(F);
				Jarvis.Points.Add(G);
				Jarvis.Points.Add(H);
				Jarvis.Points.Add(I);
				Jarvis.Points.Add(J);*/

			}
		}

		public static void draw()
		{
			foreach (Point p in Jarvis.Points)
				g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);
		}
	}
}
