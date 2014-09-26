using System;

namespace AppMayorMenor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1, num2, suma, diferencia, producto, division;
			Console.WriteLine ("Programa Mayor De Los Numeros");
			Console.WriteLine ("Lea Numero 1:");
			num1 = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Lea Numero 2:");
			num2 = int.Parse (Console.ReadLine ());
			if(num1>num2)
			{
				suma = num1 + num2;
				diferencia = num1 - num2;
				Console.WriteLine ("La Suma Es:"+ suma);
				Console.WriteLine ("La Diferencia Es:"+ diferencia);
			}
			else
			{
				producto = num1 + num2;
				division = num1 / num2;
				Console.WriteLine ("El Producto Es:"+ producto);
				Console.WriteLine ("La Division Es:"+ division);
			}
			Console.ReadKey ();
		}
	}
}
