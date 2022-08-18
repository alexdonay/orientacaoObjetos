using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orientacaoObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            //Cria uma conta nova
            Conta c = new Conta(int.Parse(txNumeroConta.Text), txNomeCorrentista.Text, double.Parse(txSaldoInicial.Text));
            Dados dados = Dados.Instance;
            dados.addConta(c);
            txNumeroConta.Text = "";
            txNomeCorrentista.Text = "";
            txSaldoInicial.Text = "";
            MessageBox.Show($"Conta Cadastrada com Sucesso \n numero da conta:{c.numeroDaConta} \n correntista {c.titularConta}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados dados = Dados.Instance;
            List<Conta> contas = dados.listarContas();
            string message = "";
            foreach(Conta conta in contas)
            {
                message = message +  "Código da conta: " +conta.numeroDaConta + "\n Titular: " + conta.titularConta +"\n";
            }
            
            MessageBox.Show(message);

        }

        private void btnSaca_Click(object sender, EventArgs e)
        {
            Dados dados = Dados.Instance;
            Conta contaSaque = dados.listarContasPorID(Convert.ToInt32(txCodigoContaSaque.Text));
            contaSaque.Saca(Convert.ToDouble(txValorSaque.Text));
        }   
    }

   
}
