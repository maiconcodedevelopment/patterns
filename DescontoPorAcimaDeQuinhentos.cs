using System;

namespace patterns
{
	public class DescontoPorAcimaDeQuinhentos
	{
		public DescontoPorAcimaDeQuinhentos ()
		{
		}

		public double Desconta(Orcamento orcamento){
			if(orcamento.val > 500){
				return orcamento.val * 0.07;
			}
			return 0;
		}
	}
}

