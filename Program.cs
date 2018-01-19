using System;

namespace patterns
{
	class MainClass
	{
		//Estrategy
		public static void Main (string[] args)
		{
			Imposto iss = new ISS ();
			Imposto icms = new ICMS ();

			Orcamento orcamento = new Orcamento (500.0);
			CalcularDeInposto calcular = new CalcularDeInposto();
			calcular.RealizaCalculo (orcamento, icms);

			Console.ReadKey ();
		}
	}
}
