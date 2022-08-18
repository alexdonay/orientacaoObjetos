using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace orientacaoObjetos
{
	public class Dados
	{
		public static readonly Dados instance = new Dados();
		public List<Conta> contas = new List<Conta>();

		public Dados() { }
		public static Dados Instance
		{
			get
			{
				return instance;
			}
		}
		public void addConta(Conta conta)
		{
			contas.Add(conta);

		}
		public Conta listarContasPorID(int numero)
		{
			Conta retorno = null;
			foreach (Conta items in this.contas)
			{
				if (items.numeroDaConta == numero)
				{
					return items;
				}
				else
				{
					retorno = null;
				}


			}
			return retorno;
		}
		public List<Conta> listarContas()
        {
			return this.contas;
        }
	}
}

