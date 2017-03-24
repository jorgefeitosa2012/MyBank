namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoTransfere = new System.Windows.Forms.Button();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textoBuscaTitular = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.AccessibleName = "";
            this.textoTitular.Location = new System.Drawing.Point(132, 19);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(130, 20);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(132, 58);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(130, 20);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.TextChanged += new System.EventHandler(this.textoNumero_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(132, 96);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(130, 20);
            this.textoSaldo.TabIndex = 2;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textoSaldo_TextChanged);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(132, 157);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(130, 20);
            this.textoValor.TabIndex = 3;
            this.textoValor.TextChanged += new System.EventHandler(this.textoValor_TextChanged);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(16, 199);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 4;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(106, 199);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposito.TabIndex = 5;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoTransfere);
            this.groupBox1.Controls.Add(this.comboDestinoTransferencia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoDeposito);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 237);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // botaoTransfere
            // 
            this.botaoTransfere.Location = new System.Drawing.Point(187, 199);
            this.botaoTransfere.Name = "botaoTransfere";
            this.botaoTransfere.Size = new System.Drawing.Size(75, 23);
            this.botaoTransfere.TabIndex = 12;
            this.botaoTransfere.Text = "Transferir";
            this.botaoTransfere.UseVisualStyleBackColor = true;
            this.botaoTransfere.Click += new System.EventHandler(this.botaoTransfere_Click);
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(132, 130);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(130, 21);
            this.comboDestinoTransferencia.TabIndex = 11;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboDestinoTransferencia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transfere";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botaoBusca);
            this.groupBox2.Controls.Add(this.textoBuscaTitular);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(111, 22);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(162, 21);
            this.comboContas.TabIndex = 8;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Escolha a Conta";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(19, 384);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 12;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(210, 384);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(75, 23);
            this.botaoImpostos.TabIndex = 13;
            this.botaoImpostos.Text = "Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Busca por Titular";
            // 
            // textoBuscaTitular
            // 
            this.textoBuscaTitular.Location = new System.Drawing.Point(111, 60);
            this.textoBuscaTitular.Name = "textoBuscaTitular";
            this.textoBuscaTitular.Size = new System.Drawing.Size(78, 20);
            this.textoBuscaTitular.TabIndex = 10;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(198, 60);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 11;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 419);
            this.Controls.Add(this.botaoImpostos);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botaoTransfere;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoBuscaTitular;
        private System.Windows.Forms.Label label7;
    }
}