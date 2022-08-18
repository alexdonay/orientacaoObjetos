namespace orientacaoObjetos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnSaca = new System.Windows.Forms.Button();
            this.txValorSaque = new System.Windows.Forms.TextBox();
            this.lbCriaConta = new System.Windows.Forms.Label();
            this.lblNomeCorrentista = new System.Windows.Forms.Label();
            this.txNomeCorrentista = new System.Windows.Forms.TextBox();
            this.txSaldoInicial = new System.Windows.Forms.TextBox();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.txNumeroConta = new System.Windows.Forms.TextBox();
            this.lblCodConta = new System.Windows.Forms.Label();
            this.lblValorSaque = new System.Windows.Forms.Label();
            this.lblCodContaSaque = new System.Windows.Forms.Label();
            this.txCodigoContaSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txCodigoContaDestinoTransferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTransfere = new System.Windows.Forms.Button();
            this.lblContaOrigem = new System.Windows.Forms.Label();
            this.txContaOrigemTransferencia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(12, 207);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(233, 58);
            this.btnNovaConta.TabIndex = 0;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnSaca
            // 
            this.btnSaca.Location = new System.Drawing.Point(295, 212);
            this.btnSaca.Name = "btnSaca";
            this.btnSaca.Size = new System.Drawing.Size(100, 49);
            this.btnSaca.TabIndex = 1;
            this.btnSaca.Text = "Saca";
            this.btnSaca.UseVisualStyleBackColor = true;
            this.btnSaca.Click += new System.EventHandler(this.btnSaca_Click);
            // 
            // txValorSaque
            // 
            this.txValorSaque.Location = new System.Drawing.Point(295, 167);
            this.txValorSaque.Name = "txValorSaque";
            this.txValorSaque.Size = new System.Drawing.Size(100, 20);
            this.txValorSaque.TabIndex = 2;
            // 
            // lbCriaConta
            // 
            this.lbCriaConta.AutoSize = true;
            this.lbCriaConta.Location = new System.Drawing.Point(13, 18);
            this.lbCriaConta.Name = "lbCriaConta";
            this.lbCriaConta.Size = new System.Drawing.Size(80, 13);
            this.lbCriaConta.TabIndex = 4;
            this.lbCriaConta.Text = "Cadastra Conta";
            // 
            // lblNomeCorrentista
            // 
            this.lblNomeCorrentista.AutoSize = true;
            this.lblNomeCorrentista.Location = new System.Drawing.Point(13, 100);
            this.lblNomeCorrentista.Name = "lblNomeCorrentista";
            this.lblNomeCorrentista.Size = new System.Drawing.Size(88, 13);
            this.lblNomeCorrentista.TabIndex = 5;
            this.lblNomeCorrentista.Text = "Nome Correntista";
            // 
            // txNomeCorrentista
            // 
            this.txNomeCorrentista.Location = new System.Drawing.Point(16, 116);
            this.txNomeCorrentista.Name = "txNomeCorrentista";
            this.txNomeCorrentista.Size = new System.Drawing.Size(229, 20);
            this.txNomeCorrentista.TabIndex = 6;
            // 
            // txSaldoInicial
            // 
            this.txSaldoInicial.Location = new System.Drawing.Point(16, 167);
            this.txSaldoInicial.Name = "txSaldoInicial";
            this.txSaldoInicial.Size = new System.Drawing.Size(229, 20);
            this.txSaldoInicial.TabIndex = 8;
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(13, 151);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(64, 13);
            this.lblSaldoInicial.TabIndex = 7;
            this.lblSaldoInicial.Text = "Saldo Inicial";
            // 
            // txNumeroConta
            // 
            this.txNumeroConta.Location = new System.Drawing.Point(16, 62);
            this.txNumeroConta.Name = "txNumeroConta";
            this.txNumeroConta.Size = new System.Drawing.Size(229, 20);
            this.txNumeroConta.TabIndex = 10;
            // 
            // lblCodConta
            // 
            this.lblCodConta.AutoSize = true;
            this.lblCodConta.Location = new System.Drawing.Point(13, 46);
            this.lblCodConta.Name = "lblCodConta";
            this.lblCodConta.Size = new System.Drawing.Size(90, 13);
            this.lblCodConta.TabIndex = 9;
            this.lblCodConta.Text = "Numero da Conta";
            // 
            // lblValorSaque
            // 
            this.lblValorSaque.AutoSize = true;
            this.lblValorSaque.Location = new System.Drawing.Point(292, 151);
            this.lblValorSaque.Name = "lblValorSaque";
            this.lblValorSaque.Size = new System.Drawing.Size(31, 13);
            this.lblValorSaque.TabIndex = 11;
            this.lblValorSaque.Text = "Valor";
            // 
            // lblCodContaSaque
            // 
            this.lblCodContaSaque.AutoSize = true;
            this.lblCodContaSaque.Location = new System.Drawing.Point(292, 100);
            this.lblCodContaSaque.Name = "lblCodContaSaque";
            this.lblCodContaSaque.Size = new System.Drawing.Size(86, 13);
            this.lblCodContaSaque.TabIndex = 13;
            this.lblCodContaSaque.Text = "Codigo da Conta";
            // 
            // txCodigoContaSaque
            // 
            this.txCodigoContaSaque.Location = new System.Drawing.Point(295, 116);
            this.txCodigoContaSaque.Name = "txCodigoContaSaque";
            this.txCodigoContaSaque.Size = new System.Drawing.Size(100, 20);
            this.txCodigoContaSaque.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo da Conta Destino";
            // 
            // txCodigoContaDestinoTransferencia
            // 
            this.txCodigoContaDestinoTransferencia.Location = new System.Drawing.Point(450, 116);
            this.txCodigoContaDestinoTransferencia.Name = "txCodigoContaDestinoTransferencia";
            this.txCodigoContaDestinoTransferencia.Size = new System.Drawing.Size(100, 20);
            this.txCodigoContaDestinoTransferencia.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(450, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // btnTransfere
            // 
            this.btnTransfere.Location = new System.Drawing.Point(450, 212);
            this.btnTransfere.Name = "btnTransfere";
            this.btnTransfere.Size = new System.Drawing.Size(100, 49);
            this.btnTransfere.TabIndex = 14;
            this.btnTransfere.Text = "Transfere";
            this.btnTransfere.UseVisualStyleBackColor = true;
            // 
            // lblContaOrigem
            // 
            this.lblContaOrigem.AutoSize = true;
            this.lblContaOrigem.Location = new System.Drawing.Point(447, 46);
            this.lblContaOrigem.Name = "lblContaOrigem";
            this.lblContaOrigem.Size = new System.Drawing.Size(122, 13);
            this.lblContaOrigem.TabIndex = 20;
            this.lblContaOrigem.Text = "Codigo da Conta Origem";
            // 
            // txContaOrigemTransferencia
            // 
            this.txContaOrigemTransferencia.Location = new System.Drawing.Point(450, 62);
            this.txContaOrigemTransferencia.Name = "txContaOrigemTransferencia";
            this.txContaOrigemTransferencia.Size = new System.Drawing.Size(100, 20);
            this.txContaOrigemTransferencia.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(538, 58);
            this.button1.TabIndex = 21;
            this.button1.Text = "Listar Contas Cadastradas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblContaOrigem);
            this.Controls.Add(this.txContaOrigemTransferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCodigoContaDestinoTransferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnTransfere);
            this.Controls.Add(this.lblCodContaSaque);
            this.Controls.Add(this.txCodigoContaSaque);
            this.Controls.Add(this.lblValorSaque);
            this.Controls.Add(this.txNumeroConta);
            this.Controls.Add(this.lblCodConta);
            this.Controls.Add(this.txSaldoInicial);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.txNomeCorrentista);
            this.Controls.Add(this.lblNomeCorrentista);
            this.Controls.Add(this.lbCriaConta);
            this.Controls.Add(this.txValorSaque);
            this.Controls.Add(this.btnSaca);
            this.Controls.Add(this.btnNovaConta);
            this.Name = "Form1";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button btnSaca;
        private System.Windows.Forms.TextBox txValorSaque;
        private System.Windows.Forms.Label lbCriaConta;
        private System.Windows.Forms.Label lblNomeCorrentista;
        private System.Windows.Forms.TextBox txNomeCorrentista;
        private System.Windows.Forms.TextBox txSaldoInicial;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.TextBox txNumeroConta;
        private System.Windows.Forms.Label lblCodConta;
        private System.Windows.Forms.Label lblValorSaque;
        private System.Windows.Forms.Label lblCodContaSaque;
        private System.Windows.Forms.TextBox txCodigoContaSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodigoContaDestinoTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnTransfere;
        private System.Windows.Forms.Label lblContaOrigem;
        private System.Windows.Forms.TextBox txContaOrigemTransferencia;
        private System.Windows.Forms.Button button1;
    }
}

