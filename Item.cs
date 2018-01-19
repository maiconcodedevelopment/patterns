using System;

namespace patterns
{
	public class Item
	{
		public String nome { get; private set;}
		public double Valor { get; private set; }

		public Item (String nome, double valor )
		{
			this.nome = nome;
			this.Valor = valor;
		}

	}
}

