using System;

namespace AppAreaPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro;
			Console.WriteLine ("Programa Que Calcula El Area Y El Perimetro De Un Cuadrado");
			Console.WriteLine ("Digite Lado");
			lado = float.Parse (Console.ReadLine ());
			area = lado * lado;
			Console.WriteLine ("El Area De Un Cuadrado Es:"+area);
			perimetro = 4 * lado;
			Console.WriteLine ("El Perimetro Es:"+perimetro);
			Console.ReadLine ();
		}
	}
}
