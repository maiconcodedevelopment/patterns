using System;

namespace patterns
{
	public class CalcularDeInposto
	{
		public void RealizaCalculo(Orcamento orcamento,Imposto imposto){
			double icms = imposto.Calcula(orcamento);
			Console.WriteLine (icms);
		}

		public CalcularDeInposto ()
		{
			
		}
	}
}

