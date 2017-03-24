using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {

        private List<Conta> contas;

        // guarda o número de contas que já foram cadastradas
        private int numeroDeContas;

        private Dictionary<string, Conta> dicionario;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }


        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            this.numeroDeContas++;
            comboContas.Items.Add(conta);
            comboDestinoTransferencia.Items.Add(conta);

            this.dicionario.Add(conta.Titular.Nome, conta);

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            try
            {
                selecionada.Saca(valorOperacao);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;            double valor = Convert.ToDouble(textoValor.Text);

            try { 
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Argumento Inválido");
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

            this.dicionario = new Dictionary<string, Conta>();
            // criando o array para guardar as contas
            contas = new List<Conta>();

            // vamos inicializar algumas instâncias de Conta.
            Conta conta = new ContaPoupanca();
            conta.Titular = new Cliente("victor");
            conta.Numero = 1;
            this.AdicionaConta(conta);


            conta = new ContaPoupanca();
            conta.Titular = new Cliente("mauricio");
            conta.Numero = 2;
            this.AdicionaConta(conta);

            conta = new ContaCorrente();
            conta.Titular = new Cliente("osni");
            conta.Numero = 3;
            this.AdicionaConta(conta);

            // Mostra só o número da conta no combo box
            comboContas.DisplayMember = "Numero";


        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);

        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void botaoTransfere_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta) comboDestinoTransferencia.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            

            int indice2 = comboContas.SelectedIndex;
            Conta selecionada2 = contas[indice2];
            textoSaldo.Text = Convert.ToString(selecionada2.Saldo);
            selecionada2.Saca(valor);

            textoSaldo.Text = Convert.ToString(selecionada2.Saldo);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();

        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

            foreach(Conta c in contas){
                if (c is ContaCorrente) {
                    totalizador.Adiciona((ContaCorrente) c);
                }
            }
            
            MessageBox.Show("Total: " + totalizador.Total);
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            // Precisamos primeiro buscar qual é o nome do titular que foi digitado
            // no campo de texto
            string nomeTitular = textoBuscaTitular.Text;
            
            // Agora vamos usar o dicionário para fazer a busca.
            // Repare como o código de busca fica simples
            Conta conta = dicionario[nomeTitular];
            
            // E agora só precisamos mostrar a conta que foi encontrada na busca
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);

            comboContas.SelectedItem = conta;        }
    }
}
