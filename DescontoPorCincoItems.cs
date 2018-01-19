using System;

namespace patterns
{
	public class DescontoPorCincoItems
	{
		public DescontoPorCincoItems ()
		{
			
		}

		public double Desconta(Orcamento orcamento){
			if(orcamento.Items.Count > 5){
				return orcamento.val * 0.1;
			}
			return 0;
		}
	}
}

