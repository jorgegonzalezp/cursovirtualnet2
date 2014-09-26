using System;

namespace AppSumaDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Declaracion De Variables
			int numero1, numero2, suma;
			string Linea;
			Console.WriteLine ("Programa Que Calcula La Suma De Dos Numeros");
			Console.ReadKey ();
			Console.WriteLine ("Digite Numero 1:");
			Linea= Console.ReadLine ();
			numero1 = int.Parse (Linea);

			Console.WriteLine ("Digite Numero 2:");
			Linea= Console.ReadLine ();
			numero2 = int.Parse (Linea);
			suma = numero1 + numero2;
			Console.WriteLine ("La Suma Es:"+suma);
			Console.ReadKey ();


		}
	}
}
