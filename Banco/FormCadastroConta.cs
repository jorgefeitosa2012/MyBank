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
using Banco.Busca;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        private ICollection<string> devedores;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            string indice = comboTipoConta.Text;

            if (indice.Equals(Conta.Tipo.Corrente.ToString()))
            {
                novaConta = new ContaCorrente();
            }
            else if (indice.Equals(Conta.Tipo.Poupanca.ToString()))
            {
                novaConta = new ContaPoupanca();
            }
            else if (indice.Equals(Conta.Tipo.Estudante.ToString()))
            {
                novaConta = new ContaEstudante();
            }

            novaConta.Titular = new Cliente(textoTitular.Text);
            //novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            bool ehDevedor = this.devedores.Contains(novaConta.Titular.ToString());
            if (!ehDevedor)
            {
                this.formPrincipal.AdicionaConta(novaConta);
                this.Close();
            }
            else
            {
                MessageBox.Show("devedor");
            }

        }


        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.ProximaConta());
            foreach (Conta.Tipo tipo in Enum.GetValues(typeof(Conta.Tipo)))
            {
                comboTipoConta.Items.Add(tipo);
            }
        }
    }
}
