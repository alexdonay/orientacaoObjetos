using System;
using System.Windows.Forms;
namespace orientacaoObjetos
{
	public class Conta
	{
		//Define as propriedades da conta
		public int numeroDaConta { get; set; }
		public string titularConta { get; set; }
		public double saldoDaConta { get; set; }

		//Construtor da conta
		public Conta(int numeroDaConta, string titularConta, double saldoDaConta)
		{
			this.numeroDaConta = numeroDaConta;
			this.titularConta = titularConta;
			this.saldoDaConta = saldoDaConta;
		}
		//Apartir daqui defino os métodos da conta
		public bool Saca(double valor)
		{
			if (this.saldoDaConta >= valor)
			{
				this.saldoDaConta -= valor;
				MessageBox.Show($"o saldo atual da conta {this.numeroDaConta} é {this.saldoDaConta}");
				return true;
            }
            else
            {
				MessageBox.Show("Saldo insuficiente");
				return false;
            }
		}
		public void deposita(double valor)
        {
			this.saldoDaConta += valor;
        }
		public void transfere(double valor, Conta contaDestino)
        {
            if (this.Saca(valor))
            {
				contaDestino.deposita(valor);

			}

		}
	}

}
