using System;

namespace patterns
{
	public class ISS : Imposto
	{
		public ISS ()
		{
		}

		public double Calcula(Orcamento orcamento){
			return orcamento.val * 0.6;
		}
	}
}

