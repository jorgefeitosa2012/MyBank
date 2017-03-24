namespace Banco
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public int Idade { get; set; }
        public string Documentos { get; set; }
        public string Cpf { get; set; }



        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.Idade >= 18;
                var emancipado = this.Documentos.Contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.Cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;

            }
        }

    }
}