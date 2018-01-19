using System;

namespace patterns
{
	public class CalculadorDeDesconto
	{
		public double Calcula(Orcamento orcamento){
			double desconto = new DescontoPorCincoItems().Desconta(orcamento);
			if(desconto == 0){
				desconto = new DescontoPorAcimaDeQuinhentos ().Desconta (orcamento);
			}

			return desconto;
			//continue regres descont 
		}

		public CalculadorDeDesconto ()
		{
		}
	}
}

