using System;

namespace patterns
{
	public class ICMS : Imposto
	{
		public ICMS ()
		{
		}

		public double Calcula(Orcamento orcamento){
			return orcamento.val * 0.1;
		}
	}
}

