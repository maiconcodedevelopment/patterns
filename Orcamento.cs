using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
	public class Orcamento{
		public double val { get; private set;}
		public IList<Item> Items { get; private set;}

		public Orcamento(double valor){
			this.val = valor;
			this.Items = new List<Item>();
		}

		public void adicionaItem(Item item){
			this.Items.Add (item);
		}

	}
}

